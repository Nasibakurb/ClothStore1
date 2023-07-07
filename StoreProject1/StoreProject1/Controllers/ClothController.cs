using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using Microsoft.VisualStudio.Web.CodeGeneration.Contracts.Messaging;
using StoreProject1.DAL.interfaces;
using StoreProject1.Domain.Entity;
using StoreProject1.Domain.ViewModel.Cloth;
using StoreProject1.Service.interfaces;
using System.IO;
using System.Threading.Tasks;

namespace StoreProject1.Controllers
{
    public class ClothController : Controller
    {
        private readonly IClothService _clothService;

        public ClothController(IClothService clothService)
        {
            _clothService = clothService; // доступ к методам 
        }



        [HttpGet]
        public IActionResult GetClothes()
        {
            var response = _clothService.GetClothes(); // получить все товары
            if (response.StatusCode == Domain.Enum.StatusCode.OK) // если ошибка - 0 (нет ошибки)
            {
                return View(response.Data); // вывод данных
            }
            return View("Error", $"{response.Description}");
        }

        public async Task<IActionResult> Delete(int id) // получить 1 товар по id
        {
            var response = await _clothService.DeleteCloth(id); // удаляем по id
            if (response.StatusCode == Domain.Enum.StatusCode.OK) // если операция прошла успешно
            {
                return RedirectToAction("GetClothes"); ; // перенаправл.
            } // если не прошла успешно 
            return View("Error", $"{response.Description}"); // view (представл.) error с описанием 
        }


        public IActionResult Compare() => PartialView(); // compare возвращ. частичное представл. для сравнения.


        [HttpGet]
        public async Task<IActionResult> Save(int id) // 1 часть - получение товара по id
        {
            if (id == 0)
                return PartialView(); // пустое частично представл. (например для создание объекта перед его использ.)

            var response = await _clothService.GetCloth(id); // получение данных по id
            if (response.StatusCode == Domain.Enum.StatusCode.OK) // если Статус код - ОК
            {
                return PartialView(response.Data); // частичное представление с данными товара
            }                     // "" - ошибка относится к модели в целом, не к конкретн. свойству
            ModelState.AddModelError("", response.Description); // если не ОК, добавл. ошибки модели
            return PartialView(); // пустое частичное представление
        }

        [HttpPost]
        public async Task<IActionResult> Save(ClothViewModel viewModel) // 2 часть
        {
            ModelState.Remove("Id"); // удаление свойств, чтобы не валлидовались
            ModelState.Remove("DateCreate");

            if (ModelState.IsValid) // проверка на валидность
            {
                if (viewModel.Id == 0) // если такого id нету
                {
                    byte[] imageData; 
                    using (var binaryReader = new BinaryReader(viewModel.Avatar.OpenReadStream()))
                    { // сохранение изображ в массив байтов.
                        imageData = binaryReader.ReadBytes((int)viewModel.Avatar.Length);
                    }
                    await _clothService.Create(viewModel, imageData); // создание товара на основе модели и изображ.
                }
                else // если id найден 
                {
                    await _clothService.Edit(viewModel.Id, viewModel);
                }
            } 
            return RedirectToAction("GetClothes");
        }


        [HttpGet]
        public async Task<ActionResult> GetCloth(int id, bool isJson) // id и возвращ. в формате json
        { // метод возвращ детали товара Html или Json
            var response = await _clothService.GetCloth(id); // получение деталей о товаре
            if (isJson)
            {
                return Json(response.Data); // возвращ. в формат json 
            }
            return PartialView("GetCloth", response.Data); // частичн. представл. GetCloth c данными
        }

        [HttpPost]
        public async Task<IActionResult> GetCloth(string term) // term - для поиска товара 
        {
            var response = await _clothService.GetCloth(term); // поиск товара
            return Json(response.Data); // возвращ в формате json 
        }

        [HttpPost]
        public JsonResult GetTypes() // возвращ. типы товара
        {
            var types = _clothService.GetTypes(); // возвращ. типы товара
            return Json(types.Data); // в Json
        }

    }
}

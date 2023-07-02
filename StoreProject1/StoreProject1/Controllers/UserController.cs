using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using StoreProject1.Domain.Extensions;
using StoreProject1.Domain.ViewModel.User;
using StoreProject1.Service.interfaces;
using System.Linq;
using System.Threading.Tasks;

namespace StoreProject1.Controllers
{
    public class UserController : Controller
    {
        private readonly IUserService _userService;

        public UserController(IUserService userService)
        { // внедрение зависимости для использование методов
            _userService = userService;
        }

        public async Task<IActionResult> GetUsers()
        { // возвр список пользоват.
            var response = await _userService.GetUsers(); // вызов метода для получение списка
            if (response.StatusCode == Domain.Enum.StatusCode.OK) // если статус кода - ок
            {
                return View(response.Data); // список передается в представление
            } // иначе переадресация на представление Index
            return RedirectToAction("Index", "Home"); // иначе переадресация на представление Index
        }

        public async Task<IActionResult> DeleteUser(long id) 
        {
            var response = await _userService.DeleteUser(id); // удаление по id
            if (response.StatusCode == Domain.Enum.StatusCode.OK) // если все прошло успешно
            { // перенаправл. на действия / метод
                return RedirectToAction("GetUsers");
            }
            return RedirectToAction("Index", "Home");  // иначе переадресация на представление Index
        }

        public IActionResult Save() => PartialView(); // частичное представление для сохранение пользователя

        [HttpPost]
        public async Task<IActionResult> Save(UserViewModel model)
        {
            if (ModelState.IsValid) // если прошла валлидацию
            {
                var response = await _userService.Create(model); // создается объект 
                if (response.StatusCode == Domain.Enum.StatusCode.OK) // если метод сработал
                { // возвращает Json ответ с описанием успешнюго действия
                    return Json(new { description = response.Description });
                }
                return BadRequest(new { errorMessage = response.Description }); // сообщение об ошибке 
            } // если не прошла валлидацию 
            var errorMessage = ModelState.Values // собирается информация об ошибке из ModelState
                .SelectMany(v => v.Errors.Select(x => x.ErrorMessage)).ToList().Join(); // объединяет все ошибки
            return StatusCode(StatusCodes.Status500InternalServerError, new { errorMessage }); // статус ошибки и информация в формате Json
        }

        [HttpPost]
        public JsonResult GetRoles()
        { // возвращ. Json
            var types = _userService.GetRoles(); // вызов метода
            return Json(types.Data); // возвр. результат
        }
    }
}

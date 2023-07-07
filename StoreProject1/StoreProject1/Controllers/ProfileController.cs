using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using StoreProject1.Domain.ViewModel.Profile;
using StoreProject1.Service.interfaces;
using System.Threading.Tasks;

namespace StoreProject1.Controllers
{
    public class ProfileController : Controller
    {
        private readonly IProfileService _profileService;

        public ProfileController(IProfileService profileService)
        { // внедрение зависимости для использование методов
            _profileService = profileService;
        }

        [HttpPost]
        public async Task<IActionResult> Save(ProfileViewModel model)
        {
            ModelState.Remove("Id");
            ModelState.Remove("UserName"); // удаляются ошибки модели для свойств id и UserName 
            if (ModelState.IsValid) // валлидация
            {
                var response = await _profileService.Save(model); // метод сохраняет данные
                if (response.StatusCode == Domain.Enum.StatusCode.OK)
                { // возвр. ответ в виде json с описанием успешного действия
                    return Json(new { description = response.Description });
                }
            } // если не прошла валлидацию 
            return StatusCode(StatusCodes.Status500InternalServerError); // возвр. ошибку
        }

        public async Task<IActionResult> Detail()
        {
            var userName = User.Identity.Name; // получ. имя текущего пользователя
            var response = await _profileService.GetProfile(userName); // метод для получения профиля пользоват.
            if (response.StatusCode == Domain.Enum.StatusCode.OK) // если все прошло успешно
            { // возвр. результат в представление 
                return View(response.Data);
            }
            return View(); // пустое представл.
        }
    }
}

using Microsoft.AspNetCore.Authentication.Cookies;
using Microsoft.AspNetCore.Authentication;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System.Linq;
using System.Security.Claims;
using System.Threading.Tasks;
using StoreProject1.Domain.ViewModel.Account;
using StoreProject1.Service.interfaces;

namespace StoreProject1.Controllers
{
    public class AccountController : Controller
    {

        private readonly IAccountService _accountService;

        public AccountController(IAccountService accountService)
        { // внедрение зависимости для использование методов
            _accountService = accountService;
        }

        [HttpGet]
        public IActionResult Register() => View(); // направляет на представление с регистрацией

        [HttpPost]
        public async Task<IActionResult> Register(RegisterViewModel model)
        {
            if (ModelState.IsValid) // проверка на валлидацию
            {
                var response = await _accountService.Register(model); // метод регистрации нового пользоват.
                if (response.StatusCode == Domain.Enum.StatusCode.OK) // если прошло успешно
                {       
                    await HttpContext.SignInAsync(CookieAuthenticationDefaults.AuthenticationScheme,
                        new ClaimsPrincipal(response.Data));  // выполн. аутентификация нового пользоват

                    return RedirectToAction("Index", "Home"); // переадрес. на представл. Index
                }
                ModelState.AddModelError("", response.Description); // добавл информ. об общих ошибок ("") 
            }
            return View(model); // возвращается модель 
        }

        [HttpGet]
        public IActionResult Login() => View();  // направляет на представление с логина

        [HttpPost]
        public async Task<IActionResult> Login(LoginViewModel model)
        {
            if (ModelState.IsValid) // если прошла валлидацию
            {
                var response = await _accountService.Login(model); // вызов метода авторизации
                if (response.StatusCode == Domain.Enum.StatusCode.OK) // если все прошло успешно
                {   
                    await HttpContext.SignInAsync(CookieAuthenticationDefaults.AuthenticationScheme,
                        new ClaimsPrincipal(response.Data)); // выполн. аутентификация пользоват

                    return RedirectToAction("Index", "Home"); // переадрес. на представл. Index
                }
                ModelState.AddModelError("", response.Description); // добавл информ. об общих ошибок ("") 
            }
            return View(model); // возвращается модель 
        }

        [ValidateAntiForgeryToken] // защита от CSRF-атак 
        public async Task<IActionResult> Logout()
        {                       // удаляет аутентификацию
            await HttpContext.SignOutAsync(CookieAuthenticationDefaults.AuthenticationScheme);
            return RedirectToAction("Index", "Home"); // переадрес. на представл. Index
        }

        [HttpPost]
        public async Task<IActionResult> ChangePassword(ChangePasswordViewModel model)
        {
            if (ModelState.IsValid) // если проходит валлидацию
            {
                var response = await _accountService.ChangePassword(model); // метод для изменения пароля
                if (response.StatusCode == Domain.Enum.StatusCode.OK) // проверка на успешный статус код
                {   // возвр ответ в формате Json
                    return Json(new { description = response.Description });
                }
            } // если не прошла валлидацию, происходит сбор информации об ошибке
            var modelError = ModelState.Values.SelectMany(v => v.Errors);
                                   // SelectMany(v => v.Errors) для объединения ошибок в коллекцию

            return StatusCode(StatusCodes.Status500InternalServerError, new { modelError.FirstOrDefault().ErrorMessage });
        }  // извлекается первое сообщение из коллекции и возвр. ошибкой 500 и Json объектом
    }


}


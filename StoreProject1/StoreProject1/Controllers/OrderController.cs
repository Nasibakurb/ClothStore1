using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using StoreProject1.Domain.ViewModel.order;
using StoreProject1.Service.interfaces;
using System.Threading.Tasks;

namespace StoreProject1.Controllers
{
    public class OrderController : Controller
    {
        private readonly IOrderService _orderService;

        public OrderController(IOrderService orderService)
        { // внедрение зависимости для использование методов
            _orderService = orderService;
        }

        [HttpGet]
        public IActionResult CreateOrder(long id)
        {
            var orderModel = new CreateOrderViewModel() // создается объект
            { // передается свойства 
                ClothId = id,
                Login = User.Identity.Name, // аутентифиц. пользователь
                Quantity = 0 // количество покупок по умолчанию
            };
            return View(orderModel); // возвращает объект
        }

        [HttpPost]
        public async Task<IActionResult> CreateOrder(CreateOrderViewModel model)
        {
            if (ModelState.IsValid) // если проходит валидацию
            {
                var response = await _orderService.Create(model); // создается новый заказ в response
                if (response.StatusCode == Domain.Enum.StatusCode.OK) // если проходит без ошибок
                { // возвр. json ответ с описанием response.Description
                    return Json(new { description = response.Description });
                }
            } // если не прошла валидацию, возвр. ошибку
            return StatusCode(StatusCodes.Status500InternalServerError);
        }

        public async Task<IActionResult> Delete(int id)
        {
            var response = await _orderService.Delete(id); // вызов метода для удаление
            if (response.StatusCode == Domain.Enum.StatusCode.OK) // если все успешно прошло
            {
                return RedirectToAction("Index", "Home"); // перенапр. в представление Index
            } // если возникла ошибка, вернелся описание ошибки
            return View("Error", $"{response.Description}");
        }
    }
}

using Microsoft.AspNetCore.Mvc;
using StoreProject1.Service.interfaces;
using System.Linq;
using System.Threading.Tasks;

namespace StoreProject1.Controllers
{
    public class BasketController : Controller
    {
        private readonly IBasketService _basketService;

        public BasketController(IBasketService basketService)
        { // внедрение зависимости для использование методов
            _basketService = basketService;
        }

        public async Task<IActionResult> Detail()
        {                                          
            var response = await _basketService.GetItems(User.Identity.Name);
                                             // получ. элем. корзины для текущ. пользоват.
            if (response.StatusCode == Domain.Enum.StatusCode.OK)
            { // если статус равен ОК
                return View(response.Data.ToList()); // данные корзины передаются в представление.
            }
            return RedirectToAction("Index", "Home"); // иначе переадресация на представление Index
        }

        [HttpGet]
        public async Task<IActionResult> GetItem(long id)
        {
            var response = await _basketService.GetItem(User.Identity.Name, id);
                                    // получ. конкретный элемент корзины для текущего пользоват по его id
            if (response.StatusCode == Domain.Enum.StatusCode.OK)
            {   
                return PartialView(response.Data); // данные передаются в частичное представл.
                // для отобр результата в другом представлении 
            }
            return RedirectToAction("Index", "Home"); // иначе переадресация на представление Index
        }
    }
}


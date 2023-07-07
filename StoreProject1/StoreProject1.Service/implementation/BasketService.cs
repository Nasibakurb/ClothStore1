using Microsoft.EntityFrameworkCore;
using StoreProject1.DAL.interfaces;
using StoreProject1.Domain.Entity;
using StoreProject1.Domain.Enum;
using StoreProject1.Domain.Extensions;
using StoreProject1.Domain.Response;
using StoreProject1.Domain.ViewModel.order;
using StoreProject1.Service.interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.ConstrainedExecution;
using System.Text;
using System.Threading.Tasks;

namespace StoreProject1.Service.implementation
{
    public class BasketService : IBasketService
    {  // две зависимости репозитории 
        private readonly IBaseRepository<User> _userRepository;
        private readonly IBaseRepository<Cloth> _clothRepository;

        public BasketService(IBaseRepository<User> userRepository, IBaseRepository<Cloth> clothRepository)
        { // для работы с пользоват. и с товаром (осуществ. связь)
            _userRepository = userRepository;
            _clothRepository = clothRepository;
        }

        public async Task<IBaseResponse<IEnumerable<OrderViewModel>>> GetItems(string userName)
        { // возвр. список товаров в корзине
            try
            {
                var user = await _userRepository.GetAll() // все записи userRepos
                    .Include(x => x.Basket) // включить связь Basket
                    .ThenInclude(x => x.Orders) // включить связь Orders к Basket 
                    .FirstOrDefaultAsync(x => x.Name == userName); // первую запись по условию 

                if (user == null) // если пользователь не найден
                { // объект с информацией об ошибки
                    return new BaseResponse<IEnumerable<OrderViewModel>>()
                    {
                        Description = "Пользователь не найден",
                        StatusCode = StatusCode.UserNotFound
                    };
                }
                // если пользователь найден
                var orders = user.Basket?.Orders; // лист заказов из корзины
                var response = from p in orders // response содер. OrdVwModel, для кажд. заказа с информац. о товаре
                               join c in _clothRepository.GetAll() on p.ClothId equals c.Id // объедин.
                                                               // коллекцию одежды и заказов по id (clothId)
                               select new OrderViewModel() // новый объект OrderViewModel для связан. элементов
                               { // с = сloth, p - order
                                   Id = p.Id,
                                   ClothName = c.Name,
                                   Size = c.Size,
                                   TypeCloth = c.TypeCloth.GetDisplayName(), // для получение атрибута Display name
                                   Model = c.Model,
                                   Image = c.Avatar
                               };

                return new BaseResponse<IEnumerable<OrderViewModel>>()
                {
                    Data = response, // результат ЗАПРОСА (LINQ) - OrderViewModel  
                    StatusCode = StatusCode.OK  // сообщение об успехе
                };
            }
            catch (Exception ex)
            { // исключение сообщение об ошибки
                return new BaseResponse<IEnumerable<OrderViewModel>>()
                {
                    Description = ex.Message,
                    StatusCode = StatusCode.InternalServerError // проблемы с сервером
                };
            }
        }

        public async Task<IBaseResponse<OrderViewModel>> GetItem(string userName, long id)
        { // один заказ для определенного пользователя        // имя пользоват. и id заказа
            try
            {
                var user = await _userRepository.GetAll() // все записи userRepos
                    .Include(x => x.Basket) // включить связь Basket
                    .ThenInclude(x => x.Orders) // включить связь Order
                    .FirstOrDefaultAsync(x => x.Name == userName); // первую запись по условию 

                if (user == null)
                { // объект с сообщением об ошибке
                    return new BaseResponse<OrderViewModel>()
                    {
                        Description = "Пользователь не найден",
                        StatusCode = StatusCode.UserNotFound
                    };
                } // если пользователь найден
                
                // коллекция заказов пользоват. фильтруется по id и преобраз. в list
                var orders = user.Basket?.Orders.Where(x => x.Id == id).ToList(); 
                if (orders == null || orders.Count == 0)
                {   // если заказов нет, объект передает сообщение и статус кода
                    return new BaseResponse<OrderViewModel>()
                    {
                        Description = "Заказов нет",
                        StatusCode = StatusCode.OrderNotFound
                    };
                } // если заказ есть в корзине

                var response = (from o in orders //создается коллекция  // испол. о вместо orders
                                join c in _clothRepository.GetAll() on o.ClothId equals c.Id // объединяем
                                  // коллек. order с _clothRepository  с условием где связь между табл через id

                                select new OrderViewModel() // создаем новый объект OrderViewModel 
                                {   // присваиваем значения
                                    Id = o.Id,
                                    ClothName = c.Name,
                                    Size = c.Size,
                                    TypeCloth = c.TypeCloth.GetDisplayName(), // для получение атрибута Display name
                                    Model = c.Model,
                                    Address = o.Address,
                                    FirstName = o.FirstName,
                                    LastName = o.LastName,
                                    MiddleName = o.MiddleName,
                                    DateCreate = o.DateCreated.ToLongDateString(), // для получение строки (yyyy MM dd)
                                    Image = c.Avatar
                                }).FirstOrDefault(); // выбираем первый объект OrderViewModel
                
                return new BaseResponse<OrderViewModel>()
                { // результат запроса с сообщением об успехе
                    Data = response,
                    StatusCode = StatusCode.OK
                };
            }
            catch (Exception ex)
            { // исключение с сообщением об ошибке
                return new BaseResponse<OrderViewModel>()
                {
                    Description = ex.Message,
                    StatusCode = StatusCode.InternalServerError
                };
            }
        }
    }
}

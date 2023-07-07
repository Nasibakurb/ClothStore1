using Microsoft.EntityFrameworkCore;
using StoreProject1.DAL.interfaces;
using StoreProject1.Domain.Entity;
using StoreProject1.Domain.Enum;
using StoreProject1.Domain.Response;
using StoreProject1.Domain.ViewModel.order;
using StoreProject1.Service.interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StoreProject1.Service.implementation
{
    public class OrderService : IOrderService
    { // зависимости
        private readonly IBaseRepository<User> _userRepository;
        private readonly IBaseRepository<Order> _orderRepository;

        public OrderService(IBaseRepository<User> userRepository, IBaseRepository<Order> orderRepository)
        { // взаимодейств. с пользователем и заказами 
            _userRepository = userRepository;
            _orderRepository = orderRepository;
        }

        public async Task<IBaseResponse<Order>> Create(CreateOrderViewModel model)
        { // возвр. IBaseResponse<Order> 
            try
            {
                var user = await _userRepository.GetAll() // получ. всех пользоват.
                    .Include(x => x.Basket) // включить связь с Basket
                    .FirstOrDefaultAsync(x => x.Name == model.Login); // выбирает первую запись по условию
                if (user == null)
                { // если польз. не найден
                    return new BaseResponse<Order>()
                    { // возвр. объект с сообщением об ошибке
                        Description = "Пользователь не найден",
                        StatusCode = StatusCode.UserNotFound
                    };
                } // если польз. найден

                var order = new Order() // новый объект 
                { // заполн. свойства на основе данных из CreateOrderViewModel 
                    FirstName = model.FirstName,
                    LastName = model.LastName,
                    MiddleName = model.MiddleName,
                    Address = model.Address,
                    DateCreated = DateTime.Now,
                    BasketId = user.Basket.Id,
                    ClothId = model.ClothId
                };

                await _orderRepository.Create(order); // выполн. создание и сохранение
               
                return new BaseResponse<Order>()
                {  // объект с сообщением об успехе
                    Description = "Заказ создан",
                    StatusCode = StatusCode.OK
                };
            }
            catch (Exception ex)
            { // исключение и сообщение об ошибке 
                return new BaseResponse<Order>()
                {
                    Description = ex.Message,
                    StatusCode = StatusCode.InternalServerError
                };
            }
        }

        public async Task<IBaseResponse<bool>> Delete(long id)
        {
            try
            {
                var order = _orderRepository.GetAll() // получ. всех пользоват.
                    .Include(x => x.Basket) // включить связь с Basket
                    .FirstOrDefault(x => x.Id == id); // выбирает первую запись по условию

                if (order == null)
                { // если товар не найден
                    return new BaseResponse<bool>()
                    { // объект с сообщением об ошибке
                        StatusCode = StatusCode.OrderNotFound,
                        Description = "Заказ не найден"
                    };
                } // если товар найден

                await _orderRepository.Delete(order); // происходит удаление
                return new BaseResponse<bool>()
                { // объект с сообщением об успехе
                    StatusCode = StatusCode.OK,
                    Description = "Заказ удален"
                };
            }
            catch (Exception ex)
            { // исключение
                return new BaseResponse<bool>()
                {
                    Description = ex.Message,
                    StatusCode = StatusCode.InternalServerError
                };
            }
        }
    }
}

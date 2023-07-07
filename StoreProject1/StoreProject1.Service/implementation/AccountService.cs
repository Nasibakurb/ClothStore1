using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Logging;
using StoreProject1.DAL.interfaces;
using StoreProject1.Domain.Entity;
using StoreProject1.Domain.Enum;
using StoreProject1.Domain.Helpers;
using StoreProject1.Domain.Response;
using StoreProject1.Domain.ViewModel.Account;
using StoreProject1.Service.interfaces;
using System;
using System.Collections.Generic;
using System.Security.Claims;
using System.Threading.Tasks;

namespace StoreProject1.Service.implementation
{
    public class AccountService : IAccountService
    { // при создан. экземп. класса, нужно передать реализацию интерфейсов (зависимости)
        private readonly IBaseRepository<Profile> _proFileRepository;
        private readonly IBaseRepository<User> _userRepository;
        private readonly IBaseRepository<Basket> _basketRepository;
        private readonly ILogger<AccountService> _logger;

        public AccountService(IBaseRepository<User> userRepository,
            ILogger<AccountService> logger, IBaseRepository<Profile> proFileRepository,
            IBaseRepository<Basket> basketRepository) // принимает несколько зависимости
        { // внедрение для использование функцион.
            _userRepository = userRepository;
            _logger = logger;
            _proFileRepository = proFileRepository;
            _basketRepository = basketRepository;
        }

        public async Task<BaseResponse<ClaimsIdentity>> Register(RegisterViewModel model)
        {
            try
            {
                var user = await _userRepository.GetAll().FirstOrDefaultAsync(x => x.Name == model.Name);
                if (user != null)                          // выбирает первое значение по условию.
                {
                    return new BaseResponse<ClaimsIdentity>() // создается объект 
                    { // выводится сообщение об ошибки
                        Description = "Пользователь с таким логином уже есть",
                    };
                }
                // если пользователя нет
                user = new User() // создается новый пользователь
                { // заполняется поля
                    Name = model.Name,
                    Role = Role.User,
                    Password = HashPasswordHelper.HashPassowrd(model.Password), // происходит хэширование
                };

                await _userRepository.Create(user); // метод создания и сохранения

                var profile = new Profile()
                {
                    UserId = user.Id,
                };
                                         // создаются объекты // связь через id
                var basket = new Basket()
                {
                    UserId = user.Id
                };

                await _proFileRepository.Create(profile); // сохранение в дб
                await _basketRepository.Create(basket);
                var result = Authenticate(user); // выполн. аутентификация 

                return new BaseResponse<ClaimsIdentity>() // возвращается новый объект 
                { 
                    Data = result, // объект
                    Description = "Объект добавился", // сообщение
                    StatusCode = StatusCode.OK // статус кода
                };
            }
            catch (Exception ex) // ошибка
            {
                _logger.LogError(ex, $"[Register]: {ex.Message}");
                return new BaseResponse<ClaimsIdentity>() // новый объект
                { // описание и код ошибки 
                    Description = ex.Message,
                    StatusCode = StatusCode.InternalServerError
                };
            }
        }

        public async Task<BaseResponse<ClaimsIdentity>> Login(LoginViewModel model)
        { // реализует аутентификацию пользоват.
            try
            {
                var user = await _userRepository.GetAll().FirstOrDefaultAsync(x => x.Name == model.Name);
                if (user == null)                             // выбирается первое значение по условию
                {
                    return new BaseResponse<ClaimsIdentity>()
                    { // описание ошибки
                        Description = "Пользователь не найден"
                    };
                }
                //  если введеный пароль не совпадает с хэширован. паролем из дб
                if (user.Password != HashPasswordHelper.HashPassowrd(model.Password))
                { 
                    return new BaseResponse<ClaimsIdentity>()
                    { // объект с сообщением
                        Description = "Неверный пароль или логин"
                    };
                }
                var result = Authenticate(user); // успешкая аутентификация, возвращ метод ClaimsIdentity - индентификация пользоват.

                return new BaseResponse<ClaimsIdentity>()
                { // новый объект с результатом и статусом кода
                    Data = result,
                    StatusCode = StatusCode.OK
                };
            }
            catch (Exception ex)
            { // сообщение об ошибки и соответствующий статус кода
                _logger.LogError(ex, $"[Login]: {ex.Message}");
                return new BaseResponse<ClaimsIdentity>()
                {
                    Description = ex.Message,
                    StatusCode = StatusCode.InternalServerError
                };
            }
        }

        public async Task<BaseResponse<bool>> ChangePassword(ChangePasswordViewModel model)
        { // смена пароля 
            try
            {
                var user = await _userRepository.GetAll().FirstOrDefaultAsync(x => x.Name == model.UserName);
                if (user == null)                             // выбирается первое значение по условию
                { // если пользователь не найден
                    return new BaseResponse<bool>()
                    { // новый объект с описанием и статусом кода
                        StatusCode = StatusCode.UserNotFound,
                        Description = "Пользователь не найден"
                    };
                } // если пользователь найден
                 
                user.Password = HashPasswordHelper.HashPassowrd(model.NewPassword); // хэширование нового пароля
                await _userRepository.Update(user); // сохранение в дб

                return new BaseResponse<bool>() // новый объект с сообщение OK
                {
                    Data = true, // готовый объект
                    StatusCode = StatusCode.OK,
                    Description = "Пароль обновлен"
                };

            }
            catch (Exception ex)
            { // исключение и сообщение об ошибке
                _logger.LogError(ex, $"[ChangePassword]: {ex.Message}");
                return new BaseResponse<bool>()
                {
                    Description = ex.Message,
                    StatusCode = StatusCode.InternalServerError
                };
            }
        }

        private ClaimsIdentity Authenticate(User user)
        { // создает и возвращ объект ClaimsIdentity для аутентификации пользователя
            var claims = new List<Claim> // новый список утверждений 
            {
                new Claim(ClaimsIdentity.DefaultNameClaimType, user.Name), // 1. Имя пользователя
                new Claim(ClaimsIdentity.DefaultRoleClaimType, user.Role.ToString()) // 2. Роль
            };
            return new ClaimsIdentity(claims, "ApplicationCookie", // принимает список утвержд. для типа аутентиф. типа Куки
                ClaimsIdentity.DefaultNameClaimType, ClaimsIdentity.DefaultRoleClaimType); // возвращ. готовый объект для аутентиф.
        }
    }
}

using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Logging;
using StoreProject1.DAL.interfaces;
using StoreProject1.Domain.Entity;
using StoreProject1.Domain.Enum;
using StoreProject1.Domain.Extensions;
using StoreProject1.Domain.Helpers;
using StoreProject1.Domain.Response;
using StoreProject1.Domain.ViewModel.User;
using StoreProject1.Service.interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StoreProject1.Service.implementation
{
    public class UserService : IUserService
    {   // зависимости. Два репозитория. Один логгер
        private readonly ILogger<UserService> _logger; //
        private readonly IBaseRepository<Profile> _proFileRepository;
        private readonly IBaseRepository<User> _userRepository;

        public UserService(ILogger<UserService> logger, IBaseRepository<User> userRepository,
            IBaseRepository<Profile> proFileRepository)
        {
            _logger = logger; // сервис для отслежки работы сервиса и ошибок
            _userRepository = userRepository; // предоставл. функкционал для работы с пользоват. и профилям
            _proFileRepository = proFileRepository; // предоставл. функкционал для работы с профилем
        }

        public async Task<IBaseResponse<User>> Create(UserViewModel model)
        { // возвр. IBaseResponse<User>
            try
            {          // поиск пользоват. по имени и первый результат присваивается в переменную
                var user = await _userRepository.GetAll().FirstOrDefaultAsync(x => x.Name == model.Name);
                if (user != null)
                { // если пользоват. найден
                    return new BaseResponse<User>()
                    { // возвр. объект с сообщением об ошибке
                        Description = "Пользователь с таким логином уже есть",
                        StatusCode = StatusCode.UserAlreadyExists
                    };
                } // если пользоват. не найден
                user = new User() // создается новый объект
                { // заполняется поля 
                    Name = model.Name,
                    Role = Enum.Parse<Role>(model.Role),
                    Password = HashPasswordHelper.HashPassowrd(model.Password),
                };

                await _userRepository.Create(user); // метод создания и сохранения в дб

                var profile = new Profile() // создание нового объекта profile
                { // заполенение полей по умолчанию 
                    Address = string.Empty, // пустая строка
                    Age = 0,
                    UserId = user.Id,
                };

                await _proFileRepository.Create(profile); // метод создания и сохранения в дб
                
                return new BaseResponse<User>() // при успешных выполнение методов
                { // возвр. объект с результатом и сообщением об успехе
                    Data = user,
                    Description = "Пользователь добавлен",
                    StatusCode = StatusCode.OK
                };
            }
            catch (Exception ex)
            { // исключение и сообщение об ошибки 
                _logger.LogError(ex, $"[UserService.Create] error: {ex.Message}");
                return new BaseResponse<User>()
                {
                    StatusCode = StatusCode.InternalServerError,
                    Description = $"Внутренняя ошибка: {ex.Message}"
                };
            }
        }

        public BaseResponse<Dictionary<int, string>> GetRoles()
        { // возвр. словарь из индентифик. роли и строки - название роли 
            try
            {
                var roles = ((Role[])Enum.GetValues(typeof(Role))) // преобраз. в массив, после в словарь 
                    .ToDictionary(k => (int)k, t => t.GetDisplayName()); // k => (int)k - ключ,
                                              // t => t.GetDisplayName() - значение

                return new BaseResponse<Dictionary<int, string>>()
                { // возвр. объект с результатом
                    Data = roles,
                    StatusCode = StatusCode.OK
                };
            }
            catch (Exception ex)
            { // исключение возвр. объект с сообщением об ошибке
                return new BaseResponse<Dictionary<int, string>>()
                {
                    Description = ex.Message,
                    StatusCode = StatusCode.InternalServerError
                };
            }
        }

        public async Task<BaseResponse<IEnumerable<UserViewModel>>> GetUsers()
        {
            try
            {
                var users = await _userRepository.GetAll()
                    .Select(x => new UserViewModel()
                    {
                        Id = x.Id,
                        Name = x.Name,
                        Role = x.Role.GetDisplayName()
                    })
                    .ToListAsync();

                _logger.LogInformation($"[UserService.GetUsers] получено элементов {users.Count}");
                return new BaseResponse<IEnumerable<UserViewModel>>()
                {
                    Data = users,
                    StatusCode = StatusCode.OK
                };
            }
            catch (Exception ex)
            {
                _logger.LogError(ex, $"[UserSerivce.GetUsers] error: {ex.Message}");
                return new BaseResponse<IEnumerable<UserViewModel>>()
                {
                    StatusCode = StatusCode.InternalServerError,
                    Description = $"Внутренняя ошибка: {ex.Message}"
                };
            }
        }

        public async Task<IBaseResponse<bool>> DeleteUser(long id)
        { //  возвр. IBaseResponse<bool>
            try
            {
                var user = await _userRepository.GetAll().FirstOrDefaultAsync(x => x.Id == id);
                if (user == null)               // фильтрация по id, выбирает первый элемент
                { // если пользоват не найден
                    return new BaseResponse<bool>
                    { // возвр. статус код и значение false
                        StatusCode = StatusCode.UserNotFound,
                        Data = false
                    };
                } // если пользователь найден
                await _userRepository.Delete(user); // метод удаление
                _logger.LogInformation($"[UserService.DeleteUser] пользователь удален"); // в журнал записывается действие

                return new BaseResponse<bool>
                { // если пользователь удален, возвращается статус код и значение true
                    StatusCode = StatusCode.OK,
                    Data = true
                };
            }
            catch (Exception ex)
            { // исключение 
                _logger.LogError(ex, $"[UserSerivce.DeleteUser] error: {ex.Message}"); // в журнал записывается ошибка
                return new BaseResponse<bool>() 
                { // возвр. объект с сообщением об ошибке
                    StatusCode = StatusCode.InternalServerError,
                    Description = $"Внутренняя ошибка: {ex.Message}"
                };
            }
        }
    }
}

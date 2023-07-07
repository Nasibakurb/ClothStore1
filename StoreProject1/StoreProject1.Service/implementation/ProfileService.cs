using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Logging;
using StoreProject1.DAL.interfaces;
using StoreProject1.Domain.Entity;
using StoreProject1.Domain.Enum;
using StoreProject1.Domain.Response;
using StoreProject1.Domain.ViewModel.Profile;
using StoreProject1.Service.interfaces;
using System;
using System.Linq;
using System.Threading.Tasks;

namespace StoreProject1.Service.implementation
{
    public class ProfileService : IProfileService
    { // зависимости 
        private readonly ILogger<ProfileService> _logger; // сервис для отслежки работы сервиса и ошибок
        private readonly IBaseRepository<Profile> _profileRepository;

        public ProfileService(IBaseRepository<Profile> profileRepository,
            ILogger<ProfileService> logger)
        { //  _profileRepository -взаимодейств. с репозитор. и записывать ошибки - _logger
            _profileRepository = profileRepository;
            _logger = logger;
        }

        public async Task<BaseResponse<ProfileViewModel>> GetProfile(string userName)
        { // возвр rofileViewModel в оберт. BaseResponse
            try
            {
                var profile = await _profileRepository.GetAll() // получение всех профилей
                    .Select(x => new ProfileViewModel()  // преобраз. в ProfileViewModel
                    { // присвоен. свойств из Profile
                        Id = x.Id,
                        Address = x.Address,
                        Age = x.Age,
                        UserName = x.User.Name
                    })
                    .FirstOrDefaultAsync(x => x.UserName == userName); // выбор первого элемента по условию
                // положительный результат
                return new BaseResponse<ProfileViewModel>()
                {
                    Data = profile,
                    StatusCode = StatusCode.OK
                };
            }
            catch (Exception ex)
            { // исключение с сообщением об ошибке
                _logger.LogError(ex, $"[ProfileService.GetProfile] error: {ex.Message}");
                return new BaseResponse<ProfileViewModel>()
                {
                    StatusCode = StatusCode.InternalServerError,
                    Description = $"Внутренняя ошибка: {ex.Message}"
                };
            }
        }

        public async Task<BaseResponse<Profile>> Save(ProfileViewModel model)
        {
            try
            {
                var profile = await _profileRepository.GetAll() // получение все профили
                    .FirstOrDefaultAsync(x => x.Id == model.Id); // выбор первый профиль по условию

                profile.Address = model.Address; // обновляется значение из ProfileViewModel
                profile.Age = model.Age;

                await _profileRepository.Update(profile); // сохранение 
                // при успешном запросе создается новый объект с результатом и сообщением об успехе
                return new BaseResponse<Profile>()
                {
                    Data = profile,
                    Description = "Данные обновлены",
                    StatusCode = StatusCode.OK
                };
            }
            catch (Exception ex)
            { // исплючение и описание ошибки
                _logger.LogError(ex, $"[ProfileService.Save] error: {ex.Message}");
                return new BaseResponse<Profile>()
                {
                    StatusCode = StatusCode.InternalServerError,
                    Description = $"Внутренняя ошибка: {ex.Message}"
                };
            }
        }
    }
}

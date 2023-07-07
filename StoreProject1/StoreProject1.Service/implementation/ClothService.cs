using Microsoft.EntityFrameworkCore;
using StoreProject1.DAL.interfaces;
using StoreProject1.Domain.Entity;
using StoreProject1.Domain.Enum;
using StoreProject1.Domain.Extensions;
using StoreProject1.Domain.Response;
using StoreProject1.Domain.ViewModel.Cloth;
using StoreProject1.Service.interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.ConstrainedExecution;
using System.Threading.Tasks;

namespace StoreProject1.Service.implementation
{
    public class ClothService : IClothService
    {
        private readonly IBaseRepository<Cloth> _clothRepository;
        public ClothService(IBaseRepository<Cloth> clothRepository)
        {
            _clothRepository = clothRepository; // доступ к методам (удаление, добавл, поиск и т д)
        }
        public BaseResponse<Dictionary<int, string>> GetTypes() // при добавл товара позволяет выбрать тип товара через jquery
        { // возвращает информац. о типах одежды
            try
            {   
                var types = ((TypeCloth[])Enum.GetValues(typeof(TypeCloth))) // словарь из TypeCloth
                    .ToDictionary(k => (int)k, t => t.GetDisplayName()); // (например. 1 - Летняя одежда)

                return new BaseResponse<Dictionary<int, string>>() // создается объект
                { // его свойства
                    Data = types, // устанавл словарь (типы одежды) 
                    StatusCode = StatusCode.OK 
                };
            }
            catch (Exception ex)
            {
                return new BaseResponse<Dictionary<int, string>>() // создается объект
                { 
                    Description = ex.Message, // сообщение об ошибки
                    StatusCode = StatusCode.InternalServerError // ошибка сервера
                };
            }
        }




        public async Task<IBaseResponse<ClothViewModel>> GetCloth(long id)
        {
            try
            {
                var cloth = await _clothRepository.GetAll().FirstOrDefaultAsync(x => x.Id == id); // Библ. Linq.
                if (cloth == null)                          // выбираем первую запись по условию, где id подходящий
                {  // если id не найден
                    return new BaseResponse<ClothViewModel>() // создается новый объект
                    { // сообщения и код ошибки
                        Description = "Пользователь не найден",
                        StatusCode = StatusCode.UserNotFound
                    };
                }

                var data = new ClothViewModel()
                { // data равным объекту ClothViewModel
                    Name = cloth.Name,
                    Description = cloth.Description,
                    Model = cloth.Model,
                    Size = cloth.Size,
                    Price = cloth.Price,
                    DateCreate = cloth.DateCreate.ToLongDateString(), // приобразует в текстовый тип, длинной версии
                    TypeCloth = cloth.TypeCloth.ToString(),
                    Image = cloth.Avatar,
                };

                return new BaseResponse<ClothViewModel>() // сообщение что запрос прошел успешно
                {
                    StatusCode = StatusCode.OK,
                    Data = data
                };
            }
            catch (Exception ex)
            {
                return new BaseResponse<ClothViewModel>()
                {
                    Description = $"[GetCloth] : {ex.Message}",
                    StatusCode = StatusCode.InternalServerError
                };
            }
        }

        //...................................................................//
        public async Task<IBaseResponse<Cloth>> Create(ClothViewModel model, byte[] imageData)
        {
            try
            {
                var cloth = new Cloth() // создается новый обект
                {
                    Name = model.Name,
                    Model = model.Model,
                    Description = model.Description,
                    Size = model.Size,
                    Price = model.Price,
                    DateCreate = DateTime.Now,
                    TypeCloth = (TypeCloth)Convert.ToInt32(model.TypeCloth), // преобразуется в тип TypeCloth
                    Avatar = imageData
                };
                await _clothRepository.Create(cloth); // создается и сохраняется в дб

                return new BaseResponse<Cloth>() // создается новый объект 
                { // сообщения об успехе и cозданный объект
                    StatusCode = StatusCode.OK,
                    Data = cloth
                };
            }
            catch (Exception ex)
            {
                return new BaseResponse<Cloth>()
                {
                    Description = $"[Create] : {ex.Message}",
                    StatusCode = StatusCode.InternalServerError
                };
            }
        }

        public async Task<IBaseResponse<bool>> DeleteCloth(long id)
        {
            try
            {
                var cloth = await _clothRepository.GetAll().FirstOrDefaultAsync(x => x.Id == id);
                if (cloth == null)                            // первый объект соответств. id
                { // если объект не найден
                    return new BaseResponse<bool>()
                    {
                        Description = "User not found",
                        StatusCode = StatusCode.UserNotFound,
                        Data = false
                    };
                }

                await _clothRepository.Delete(cloth); // удалление из базы данных 

                return new BaseResponse<bool>() // новый объект ответа
                {
                    Data = true, // успешное удаление
                    StatusCode = StatusCode.OK
                };
            }
            catch (Exception ex)
            {
                return new BaseResponse<bool>()
                {
                    Description = $"[DeleteCloth] : {ex.Message}",
                    StatusCode = StatusCode.InternalServerError
                };
            }
        }


        public async Task<BaseResponse<Dictionary<long, string>>> GetCloth(string term) 
        {
            var baseResponse = new BaseResponse<Dictionary<long, string>>();
            try
            {
                var clothes = await _clothRepository.GetAll() // получение всех объектов
                    .Select(x => new ClothViewModel() // cloth в ClothViewModel, выбираются нужные свойства
                    {
                        Id = x.Id,
                        Name = x.Name,
                        Description = x.Description,
                        Model = x.Model,
                        Size = x.Size,
                        Price = x.Price,
                        DateCreate = x.DateCreate.ToLongDateString(),
                        TypeCloth = x.TypeCloth.GetDisplayName()
                    })
                    .Where(x => EF.Functions.Like(x.Name, $"%{term}%")) // фильтрация по условию tern
                    .ToDictionaryAsync(x => x.Id, t => t.Name); // резутат - словарь id и  Name

                baseResponse.Data = clothes; // словарь записываются в свойство data
                return baseResponse; // результат с сообщением об успехе
            }
            catch (Exception ex)
            {
                return new BaseResponse<Dictionary<long, string>>()
                {
                    Description = ex.Message,
                    StatusCode = StatusCode.InternalServerError
                };
            }
        }


        public async Task<IBaseResponse<Cloth>> Edit(long id, ClothViewModel model)
        {
            try
            {
                var cloth = await _clothRepository.GetAll().FirstOrDefaultAsync(x => x.Id == id);

                if (cloth == null)                          // первый объект соответств. id
                {
                    return new BaseResponse<Cloth>() // создается объект с ошибкой 
                    {
                        Description = "Cloth not found",
                        StatusCode = StatusCode.ClothNotFound
                    };
                }
                // обновление значений 
                cloth.Name = model.Name;
                cloth.Description = model.Description;
                cloth.Model = model.Model;
                cloth.Size = model.Size;
                cloth.Price = model.Price;
                cloth.DateCreate = DateTime.ParseExact(model.DateCreate, "yyyyMMdd HH:mm", null);

                await _clothRepository.Update(cloth); // сохранения 

                return new BaseResponse<Cloth>()
                {
                    StatusCode = StatusCode.OK,
                    Data = cloth // обновленный товар 
                };
            }
            catch (Exception ex)
            {
                return new BaseResponse<Cloth>()
                {
                    Description = $"[Edit] : {ex.Message}",
                    StatusCode = StatusCode.InternalServerError
                };
            }
        }

        public IBaseResponse<List<Cloth>> GetClothes()
        {
            try
            {
                var clothes = _clothRepository.GetAll().ToList(); // получение всех товаров
                if (!clothes.Any()) // если список пуст
                {
                    return new BaseResponse<List<Cloth>>()
                    {
                        Description = "Найдено 0 элементов",
                        StatusCode = StatusCode.OK
                    };
                }
                // если список имеет элементы 
                return new BaseResponse<List<Cloth>>() // создается список
                {
                    Data = clothes, // список товаров
                    StatusCode = StatusCode.OK
                };
            }
            catch (Exception ex)
            {
                return new BaseResponse<List<Cloth>>()
                { // сообщения об ошибки и код ошибки.
                    Description = $"[GetClothes]: {ex.Message}",
                    StatusCode = StatusCode.InternalServerError
                };
            }
        }

    
    }
}

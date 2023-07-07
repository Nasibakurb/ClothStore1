using System.Collections.Generic;
using System.Threading.Tasks;
using StoreProject1.Domain.Entity;
using StoreProject1.Domain.Response;
using StoreProject1.Domain.ViewModel.Cloth;

namespace StoreProject1.Service.interfaces
{
    public interface IClothService
    { // набор методов
        BaseResponse<Dictionary<int, string>> GetTypes(); // словарь 
        IBaseResponse<List<Cloth>> GetClothes(); // список
        Task<IBaseResponse<ClothViewModel>> GetCloth(long id); // поиск по id // long имеет диапозон больше чем int 
        Task<BaseResponse<Dictionary<long, string>>> GetCloth(string term); // словарь из идентификат. и строки 
        Task<IBaseResponse<Cloth>> Create(ClothViewModel clothViewModel, byte[] imageData); // удаление по укрочен. модели и картинки
        Task<IBaseResponse<bool>> DeleteCloth(long id); // удаление по id
        Task<IBaseResponse<Cloth>> Edit(long id, ClothViewModel model); // ищем по id и редактируем по модельки
    }
}

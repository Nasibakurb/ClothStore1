using StoreProject1.Domain.Response;
using StoreProject1.Domain.ViewModel.order;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StoreProject1.Service.interfaces
{
    public interface IBasketService
    {
        // возвр. коллекцию объектов OrderViewModel, обернут. в IBaseResponse
        // (содерж информ. об успешном выполн. или ошибку)
        Task<IBaseResponse<IEnumerable<OrderViewModel>>> GetItems(string userName);

        // возвр. объект OrderViewModel, обернут. в IBaseResponse
        // (содерж. информ. об успешном выполн. или ошибку)
        Task<IBaseResponse<OrderViewModel>> GetItem(string userName, long id); // для получ. отдельного элемента корзины для указан. пользоват.
    }
}

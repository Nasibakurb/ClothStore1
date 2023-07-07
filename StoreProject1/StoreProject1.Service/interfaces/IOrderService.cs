using StoreProject1.Domain.Entity;
using StoreProject1.Domain.Response;
using StoreProject1.Domain.ViewModel.order;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StoreProject1.Service.interfaces
{

    public interface IOrderService
    {
        // возвр. объект Order, обернут. в IBaseResponse (содерж информ. об успешном выполн. или ошибку)
        Task<IBaseResponse<Order>> Create(CreateOrderViewModel model);


        // возвр. true или false и IBaseResponse (содерж информ. об успешном выполн. или ошибку)
        Task<IBaseResponse<bool>> Delete(long id);
    }
}

using StoreProject1.Domain.Entity;
using StoreProject1.Domain.Response;
using StoreProject1.Domain.ViewModel.User;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StoreProject1.Service.interfaces
{
    public interface IUserService
    {
        Task<IBaseResponse<User>> Create(UserViewModel model); // возвращ. <IBaseResponse<User> содерж пользоват. или сообщение об ошибки

        BaseResponse<Dictionary<int, string>> GetRoles(); // возвращ. словарь идентификатор и значение (роль)

        Task<BaseResponse<IEnumerable<UserViewModel>>> GetUsers(); // возвращ. коллекцию информац. о пользоват.

        Task<IBaseResponse<bool>> DeleteUser(long id); // возвращ. <IBaseResponse<bool> (true или false)
    }
}

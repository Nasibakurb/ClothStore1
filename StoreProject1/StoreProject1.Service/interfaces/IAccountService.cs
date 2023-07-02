using StoreProject1.Domain.Response;
using StoreProject1.Domain.ViewModel.Account;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Claims;
using System.Text;
using System.Threading.Tasks;

namespace StoreProject1.Service.interfaces
{
    public interface IAccountService
    {  // методы для работы с акаунтом 
        //возвращ. объект Task<BaseResponse<ClaimsIdentity>>, который представл. результат оепрации регистрац.
        Task<BaseResponse<ClaimsIdentity>> Register(RegisterViewModel model); // ClaimsIdentity - идентификатор пользоват.

        Task<BaseResponse<ClaimsIdentity>> Login(LoginViewModel model);

        Task<BaseResponse<bool>> ChangePassword(ChangePasswordViewModel model);
    }
}

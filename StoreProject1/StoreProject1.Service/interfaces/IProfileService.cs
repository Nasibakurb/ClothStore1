using StoreProject1.Domain.Entity;
using StoreProject1.Domain.Response;
using StoreProject1.Domain.ViewModel.Profile;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StoreProject1.Service.interfaces
{
    public interface IProfileService
    {
        // возвр. ProfileViewModel обернут. в IBaseResponse (содерж информ.
        // об успешном выполн. или ошибку)
        Task<BaseResponse<ProfileViewModel>> GetProfile(string userName);


        // возвр. Profile (для сохранение в дб)
        Task<BaseResponse<Profile>> Save(ProfileViewModel model);
    }
}

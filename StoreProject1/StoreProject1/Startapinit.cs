using Microsoft.Extensions.DependencyInjection;
using StoreProject1.DAL.interfaces;
using StoreProject1.DAL.Repositories;
using StoreProject1.Domain.Entity;
using StoreProject1.Service.implementation;
using StoreProject1.Service.interfaces;

namespace StoreProject1
{
    public  static class Startapinit
    {
        public static void InitializeRepositories(this IServiceCollection services)
        {
            services.AddScoped<IBaseRepository<Profile>, ProfileRepository>();
            services.AddScoped<IBaseRepository<Basket>, BasketRepository>();
            services.AddScoped<IBaseRepository<User>, UserRepository>();
            services.AddScoped<IBaseRepository<Cloth>, ClothRepository>();
            services.AddScoped<IBaseRepository<Order>, OrderRepository>();
        }

        public static void InitializeService(this IServiceCollection services)
        {
          
            services.AddScoped<IBasketService, BasketService>();
            services.AddScoped<IUserService, UserService>();
            services.AddScoped<IProfileService, ProfileService>();
            services.AddScoped<IClothService, ClothService>();
            services.AddScoped<IAccountService, AccountService>();
            services.AddScoped<IOrderService, OrderService>();

        }
    }
}

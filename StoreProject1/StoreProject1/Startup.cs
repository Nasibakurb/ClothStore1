using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.HttpsPolicy;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;
using StoreProject1.DAL.Repositories;
using Microsoft.EntityFrameworkCore;
using StoreProject1.DAL;
using StoreProject1.Service.interfaces;
using StoreProject1.Service.implementation;
using Microsoft.AspNetCore.Authentication.Cookies;
using StoreProject1.DAL.interfaces;
using StoreProject1.Domain.Entity;

namespace StoreProject1
{
    public class Startup
    {
        public Startup(IConfiguration configuration)
        {
            Configuration = configuration;
        }

        public IConfiguration Configuration { get; }

        // This method gets called by the runtime. Use this method to add services to the container.
        public void ConfigureServices(IServiceCollection services)
        {
            services.AddControllersWithViews().AddRazorRuntimeCompilation();

            var connection = Configuration.GetConnectionString("MyConnection");
            services.AddDbContext<ApplicationDbContext>(options =>
                options.UseSqlServer(connection)); // регистрация ApplicationDbContext

            services.AddAuthentication(CookieAuthenticationDefaults.AuthenticationScheme)
           .AddCookie(options =>
           {
               // Настройки cookie аутентификации
               options.LoginPath = "/Account/Login"; // Путь к странице входа
               options.AccessDeniedPath = "/Account/Login"; // Путь к странице доступа запрещен
                                                                   // Другие настройки...
           });

            services.InitializeRepositories();
            services.InitializeService();

        }

        // This method gets called by the runtime. Use this method to configure the HTTP request pipeline.
        public void Configure(IApplicationBuilder app, IWebHostEnvironment env)
        {
            if (env.IsDevelopment())
            {
                app.UseDeveloperExceptionPage();
            }
            else
            {
                app.UseExceptionHandler("/Home/Error");
                // The default HSTS value is 30 days. You may want to change this for production scenarios, see https://aka.ms/aspnetcore-hsts.
                app.UseHsts();
            }
            app.UseHttpsRedirection();
            app.UseStaticFiles();

            app.UseRouting();

            app.UseAuthorization();

            app.UseAuthentication();

            app.UseEndpoints(endpoints =>
            {
                endpoints.MapControllerRoute(
                    name: "default",
                    pattern: "{controller=Home}/{action=Index}/{id?}");
            });
        }
    }
}

using Microsoft.EntityFrameworkCore;
using StoreProject1.Domain.Entity;
using StoreProject1.Domain.Enum;
using StoreProject1.Domain.Helpers;
using System;

namespace StoreProject1.DAL
{
    public class ApplicationDbContext: DbContext
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options) : base(options)
        // представл контекст для работы набором данных // options - для настройки связи с дб.
        {
            Database.EnsureCreated();
        }

        // DbSet представ. коллекц. сущности в дб 
        public DbSet<Cloth> Cloth { get; set; }  // подкл. к набору данных из дб
        public DbSet<User> Users { get; set; }
        public DbSet<Profile> Profiles { get; set; }
        public DbSet<Basket> Baskets { get; set; }
        public DbSet<Order> Orders { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder) // настройки моделей в дб
        { // правила отобр. классов на таблицы и связи между ними.
            modelBuilder.Entity<User>(builder =>
            {
                builder.ToTable("Users").HasKey(x => x.Id); // PK (Primary Key)
                
                builder.HasData(new User[] // // заполнение изначал. полей для Админа и Модератора
                {
                    new User()
                    {
                        Id = 1,
                        Name = "Admin",
                        Password = HashPasswordHelper.HashPassowrd("admin"), // приобраз в хэширование (зашифровка)
                        Role = Role.Admin
                    },
                    new User()
                    {
                        Id = 2,
                        Name = "Moderator",
                        Password = HashPasswordHelper.HashPassowrd("moderator"),
                        Role = Role.Moderator
                    }
                });

                builder.Property(x => x.Id).ValueGeneratedOnAdd(); // инкременция 

                builder.Property(x => x.Password).IsRequired(); // обязательное к заполн.
                builder.Property(x => x.Name).HasMaxLength(50).IsRequired(); // обязательное к заполн. и макс. длина - 50 симв
                
                //связи
                builder.HasOne(x => x.Profile) //
                    .WithOne(x => x.User)
                    .HasPrincipalKey<User>(x => x.Id) // связь по PK User id 
                    .OnDelete(DeleteBehavior.Cascade); // при удален User удаляется Profile 
                // User - id, Profile и Basket - UserId
                builder.HasOne(x => x.Basket)
                    .WithOne(x => x.User)
                    .HasPrincipalKey<User>(x => x.Id)
                    .OnDelete(DeleteBehavior.Cascade);  // при удален User удаляется Basket 
            });
            //.............................................//
            modelBuilder.Entity<Cloth>(builder => // настройка класса Cloth в дб
            { 
                builder.ToTable("clothes").HasKey(x => x.Id); // PK

                builder.HasData(new Cloth // заполнение данными
                {
                    Id = 1,
                    Name = "KN",
                    Description = new string('A', 50), // создает структуру из 50 символов "А"
                    Model = "Adidas",
                    Size = 46,
                    Avatar = null,
                    DateCreate = DateTime.Now,
                    TypeCloth = TypeCloth.SummerClothes
                }) ;
            });
            //.............................................//
            modelBuilder.Entity<Profile>(builder => // настройки класса profile
            {
                builder.ToTable("Profiles").HasKey(x => x.Id); // PK

                builder.Property(x => x.Id).ValueGeneratedOnAdd(); // инкременция
                builder.Property(x => x.Age); 
                builder.Property(x => x.Address).HasMaxLength(200).IsRequired(false); // макс. 200 символов и необязат. поле

                builder.HasData(new Profile() // заполнение полей 
                {
                    Id = 1,
                    UserId = 1
                });
            });
            //.............................................//
            modelBuilder.Entity<Basket>(builder => // настройки Корзины
            {
                builder.ToTable("Baskets").HasKey(x => x.Id); // PK

                builder.HasData(new Basket() // заполнение
                {
                    Id = 1,
                    UserId = 1
                });
            });
            //.............................................//
            modelBuilder.Entity<Order>(builder => // настройка Заказов
            {
                builder.ToTable("Orders").HasKey(x => x.Id); // PK
                // basket - id, order - basketId
                builder.HasOne(r => r.Basket).WithMany(t => t.Orders)
                    .HasForeignKey(r => r.BasketId);
            });
        }
    }
}

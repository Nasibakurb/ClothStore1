using StoreProject1.DAL.interfaces;
using StoreProject1.Domain.Entity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StoreProject1.DAL.Repositories
{ // реализация интерфейса
    public class BasketRepository : IBaseRepository<Basket>
    {
        private readonly ApplicationDbContext _db; 

        public BasketRepository(ApplicationDbContext dbContext)
        {
            _db = dbContext; // контекст дб
        }

        public async Task Create(Basket entity)
        {
            await _db.Baskets.AddAsync(entity); // добавляет объект в дб
            await _db.SaveChangesAsync(); // сохраняет
        }

        public IQueryable<Basket> GetAll()
        {
            return _db.Baskets; // все сущности // работает на стороне дб (не на стороне клиента)
        }

        public async Task Delete(Basket entity)
        {
            _db.Baskets.Remove(entity); // удаляет из дб 
            await _db.SaveChangesAsync(); // сохранение
        }

        public async Task<Basket> Update(Basket entity)
        {
            _db.Baskets.Update(entity); // обновляет 
            await _db.SaveChangesAsync();

            return entity; // возвращает обновленный объект Basket
        }
    }
    }

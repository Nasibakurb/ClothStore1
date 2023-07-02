using StoreProject1.DAL.interfaces;
using StoreProject1.Domain.Entity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StoreProject1.DAL.Repositories
{  // реализация интерфейса
    public class OrderRepository : IBaseRepository<Order>
    {
        private readonly ApplicationDbContext _db;

        public OrderRepository(ApplicationDbContext db)
        {
            _db = db; // контекст дб
        }

        public async Task Create(Order entity)
        {
            await _db.Orders.AddAsync(entity); // добавляет объект в дб
            await _db.SaveChangesAsync();
        }

        public IQueryable<Order> GetAll()
        {
            return _db.Orders; // все сущности // работает на стороне дб (не на стороне клиента)
        }

        public async Task Delete(Order entity)
        {
            _db.Orders.Remove(entity); // удаляет из дб
            await _db.SaveChangesAsync();
        }

        public async Task<Order> Update(Order entity)
        {
            _db.Orders.Update(entity);  // обновляет
            await _db.SaveChangesAsync(); // сохранение

            return entity;
        }
    }
}

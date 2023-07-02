using Microsoft.EntityFrameworkCore;
using StoreProject1.DAL.interfaces;
using StoreProject1.Domain.Entity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.ConstrainedExecution;
using System.Text;
using System.Threading.Tasks;

namespace StoreProject1.DAL.Repositories
{
    public class ClothRepository : IBaseRepository<Cloth> // для работы с дб 
    {
        private readonly ApplicationDbContext _db;
        
        public ClothRepository(ApplicationDbContext db)
        {
            _db = db; // для получ. контекста дб для работы с данными
        }


        public IQueryable<Cloth> GetAll() // IQueryable работает на стороне дб (IEnumerable на стороне клиента)
        {
            return _db.Cloth;
        }

        public async Task Create(Cloth entity)
        {
            await _db.Cloth.AddAsync(entity);
            await _db.SaveChangesAsync();
          
        }

        public async Task Delete(Cloth entity)
        {
            _db.Cloth.Remove(entity); // удаляет 1 объект
            await _db.SaveChangesAsync(); // сохраняем
            
        }

        public async Task<Cloth> Update(Cloth entity)
        {
             _db.Cloth.Update(entity);  // обновляем объект
            await _db.SaveChangesAsync();
            return entity;
        }
    }
}

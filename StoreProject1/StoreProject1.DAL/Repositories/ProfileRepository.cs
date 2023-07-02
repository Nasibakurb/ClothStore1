using StoreProject1.DAL.interfaces;
using StoreProject1.Domain.Entity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StoreProject1.DAL.Repositories
{  // реализация интерфейса
    public class ProfileRepository : IBaseRepository<Profile>
    {
        private readonly ApplicationDbContext _dbContext;

        public ProfileRepository(ApplicationDbContext dbContext)
        {
            _dbContext = dbContext; // контекст дб
        }

        public async Task Create(Profile entity)
        {
            await _dbContext.Profiles.AddAsync(entity); // создает новый объект
            await _dbContext.SaveChangesAsync(); // сохраняет
        }

        public IQueryable<Profile> GetAll() // все сущности в виде запроса IQueryable
        { 
            return _dbContext.Profiles;  // IQueryable работает на стороне дб (IEnumerable на стороне клиента)
        }

        public async Task Delete(Profile entity)
        {
            _dbContext.Profiles.Remove(entity); // удаляет
            await _dbContext.SaveChangesAsync(); // сохраняет
        }

        public async Task<Profile> Update(Profile entity)
        {
            _dbContext.Profiles.Update(entity); // обновляет
            await _dbContext.SaveChangesAsync(); 

            return entity; // возвращает объект
        }
    }
}


using StoreProject1.DAL.interfaces;
using StoreProject1.Domain.Entity;
using System.Linq;
using System.Threading.Tasks;

namespace StoreProject1.DAL.Repositories
{
    public class UserRepository : IBaseRepository<User>
    {
        private readonly ApplicationDbContext _db;

        public UserRepository(ApplicationDbContext db)
        {
            _db = db; // для получ. контекста дб для работы с данными
        }

        public IQueryable<User> GetAll() // IQueryable работает на стороне дб(IEnumerable на стороне клиента)

        {
            return _db.Users;
        }

        public async Task Delete(User entity)
        {
            _db.Users.Remove(entity); // удаляет 1 объект
            await _db.SaveChangesAsync(); // сохраняем
        }

        public async Task Create(User entity) 
        {
            await _db.Users.AddAsync(entity);
            await _db.SaveChangesAsync();
        }

        public async Task<User> Update(User entity)
        {
            _db.Users.Update(entity); // обновляем объект
            await _db.SaveChangesAsync();

            return entity;
        }
    }
}

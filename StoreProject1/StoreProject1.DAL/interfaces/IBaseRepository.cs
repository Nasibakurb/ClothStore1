using StoreProject1.Domain.Entity;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace StoreProject1.DAL.interfaces
{
    public interface IBaseRepository<T> // набор операц  // Джинерик (T - определенный объект Например User или Cloth)
    {
        Task Create(T entity);

        IQueryable<T> GetAll(); // возвращ. коллекцию 

        Task Delete(T entity); // T (класс) entity - обьект (поле в моделе)

        Task<T> Update(T entity);

    }
}
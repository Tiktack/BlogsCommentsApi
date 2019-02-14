using System.Collections.Generic;

namespace DataLayer.Interfaces.Repositories
{
    public interface IRepository<TEntity> where TEntity : class
    {
        void Insert(TEntity item);
        void Delete(int id);
        void Update(TEntity item);
        TEntity GetById(int id);
        IEnumerable<TEntity> GetAll();
    }
}

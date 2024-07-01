using Microsoft.EntityFrameworkCore.ChangeTracking;
using WebAccountant.ModelsBase;

namespace WebAccountant.Repository
{
    public interface IBaseRepo<T> where T : class
    {
        public Task<IEnumerable<T>> GetAllAsync();
        public Task<EntityEntry<T>> AddNew(T entity);
        public Task Update(string key, string values);
        public Task Delete(string key);
        
    }
}

using Microsoft.EntityFrameworkCore;
using System.Linq.Expressions;
using WebAccountant.ModelsBase;

namespace WebAccountant.DAOs
{
    public class GenericDAO<T> where T:class 
    {
        private readonly TIENHIEU2024Context _context;
        private readonly DbSet<T> _dbSet;
        public GenericDAO(TIENHIEU2024Context context)
        {
            _context = context;
            _dbSet = _context.Set<T>();
        }

        public async Task<bool> Add(T entity)
        {
            await _dbSet.AddAsync(entity);
            return true;
        }

        public async Task<IEnumerable<T>> Find(Expression<Func<T, bool>> expression, int entry, int page, Func<IQueryable<T>, IOrderedQueryable<T>> orderBy = null,
                        string includeProperties = "")
        {
            IQueryable<T> query = _dbSet.Where(expression);

            foreach (var includeProperty in includeProperties.Split(new char[] { ',' }, StringSplitOptions.RemoveEmptyEntries))
            {
                query = query.Include(includeProperty);
            }
            if (orderBy != null)
            {
                query = orderBy(query);
            }
            return await query.Skip((page - 1) * entry).Take(entry).ToListAsync();
        }

        public async Task<IEnumerable<T>> GetAll()
        {
            return await _dbSet.ToListAsync();
        }

        public async Task<T> GetById(int id)
        {
            return await _dbSet.FindAsync(id);
        }

        public async Task<bool> Remove(int id)
        {
            var entity = await _dbSet.FindAsync(id);
            if (entity != null)
            {
                _dbSet.Remove(entity);
                return true;
            }
            else { return false; }
        }

        public async Task<bool> Update(T entity)
        {
            _dbSet.Update(entity);
            return true;
        }
    }
}

﻿using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.ChangeTracking;
using System.Linq.Expressions;
using WebAccountant.ModelsBase;

namespace WebAccountant.DAOs
{
    public class GenericDAO<T,TContext> where T:class where TContext : DbContext
    {
        private readonly TContext _context;
        private readonly DbSet<T> _dbSet;
        public GenericDAO(TContext context)
        {
            _context = context;
            _dbSet = _context.Set<T>();
        }

        public async Task<EntityEntry<T>> Add(T entity)
        {
            return await _dbSet.AddAsync(entity);
        }
        public async Task AddRange(IEnumerable<T> entities)
        {
             await _dbSet.AddRangeAsync(entities);
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
        public async Task<bool> RemoveEntity(T entity)
        {
            if (entity != null)
            {
                _dbSet.Remove(entity);
                return true;
            }
            else { return false; }
        }
        public async Task<bool> RemoveRange(IEnumerable<T> entities)
        {
            if (entities != null)
            {
                _dbSet.RemoveRange(entities);
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

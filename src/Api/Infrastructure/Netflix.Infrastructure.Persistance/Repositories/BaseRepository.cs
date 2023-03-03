using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Query;
using Netflix.Api.Domain.Entities;
using Netflix.Infrastructure.Persistance.Repositories.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace Netflix.Infrastructure.Persistance.Repositories
{
    public class BaseRepository<T> : IRepository<T> where T : BaseEntity
    {
        protected DbContext _context;

        public BaseRepository(DbContext context)
        {
            _context = context;
        }

        protected DbSet<T> dbSet => _context.Set<T>();

        public async Task<T> AddAsync(T entity)
        {
            await dbSet.AddAsync(entity);
            await _context.SaveChangesAsync();
            return entity;
        }

        public async Task<int> AddRangeAsync(IEnumerable<T> entities)
        {
            await dbSet.AddRangeAsync(entities);
            return await _context.SaveChangesAsync();
        }

        public async Task<T> DeleteAsync(T entity)
        {
            if (_context.Entry(entity).State == EntityState.Detached)
                dbSet.Attach(entity);

             dbSet.Remove(entity);
            await _context.SaveChangesAsync();
            return entity;
        }

        public async Task<T> DeleteAsync(int id)
        {
            var entity = await dbSet.FindAsync(id);
            return await DeleteAsync(entity);
        }

        public async Task<int> DeleteRangeAsync(IEnumerable<T> entities)
        {
            dbSet.RemoveRange(entities);
            return await _context.SaveChangesAsync();
        }


        //public IQueryable<T> AsQueryable() => dbSet.AsQueryable();
    
        public async Task<T> GetAsync(Expression<Func<T, bool>> predicate, Func<IQueryable<T>, IIncludableQueryable<T, object>>? include = null, bool disaableTracking = true, CancellationToken cancellationToken = default)
        {
            IQueryable<T> query = dbSet.AsQueryable();
            if (!disaableTracking)
                query.AsNoTracking();

            if (include != null)
                query = include(query);

           var entity=await query.Where(predicate).FirstOrDefaultAsync();

            return entity;


        }

        public async Task<List<T>> GetListAsync(Expression<Func<T, bool>>? predicate = null, Func<IQueryable<T>, IIncludableQueryable<T, object>>? include = null, Func<IQueryable<T>, IOrderedQueryable<T>>? orderBy = null, bool disableTracking = true, CancellationToken cancellationToken = default)
        {
        IQueryable<T> query=dbSet.AsQueryable();

            if (!disableTracking)
                query.AsNoTracking();

            if (include !=null)
                query = include(query);

            if(predicate!=null)
                query=query.Where(predicate);

            if (orderBy != null)
                orderBy(query);

            return await query.ToListAsync();
        }

        public async Task<T> UpdateAsync(T entity)
        {
            dbSet.Attach(entity);
            _context.Entry(entity).State = EntityState.Modified;
            await _context.SaveChangesAsync();
            return entity;
        }
    }
}

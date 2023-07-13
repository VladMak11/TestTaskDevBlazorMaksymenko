using BlazorAppDataAccess.Interfaces;
using BlazorAppwithIdentity.Data;
using Microsoft.EntityFrameworkCore.ChangeTracking;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace BlazorAppDataAccess.Repository
{
    public class Repository<T> : IRepository<T> where T : class
    {
        private readonly ApplicationDbContext _db;
        internal DbSet<T> _dbSet;
        public Repository(ApplicationDbContext db)
        {
            _db = db;
            _dbSet = _db.Set<T>();
        }
        public async Task AddAsync(T item)
        {
            await _dbSet.AddAsync(item);
        }

        public async Task<IEnumerable<T>> GetAllAsync(Expression<Func<T, bool>>? paramFilter = null, params string[] includeProp)
        {
            IQueryable<T> curentQuery = _dbSet;
            if (paramFilter != null)
            {
                curentQuery = curentQuery.Where(paramFilter);
            }
            if (includeProp != null)
            {
                foreach (var itemProp in includeProp)
                {
                    curentQuery = curentQuery.Include(itemProp);
                }
            }
            return await curentQuery.ToListAsync();
        }

        public async Task<T> GetFirstOrDefaultAsync(Expression<Func<T, bool>> paramFilter, params string[] includeProp)
        {
            IQueryable<T> curentQuery = _dbSet;
            curentQuery = curentQuery.Where(paramFilter);
            if (includeProp != null)
            {
                foreach (var itemProp in includeProp)
                {
                    curentQuery = curentQuery.Include(itemProp);
                }
            }
            return await curentQuery.FirstOrDefaultAsync();
        }

        public async Task RemoveAsync(int id)
        {
            var item = await _dbSet.FindAsync(id);
            EntityEntry entityEntry = _db.Entry<T>(item);
            entityEntry.State = EntityState.Deleted;
        }

        public async Task UpdateAsync(T item)
        {
            EntityEntry entityEntry = _db.Entry<T>(item);
            entityEntry.State = EntityState.Modified;
        }
    }
}

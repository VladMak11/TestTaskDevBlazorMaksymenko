using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace BlazorAppDataAccess.Interfaces
{
    public interface IRepository<T> where T : class
    {
        Task<T> GetFirstOrDefaultAsync(Expression<Func<T, bool>> paramFilter, params string[] includeProp);
        Task<IEnumerable<T>> GetAllAsync(Expression<Func<T, bool>>? paramFilter = null, params string[] includeProp);
        Task AddAsync(T item);
        Task RemoveAsync(int id);
        Task UpdateAsync(T item);
    }
}

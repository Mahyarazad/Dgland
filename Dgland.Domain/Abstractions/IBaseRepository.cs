

using System.Linq.Expressions;
using System.Linq;
using System.Threading.Tasks;
using System.Threading;
using System;

namespace Dgland.Domain.Abstractions
{
    public interface IBaseRepository<T, TKey> where T : class
    {
        Task<T> AddAsync(T entity, CancellationToken cancellationToken = default);
        Task<bool> AnyAsync(string stringValue, string fieldValue, CancellationToken cancellationToken = default);
        void Delete(T entity);
        void Update(T entity, CancellationToken cancellationToken = default);

        Task<T> GetByIdAsync(TKey key, CancellationToken cancellationToken = default);

        //Task<IQueryable<T>> GetListAsync(Expression<Func<T, bool>> predicate
        //    , Func<IQueryable<T>, IIncludableQueryable<T, object>> include = null!);
    }
}

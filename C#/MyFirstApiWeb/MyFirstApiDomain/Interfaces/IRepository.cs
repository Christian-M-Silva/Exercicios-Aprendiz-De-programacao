using MyFirstApiDomain.Entities;
using System;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace MyFirstApiDomain.Interfaces{
    public interface IRepository<T> where T: BaseEntitie{
        Task<T> InsertAsync (T item);
        Task<T> UpdateAsync (T item);
        Task<bool> DeleteAsync (Guid id);
        Task<T> SelectAsync (Guid id);
        Task<IEnumerable<T>> SelectAsync();
    }
}

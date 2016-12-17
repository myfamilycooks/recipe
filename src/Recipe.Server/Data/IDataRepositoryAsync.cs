using System;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace Recipe.Server.Data
{
    public interface IDataRepositoryAsync<T>
    {
        Task<T> GetById(Guid id);
        Task<T> Insert(T entity);
        Task<T> Update(T entity);
        Task Delete(T entity);
        Task<List<T>> GetAll();
    }
}
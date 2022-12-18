using System;
using System.Collections.Generic;
using System.Linq.Expressions;
using System.Threading.Tasks;
using eTickets.Models;

namespace eTickets.Data.Base
{
    public interface IEntityBaseRepository<T> where T:class,IEntityBase,new()
    {
        Task<IEnumerable<T>> GetAll();
        Task<IEnumerable<T>> GetAllAsync(params Expression<Func<T, object>>[] includeProperties);
        Task<T> GetById(int id);
        void Add(T entity);
        Task Update(int id, T entity);
        Task Delete(int id);
    }
}
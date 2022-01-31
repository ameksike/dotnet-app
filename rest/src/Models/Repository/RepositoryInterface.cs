using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

using rest.src.Models.DAO;
using rest.src.Models.ORM;
namespace rest.src.Models.Repository
{
    public interface RepositoryInterface<T> where T : class, IEntity
    {
        Task<List<T>> List();
        Task<T> Select(int id);
        Task<T> Create(T entity);
        Task<T> Update(T entity);
        Task<T> Delete(int id);
        bool Exists(int id);
    }
}

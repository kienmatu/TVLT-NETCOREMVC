using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace NewsApp
{
    public interface IRepository<T>
    {
        Task Add(T entity);
        bool Exist(int id);
        Task Update(T entity);
        Task Remove(int id);
        T FindByID(int id);
        List<T> GetAll();
    }
}

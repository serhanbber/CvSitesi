using CVEntity.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CVEntity.Business.Interfaces
{
    public interface IService<T> where T:BaseDTO
    {
        List<T> GetList();
        T GetSingle(int entityID);
        bool Save(T entity, out string message);
        bool Update(T entity, out string message);
        bool Delete(int ID, out string message);
        IQueryable<T> GetQueryable();
    }
}

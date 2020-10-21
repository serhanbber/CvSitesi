using CVEntity.Business.Interfaces;
using CVEntity.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CVEntity.Business.Services
{
    public class MyWorkService : BaseService, IService<MyWorkDTO>
    {
        public bool Delete(int ID, out string message)
        {
            throw new NotImplementedException();
        }

        public List<MyWorkDTO> GetList()
        {
            throw new NotImplementedException();
        }

        public IQueryable<MyWorkDTO> GetQueryable()
        {
            throw new NotImplementedException();
        }

        public MyWorkDTO GetSingle(int entityID)
        {
            throw new NotImplementedException();
        }

        public bool Save(MyWorkDTO entity, out string message)
        {
            throw new NotImplementedException();
        }

        public bool Update(MyWorkDTO entity, out string message)
        {
            throw new NotImplementedException();
        }
    }
}

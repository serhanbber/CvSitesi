using CVEntity.Business.Interfaces;
using CVEntity.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CVEntity.Business.Services
{
    public class AdressService : BaseService, IService<AdressDTO>
    {
        public bool Delete(int ID, out string message)
        {
            throw new NotImplementedException();
        }

        public List<AdressDTO> GetList()
        {
            throw new NotImplementedException();
        }

        public IQueryable<AdressDTO> GetQueryable()
        {
            throw new NotImplementedException();
        }

        public AdressDTO GetSingle(int entityID)
        {
            throw new NotImplementedException();
        }

        public bool Save(AdressDTO entity, out string message)
        {
            throw new NotImplementedException();
        }

        public bool Update(AdressDTO entity, out string message)
        {
            throw new NotImplementedException();
        }
    }
}

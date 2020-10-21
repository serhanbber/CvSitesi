using CVEntity.Business.Interfaces;
using CVEntity.Models;
using CVEntity.Dal.Entityframework;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CVEntity.Business.Services
{
    public class AboutService : BaseService, IService<AboutDTO>
    {
        public bool Delete(int ID, out string message)
        {
            throw new NotImplementedException();
        }

        public List<AboutDTO> GetList()
        {
            try
            {
                return GetQueryable().ToList();
            }
            catch (Exception ex)
            {
                return null;
            }
        }

        public IQueryable<AboutDTO> GetQueryable()
        {
            return from a in DbModel.Hakkimda
                   select new AboutDTO()
                   {
                       Bilgiler=a.Bilgiler,
                       Egitim=a.Egitim,
                       IsDeneyim=a.IsDeneyimleri,
                   };
        }

        public AboutDTO GetSingle(int entityID)
        {
            try
            {
                return GetQueryable().FirstOrDefault(x => x.ID == entityID);
            }
            catch (Exception ex)
            {
                return null;
            }
        }

        public bool Save(AboutDTO entity, out string message)
        {
            throw new NotImplementedException();
        }

        public bool Update(AboutDTO entity, out string message)
        {
            throw new NotImplementedException();
        }
    }
}

using CVEntity.Business.Interfaces;
using CVEntity.Dal.Entityframework;
using CVEntity.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CVEntity.Business.Services
{
    public class SkilService : BaseService, IService<SkilDTO>
    {
        public bool Delete(int ID, out string message)
        {
            message = "Kayıt Silindi";
            try
            {
                var ytnk = DbModel.Yetenekler.Find(ID);
                if (ytnk == null)
                    throw new Exception("Silinecek yetenek Bulunamadı");
                DbModel.Yetenekler.Remove(ytnk);
                DbModel.SaveChanges();
                return true;
            }
            catch (Exception ex)
            {
                message = "Hata" + ex.Message;
                return false;
            }
        }

        public List<SkilDTO> GetList()
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

        public IQueryable<SkilDTO> GetQueryable()
        {
            return from y in DbModel.Yetenekler
                   select new SkilDTO()
                   {
                       ID=y.ID,
                       Yetenekler=y.Yetenek,
                       Derece=y.Derece
                   };
        }

        public SkilDTO GetSingle(int entityID)
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

        public bool Save(SkilDTO entity, out string message)
        {
            message = "Kullanıcı Kayıt edildi";
            try
            {
                Yetenekler k = new Yetenekler()
                {
                    Yetenek = entity.Yetenekler,
                    Derece = entity.Derece,

                };
                DbModel.Yetenekler.Add(k);
                DbModel.SaveChanges();
                return true;
            }
            catch (Exception ex)
            {
                message = "Hata" + ex.Message;
                return false;
            }
        }

        public bool Update(SkilDTO entity, out string message)
        {
            message = "Güncelleme Başarılı";
            try
            {
                var model = DbModel.Yetenekler.Find(entity.ID);
                if (model == null)
                    throw new Exception("Belirtilen yetenek Bulunamadı");

                model.ID = entity.ID;
                model.Yetenek = entity.Yetenekler;



                DbModel.SaveChanges();
                return true;

            }
            catch (Exception ex)
            {
                message = "HATA" + ex.Message;
                return false;

            }
        }
    }
}

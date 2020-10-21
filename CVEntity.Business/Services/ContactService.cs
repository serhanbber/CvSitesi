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
    public class ContactService : BaseService, IService<ContactDTO>
    {
        public bool Delete(int ID, out string message)
        {
            message = "Kayıt Silindi";
            try
            {
                var konu = DbModel.Iletisim.Find(ID);
                if (konu == null)
                    throw new Exception("Silinecek konu Bulunamadı");
                DbModel.Iletisim.Remove(konu);
                DbModel.SaveChanges();
                return true;
            }
            catch (Exception ex)
            {
                message = "Hata" + ex.Message;
                return false;
            }
        }

        public List<ContactDTO> GetList()
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

        public IQueryable<ContactDTO> GetQueryable()
        {
            return from c in DbModel.Iletisim
                   select new ContactDTO()
                   {
                       ID=c.ID,
                       AdSoyad=c.AdSoyad,
                       Mail=c.Mail,
                       Mesaj=c.Mesaj,
                       Konu=c.Konu
                      
                   };
        }

        public ContactDTO GetSingle(int entityID)
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

        public bool Save(ContactDTO entity, out string message)
        {
            message = "Kullanıcı Kayıt edildi";
            try
            {
                Iletisim k = new Iletisim()
                {
                    AdSoyad=entity.AdSoyad,
                    Mail=entity.Mail,
                    Mesaj=entity.Mesaj,
                    Konu=entity.Konu
                   
                };
                DbModel.Iletisim.Add(k);
                DbModel.SaveChanges();
                return true;
            }
            catch (Exception ex)
            {
                message = "Hata" + ex.Message;
                return false;
            }
        }

        public bool Update(ContactDTO entity, out string message)
        {
            message = "Güncelleme Başarılı";
            try
            {
                var model = DbModel.Iletisim.Find(entity.ID);
                if (model == null)
                    throw new Exception("Belirtilen kullanici Bulunamadı");

                model.ID = entity.ID;
                model.AdSoyad = entity.AdSoyad;
                model.Mail = entity.Mail;
                model.Mesaj = entity.Mesaj;
                model.Konu = entity.Konu;
                


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

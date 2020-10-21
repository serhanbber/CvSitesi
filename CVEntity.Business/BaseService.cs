using CVEntity.Dal;
using CVEntity.Dal.Entityframework;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CVEntity.Business.Services
{
    public class BaseService
    {
        public static CVOzgecmisDBEntities DbModel { get; set; }

        public BaseService()
        {
            DbModel = DBHelper.CreateDB();
        }
       
    }
}

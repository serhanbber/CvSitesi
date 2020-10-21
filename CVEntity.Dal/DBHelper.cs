using CVEntity.Dal.Entityframework;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CVEntity.Dal
{
    public class DBHelper
    {
        public DBHelper()
        {

        }
        private static CVOzgecmisDBEntities DB { get; set; }

        public static CVOzgecmisDBEntities CreateDB()
        {
            DB = DB ?? new CVOzgecmisDBEntities();
            return DB;
        }

    }
}

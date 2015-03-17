using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace NatuurApp.DataAccessLayer
{
   public class DataAccess
   {
        private static DataAccess dal = new DataAccess();
        //internal APIDB db = new APIDB();
        EmbededDB EDB = new EmbededDB();
        private DataAccess() { }
        public static DataAccess GetInstance
        {
            get
            {
                if (dal == null)
                {
                    dal = new DataAccess();
                }
                return dal;
            }
        }
    }
}

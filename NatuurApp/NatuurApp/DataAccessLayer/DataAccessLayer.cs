using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace NatuurApp.DataAccessLayer
{
   public class DataAccessLayer
    {
<<<<<<< HEAD
        private DataAccessLayer dal = new DataAccessLayer();
        //internal APIDB db = new APIDB();
        private DataAccessLayer()
        {

        }

        public DataAccessLayer GetInstance
=======
        private static DataAccessLayer dal = new DataAccessLayer();
        internal DB db = new DB();
        private DataAccessLayer() { }
        public static DataAccessLayer GetInstance
>>>>>>> origin/master
        {
            get
            {
                if (dal == null)
                {
                    dal = new DataAccessLayer();
                }
                return dal;
            }
        }
    }
}

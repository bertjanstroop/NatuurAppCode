using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace NatuurApp.DataAccessLayer
{
   public class DataAccessLayer
    {
        private DataAccessLayer dal = new DataAccessLayer();
        //internal APIDB db = new APIDB();
        private DataAccessLayer()
        {

        }

        public DataAccessLayer GetInstance
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

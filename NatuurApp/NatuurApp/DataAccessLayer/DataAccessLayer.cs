using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace NatuurApp.DataAccessLayer
{
    class DataAccessLayer
    {
        private DB db = new DB();
        private DataAccessLayer()
        {

        }

        public DB GetInstance()
        {
            if (db == null)
            {
                db = new DB();
            }
            return db;
        }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace NatuurApp.DataAccessLayer
{
    class DB
    {
        private DB db = new DB();
        private DB();
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

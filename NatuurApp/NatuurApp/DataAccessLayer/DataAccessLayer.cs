﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace NatuurApp
{
   public class DataAccessLayer
    {
        private static DataAccessLayer dal = new DataAccessLayer();
        internal DB db = new DB();
        private DataAccessLayer() { }
        public static DataAccessLayer GetInstance
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

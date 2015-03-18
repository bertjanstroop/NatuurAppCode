﻿using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data;
using NatuurApp.DataAccessLayer;

namespace NatuurApp.BusinessLogicLayer
{
    class AreaViewController
    {
        public AreaViewController()
        {
            
        }

        public tbl_NatureArea GetAreaByID(int ID)
        {
            return DataAccess.GetInstance.db.GetAreaByID(ID);
        }

        public tbl_NatureAreaFoto GetAreaFotoByID(int AreaID)
        {
            return DataAccess.GetInstance.db.GetAreaFotoByID(AreaID);
        }
    }
}
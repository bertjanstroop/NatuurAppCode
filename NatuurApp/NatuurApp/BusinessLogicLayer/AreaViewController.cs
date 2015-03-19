using System;
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

        public Tbl_NatureArea GetAreaByID(int ID)
        {
            return DataAccess.GetInstance.db.GetAreaByID(ID);
        }

        public Tbl_NatureAreaFoto GetAreaFotoByID(int AreaID)
        {
            return DataAccess.GetInstance.db.GetAreaFotoByID(AreaID);
        }
    }
}
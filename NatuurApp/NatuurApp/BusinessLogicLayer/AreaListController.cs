using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using NatuurApp.DataAccessLayer;
using System.Windows.Controls;
namespace NatuurApp.BusinessLogicLayer
{
    class AreaListController
    {
        public AreaListController()
        {

        }

        public List<Tbl_NatureArea> GetAreaList()
        {
            return DataAccess.GetInstance.db.GetAreaList();
        }

        public Tbl_NatureAreaFoto GetAreaFotoByID(int AreaID)
        {
            return DataAccess.GetInstance.db.GetAreaFotoByID(AreaID);
        }
    }
}

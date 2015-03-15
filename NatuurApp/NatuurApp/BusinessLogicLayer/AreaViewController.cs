using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data;


namespace NatuurApp.BusinessLogicLayer
{
    class AreaViewController
    {
        public AreaViewController()
        {
        }

        public AreaViewObject GetAreaObjectByAreaID(string ID)
        {
            AreaViewObject AVO = new AreaViewObject();
            string Query = "select * from tbl_NatureArea where AreaID='" + ID + "'";
            DataTable tmp = DataAccessLayer.GetInstance.db.GetDataTable(Query);
            return AVO;
        }
    }
}
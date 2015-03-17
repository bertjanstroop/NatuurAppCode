using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.IO.IsolatedStorage;
namespace NatuurApp.DataAccessLayer
{
    class EmbededDB
    {
        IsolatedStorageFile ISF = IsolatedStorageFile.GetUserStoreForApplication();
        private const string ConnectionString = "isostore:/Database.sdf";
        public EmbededDB()
        {
            //Init();
            //BuildDataBase();
        }

        private void Init()
        {
            if (!ISF.FileExists("isostore:/Database.sdf"))
            {
                ISF.CreateFile("isostore:/Database.sdf");
                BuildDataBase();
            }
        }

        private void BuildDataBase()
        {
            using (var context = new tbl_NatureAreaDataContext(ConnectionString))
            {
                if (!context.DatabaseExists())
                    context.CreateDatabase();
            }
            using (var context = new tbl_NatureAreaFotoDataContext(ConnectionString))
            {
                if (!context.DatabaseExists())
                    context.CreateDatabase();
            }
            TestInsertNatureArea();
        }

        public tbl_NatureArea GetAreaByID(int ID)
        {
            tbl_NatureArea result = new tbl_NatureArea();
            using (var context = new tbl_NatureAreaDataContext(ConnectionString))
            {
                var tmp = (from s in context.tbl_NatureArea
                          where s.AreaID == ID
                          select s).First();
                result = tmp;
            }
            return result;
        }

        public List<tbl_NatureArea> GetAreaList()
        {
            List<tbl_NatureArea> result = new List<tbl_NatureArea>();
            using (var context = new tbl_NatureAreaDataContext(ConnectionString))
            {
                var tmp = from s in context.tbl_NatureArea
                         select new tbl_NatureArea();
                result = tmp.ToList();
            }
            
            return result;
        }

        private void TestInsertNatureArea()
        {
            tbl_NatureArea t = new tbl_NatureArea();
            t.AreaID = 1;
            t.AreaName = "De Put";
            t.BriefDescription = "Zand Winnings Plaats";
            t.ExtendedDescription = "De put is een natuurgebied dat tot stand is gekomen door de benodigheid van zand in de omgeving";
            t.Latitude = "34";
            t.Longitude = "56";
            t.Location = "Wagenberg";
            t.BestSeason = "Heel het jaar";
            using(var context = new tbl_NatureAreaDataContext(ConnectionString))
            {
                context.tbl_NatureArea.InsertOnSubmit(t);
                context.SubmitChanges();
            }
        }
    }
}

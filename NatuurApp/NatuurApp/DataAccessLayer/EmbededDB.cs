//#define DeleteDB
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.IO.IsolatedStorage;
using System.IO;
using System.Reflection;
using NatuurApp.NatuurApp.DataAccessLayer;
using System.Windows.Controls;
using System.Data.Linq;
using System.Windows.Media.Imaging;
namespace NatuurApp.DataAccessLayer.db
{
   public class EmbededDB
    {
        IsolatedStorageFile ISF = IsolatedStorageFile.GetUserStoreForApplication();
        private const string ConnectionString = "isostore:/Database.sdf";
        public EmbededDB()
        {
            Init();
        }

        private void Init()
        {
            using (var context = new tbl_NatureAreaDataContext(ConnectionString))
            {
                if (!context.DatabaseExists())
                {
                    context.CreateDatabase();
                    TestInsertNatureArea();
                }
#if DeleteDB
                context.DeleteDatabase();
#endif
            }
            using (var context = new tbl_NatureAreaFotoDataContext(ConnectionString))
            {
                if (!context.DatabaseExists())
                {
                    context.CreateDatabase();
                    TestInsertNatureAreaFoto();
                }
#if DeleteDB
                context.DeleteDatabase();
#endif
            }
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
                         select s;
                result = tmp.ToList();
            }
            
            return result;
        }

        public tbl_NatureAreaFoto GetAreaFotoByID(int AreaID)
        {
            tbl_NatureAreaFoto result = new tbl_NatureAreaFoto();
            using (var context = new tbl_NatureAreaFotoDataContext(ConnectionString))
            {
                var tmp = (from s in context.tbl_NatureAreaFoto
                          where s.AreaID == AreaID
                          select s).First();
                result = tmp;
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

        private void TestInsertNatureAreaFoto()
        {
            tbl_NatureAreaFoto t = new tbl_NatureAreaFoto();
            t.AreaID = 1;

            var assembly1 = Assembly.GetExecutingAssembly();
            var DePut1 = "NatuurApp.DePut1.jpeg";
            using (Stream stream = assembly1.GetManifestResourceStream(DePut1))
            {
                long size = stream.Length;
                byte[] buffer = new byte[size];
                stream.Read(buffer, 0, buffer.Count());
                t.Image1 = buffer;
            }

            var assembly2 = Assembly.GetExecutingAssembly();
            var DePut2 = "NatuurApp.DePut2.jpeg";
            using (Stream stream = assembly2.GetManifestResourceStream(DePut2))
            {
                long size = stream.Length;
                byte[] buffer = new byte[size];
                stream.Read(buffer, 0, buffer.Count());
                t.Image2 = buffer;
            }

            var assembly3 = Assembly.GetExecutingAssembly();
            var DePut3 = "NatuurApp.DePut3.jpeg";
            using (Stream stream = assembly3.GetManifestResourceStream(DePut3))
            {
                long size = stream.Length;
                byte[] buffer = new byte[size];
                stream.Read(buffer, 0, buffer.Count());
                t.Image3 = buffer;
            }

            var assembly4 = Assembly.GetExecutingAssembly();
            var DePut4 = "NatuurApp.DePut4.jpeg";
            using (Stream stream = assembly4.GetManifestResourceStream(DePut4))
            {
                long size = stream.Length;
                byte[] buffer = new byte[size];
                stream.Read(buffer, 0, buffer.Count());
                t.Image4 = buffer;
            }
            using (var context = new tbl_NatureAreaFotoDataContext(ConnectionString))
            {
                context.tbl_NatureAreaFoto.InsertOnSubmit(t);
                context.SubmitChanges();
            }
        }
    }
}

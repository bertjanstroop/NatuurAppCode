#define DeleteDB
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
using System.Windows;

namespace NatuurApp.DataAccessLayer.db
{
   public class EmbededDB
    {
        IsolatedStorageFile ISF = IsolatedStorageFile.GetUserStoreForApplication();
        private const string ConnectionString = "isostore:/DataBase.sdf";
        public EmbededDB()
        {
            Init();
        }

        private void Init()
        {
#if DeleteDB
            ISF.DeleteFile("DataBase.sdf");
#endif
            if (!ISF.FileExists("DataBase.sdf"))
            {
                var Database = @"Resources/DataBase.sdf";
                using (Stream stream = Application.GetResourceStream(new Uri(Database, UriKind.Relative)).Stream)
                {
                    using (IsolatedStorageFileStream fileStream = ISF.OpenFile("DataBase.sdf", FileMode.Create))
                    {
                        stream.CopyTo(fileStream);
                    } 
                }
                //TestInsertNatureArea();
                //TestInsertNatureAreaFoto();
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
            try
            {
                
                using (var context = new tbl_NatureAreaFotoDataContext(ConnectionString))
                {
                    var tmp = (from s in context.tbl_NatureAreaFoto
                               where s.AreaID == AreaID
                               select s).First();
                    result = tmp;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
                throw;
            }
            return result;
        }

        private void TestInsertNatureArea()
        {
            try
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
                using (var context = new tbl_NatureAreaDataContext(ConnectionString))
                {
                    context.tbl_NatureArea.InsertOnSubmit(t);
                    context.SubmitChanges();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
                throw;
            }
        }

        public void InsertArea(string Name, string Description, string Location)
        {
            tbl_NatureArea t = new tbl_NatureArea();
            t.AreaName = Name;
            t.BriefDescription = Description;
            t.Location = Location;
            using (var context = new tbl_NatureAreaDataContext(ConnectionString))
            {
                context.tbl_NatureArea.InsertOnSubmit(t);
                context.SubmitChanges();
            }
        }

        private void TestInsertNatureAreaFoto()
        {
            try
            {
                tbl_NatureAreaFoto t = new tbl_NatureAreaFoto();
                t.AreaID = 1;

                var DePut1 = @"Resources/DePut1.jpg";
                using (Stream stream = Application.GetResourceStream(new Uri(DePut1, UriKind.Relative)).Stream)
                {
                    long size = stream.Length;
                    byte[] buffer = new byte[size];
                    stream.Read(buffer, 0, buffer.Count());
                    t.Image1 = buffer;
                }

                var DePut2 = @"Resources/DePut2.jpg";
                using (Stream stream = Application.GetResourceStream(new Uri(DePut2, UriKind.Relative)).Stream)
                {
                    long size = stream.Length;
                    byte[] buffer = new byte[size];
                    stream.Read(buffer, 0, buffer.Count());
                    t.Image2 = buffer;
                }


                var DePut3 = @"Resources/DePut3.jpg";
                using (Stream stream = Application.GetResourceStream(new Uri(DePut3, UriKind.Relative)).Stream)
                {
                    long size = stream.Length;
                    byte[] buffer = new byte[size];
                    stream.Read(buffer, 0, buffer.Count());
                    t.Image3 = buffer;
                }

                var DePut4 = @"Resources/DePut4.jpg";
                using (Stream stream = Application.GetResourceStream(new Uri(DePut4, UriKind.Relative)).Stream)
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
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
                throw;
            }
        }
    }
}

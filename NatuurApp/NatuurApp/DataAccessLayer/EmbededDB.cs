//#define DeleteDB
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Globalization;
using System.Linq;
using System.Text;
using System.IO.IsolatedStorage;
using System.IO;
using System.Reflection;
using NatuurApp.DataAccessLayer;
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
            }
        }

        public Tbl_NatureArea GetAreaByID(int ID)
        {
            Tbl_NatureArea result = new Tbl_NatureArea();
            using (var context = new databaseContext(ConnectionString))
            {
                var tmp = (from s in context.Tbl_NatureArea
                           where s.AreaID == ID
                           select s).First();
                result = tmp;
            }
            return result;
        }

        public List<Tbl_NatureArea> GetAreaList()
        {
            List<Tbl_NatureArea> result = new List<Tbl_NatureArea>();
            
            using (var context = new databaseContext(ConnectionString))
            {
                var tmp = from s in context.Tbl_NatureArea
                          select s;
                result = tmp.ToList();
            }
            return result;
        }

        public Tbl_NatureAreaFoto GetAreaFotoByID(int AreaID)
        {
            Tbl_NatureAreaFoto result = new Tbl_NatureAreaFoto();
            using (var context = new databaseContext(ConnectionString))
            {
                var tmp = (from s in context.Tbl_NatureAreaFoto
                           where s.AreaID == AreaID
                           select s).First();
                result = tmp;
            }
            return result;
        }

        public void InsertArea(Tbl_NatureArea area, Tbl_NatureAreaFoto foto )
        {
            using (var context = new databaseContext(ConnectionString))
            {
                context.Tbl_NatureArea.InsertOnSubmit(area);
                context.SubmitChanges();
                context.Tbl_NatureAreaFoto.InsertOnSubmit(foto);
                context.SubmitChanges();
            }
        }

        public void UpdateArea(Tbl_NatureArea area, Tbl_NatureAreaFoto foto)
        {
            using (var Context = new databaseContext(ConnectionString))
            {
                try
                {
                    var ar = (from s in Context.Tbl_NatureArea where s.AreaID == area.AreaID select s).First();
                    //set new area data
                    ar.AreaName = area.AreaName;
                    ar.BriefDesciption = area.BriefDesciption;
                    ar.ExtendedDescription = area.ExtendedDescription;
                    ar.Latitude = area.Latitude;
                    ar.Longitude = area.Longitude;
                    ar.BestSeason = area.BestSeason;

                    var fo = (from s in Context.Tbl_NatureAreaFoto where s.AreaID == foto.AreaID select s).First();
                    //set new foto data
                    fo.Image1 = foto.Image1;
                    fo.Image2 = foto.Image2;
                    fo.Image3 = foto.Image3;
                    fo.Image4 = foto.Image4;

                    Context.SubmitChanges();
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.ToString());
                    throw;
                }
            }
        }
    }
}

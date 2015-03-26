﻿//#define DeleteDB
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
            using (var context = new Context(ConnectionString))
            {
                //var tmp = (from s in context.Tbl_NatureArea
                //          where s.AreaID == ID
                //          select s).First();
                //result = tmp;
                result = CompiledLinq.GetAreaByID(context, ID).First();
            }
            return result;
        }

        public List<Tbl_NatureArea> GetAreaList()
        {
            List<Tbl_NatureArea> result = new List<Tbl_NatureArea>();
            
            using (var context = new Context(ConnectionString))
            {
                //var tmp = from s in context.Tbl_NatureArea
                //          select s;
                //result = tmp.ToList();
                result = CompiledLinq.GetAreaList(context).ToList();
            }
            return result;
        }

        public Tbl_NatureAreaFoto GetAreaFotoByID(int AreaID)
        {
            Tbl_NatureAreaFoto result = new Tbl_NatureAreaFoto();
            using (var context = new Context(ConnectionString))
            {
                //var tmp = (from s in context.Tbl_NatureAreaFoto
                //            where s.AreaID == AreaID
                //            select s).First();
                //result = tmp;
                result = CompiledLinq.GetAreaFotoByID(context, AreaID).First();
            }
            return result;
        }

        public void InsertArea(Tbl_NatureArea area, Tbl_NatureAreaFoto foto )
        {
            

            using (var context = new Context(ConnectionString))
            {
                context.Tbl_NatureArea.InsertOnSubmit(area);
                context.SubmitChanges();
                context.Tbl_NatureAreaFoto.InsertOnSubmit(foto);
                context.SubmitChanges();
            }
        }

        public bool InsertNewArea(Tbl_NatureArea area, Tbl_NatureAreaFoto foto)
        {
            bool result = false;
            try
            {
                using (var context = new Context(ConnectionString))
                {
                    context.Tbl_NatureArea.InsertOnSubmit(area);
                    context.Tbl_NatureAreaFoto.InsertOnSubmit(foto);
                    context.SubmitChanges();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }
            return result;
        }

        public bool UpdateArea(Tbl_NatureArea area, Tbl_NatureAreaFoto foto)
        {
            bool result = false;
            //give foto the same AreaID
            foto.AreaID = area.AreaID;
            using (var context = new Context(ConnectionString))
            {
                var tmp = (from s in context.Tbl_NatureArea
                           where s.AreaID == area.AreaID
                           select s).First();
                //insert changes inside area to tmp
                tmp = area;
                //try to submit changes inside tmp
                try
                {
                    context.SubmitChanges();
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.ToString());
                }
            }
            using (var context = new Context(ConnectionString))
            {
                var tmp = (from s in context.Tbl_NatureAreaFoto
                           where s.AreaID == foto.AreaID
                           select s).First();
                //insert changes inside foto to tmp
                tmp = foto;
                //try to submit changes inside tmp
                try
                {
                    context.SubmitChanges();
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.ToString());
                }
            }
            return result;
        }
    }
}

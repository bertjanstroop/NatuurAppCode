using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using NatuurApp.DataAccessLayer.db;
namespace NatuurApp.DataAccessLayer
{
   public sealed class DataAccess
   {
       private static readonly DataAccess instance = new DataAccess();
       internal EmbededDB db;
       private DataAccess() { db = new EmbededDB(); }

       public static DataAccess GetInstance
       {
           get
           {
               return instance;
           }
       }
   }
}

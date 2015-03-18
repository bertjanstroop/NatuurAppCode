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
       internal EmbededDB db = new EmbededDB();
       private DataAccess() {}

       public static DataAccess GetInstance
       {
           get
           {
               return instance;
           }
       }
   }
}

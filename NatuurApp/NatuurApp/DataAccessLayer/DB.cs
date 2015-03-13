using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data;
using System.Data.Linq;
using System.Data.Linq.Provider;

namespace NatuurApp.DataAccessLayer
{
    public class DB
    {
        public DB() { }
        // Create the data context.
        private Service1Client API = new Service1Client();
        public string GetStringResult(string Query)
        {
            string result = string.Empty;
            result = API.GetStringResult(Query);
            return result;
        }

        public bool TestConnection()
        {
           return API.TestDBConnection();
        }
    }
}

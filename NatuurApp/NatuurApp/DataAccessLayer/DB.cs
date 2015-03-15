using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data;
using System.Data.Linq;
using System.Data.Linq.Provider;
using NatuurApp.ServiceReference1;
using System.Collections;
using Telerik.Data;
namespace NatuurApp
{
    public class DB
    {
        private Service1Client API = new Service1Client();
        public DB() { }
        // Create the data context.

        public IEnumerable GetDataTableResult(string Query)
        {
            IEnumerable result = null;
            API.GetDataTableCompleted += new EventHandler<GetDataTableCompletedEventArgs>(GetDataTableCompleted);
            GetDataTableRequest r = new GetDataTableRequest();
            r.Query = Query;
            API.GetDataTableAsync(r);
            return result;
        }

        static void GetDataTableCompleted(object sender, GetDataTableCompletedEventArgs e)
        {
            Values.DataTableResult = e.Result.GetDataTableResult;
        }
        
        public string GetStringResult(string Query)
        {
            string result = string.Empty;
            API.GetStringResultCompleted += new EventHandler<GetStringResultCompletedEventArgs>(GetStringResultCompleted);
            GetStringResultRequest r = new GetStringResultRequest();
            r.Query = Query;
            API.GetStringResultAsync(r);
            result = Values.StringResult;
            return result;
        }

        static void GetStringResultCompleted(object sender, GetStringResultCompletedEventArgs e)
        {
            Values.StringResult = e.Result.GetStringResultResult;
        }

        public bool TestConnection()
        {
            bool result = true;
            API.TestDBConnectionCompleted += new EventHandler<TestDBConnectionCompletedEventArgs>(testConnectionCompleted);
            API.TestDBConnectionAsync(new TestDBConnectionRequest());
            return result;
        }

        static void testConnectionCompleted(object sender, TestDBConnectionCompletedEventArgs e)
        {
            Values.TestConnection = e.Result.TestDBConnectionResult;
        }
    }

    public static class Values
    {
        public static bool TestConnection { get; set; }
        public static string StringResult { get; set; }
        public static DataTable DataTableResult { get; set; }
    }
}

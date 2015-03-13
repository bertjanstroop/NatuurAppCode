using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.ServiceModel.Web;
using System.Text;
using System.Data;
using System.Data.SqlClient;
namespace WcfService1
{
    // NOTE: You can use the "Rename" command on the "Refactor" menu to change the class name "Service1" in code, svc and config file together.
    // NOTE: In order to launch WCF Test Client for testing this service, please select Service1.svc or Service1.svc.cs at the Solution Explorer and start debugging.
    public class Service1 : IService1
    {
        private static string ConnectionString = @"Server=.\SQLExpress;AttachDbFilename=|DataDirectory|App_Data\mydbfile.mdf;Database=Database;Trusted_Connection=Yes;";
        private SqlConnection cs = new SqlConnection(ConnectionString);
        private SqlDataAdapter da;
        private SqlCommand cmd;
        public string GetData(int value)
        {
            return string.Format("You entered: {0}", value);
        }

        public CompositeType GetDataUsingDataContract(CompositeType composite)
        {
            if (composite == null)
            {
                throw new ArgumentNullException("composite");
            }
            if (composite.BoolValue)
            {
                composite.StringValue += "Suffix";
            }
            return composite;
        }


        public string GetStringResult(string Query)
        {
            throw new NotImplementedException();
        }

        public System.Collections.IEnumerable GetResult(string Query)
        {
            throw new NotImplementedException();
        }

        public void ExecuteCommand(string Query)
        {
            throw new NotImplementedException();
        }


        public bool TestDBConnection()
        {
            try
            {
                cs.Open();
                cs.Close();
                return true;
            }
            catch (SqlException ex)
            {
                return false;
            }
        }
    }
}

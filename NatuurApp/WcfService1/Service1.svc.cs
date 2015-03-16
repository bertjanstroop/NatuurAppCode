using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.ServiceModel.Web;
using System.Text;
using System.Data;
using System.Data.SqlClient;
using System.Collections;
namespace WcfService1
{
    // NOTE: You can use the "Rename" command on the "Refactor" menu to change the class name "Service1" in code, svc and config file together.
    // NOTE: In order to launch WCF Test Client for testing this service, please select Service1.svc or Service1.svc.cs at the Solution Explorer and start debugging.
    public class Service1 : IService1
    {
        private static string ConnectionString = @"Server=BERTJAN-LAPTOP\SQLEXPRESS;Database=Database;Trusted_Connection=Yes;";
        private SqlConnection cs = new SqlConnection(ConnectionString);
        private SqlDataAdapter da;
        private SqlCommand cmd;

        public string GetStringResult(string Query)
        {
            string result = string.Empty;

            try
            {
                cs.Open();
                cmd.CommandText = Query;
                result = cmd.ExecuteScalar().ToString();
            }
            catch (SqlException)
            {
                result = "";
            }
            return result;
        }

        public void ExecuteCommand(string Query)
        {
            cs.Open();
            cmd.CommandText = Query;
            cmd.ExecuteNonQuery();
        }


        public bool TestDBConnection()
        {
            try
            {
                cs.Open();
                cs.Close();
                return true;
            }
            catch (SqlException)
            {
                return false;
            }
        }


        public DataClass.NatureArea GetNatureAreaByID(string AreaID)
        {
            throw new NotImplementedException();
        }

        public List<DataClass.NatureArea> GetNatureAreas()
        {
            throw new NotImplementedException();
        }

        public DataClass.NatureAreaFoto GetNatureAreaFotoByID(string AreaID)
        {
            throw new NotImplementedException();
        }
    }
}

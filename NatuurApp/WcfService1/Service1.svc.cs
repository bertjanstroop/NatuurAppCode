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
            string Query = "select AreaID,AreaName,BriefDescription,ExtendedDescription,Latitude,Longitide,Location,BestSeason from tbl_NatureArea where AreaID='" + AreaID + "'";
            DataTable table = new DataTable();
            da = new SqlDataAdapter(Query, cs);
            cs.Open();
            da.Fill(table);
            cs.Close();
            return ConvertToNatureArea(table);
        }

        private static DataClass.NatureArea ConvertToNatureArea(DataTable table)
        {
            DataClass.NatureArea NA = new DataClass.NatureArea();
            foreach (DataRow row in table.Rows)
            {
                NA.AreaID = int.Parse( row["AreaID"].ToString());
                NA.AreaName = row["AreaName"].ToString();
                NA.BriefDescription = row["BriefDescription"].ToString();
                NA.ExtendedDescription = row["ExtendedDescription"].ToString();
                NA.Latitude = row["Latitude"].ToString();
                NA.Longitude = row["Longitude"].ToString();
                NA.Location = row["Location"].ToString();
                NA.BestSeason = row["BestSeason"].ToString();
            }
            return NA;
        }

        public List<DataClass.NatureArea> GetNatureAreas()
        {
            string Query = "select AreaID,AreaName,BriefDescription,ExtendedDescription,Latitude,Longitide,Location,BestSeason from tbl_NatureArea";
            DataTable table = new DataTable();
            da = new SqlDataAdapter(Query, cs);
            cs.Open();
            da.Fill(table);
            cs.Close();
            return ConvertToNatureAreaList(table);
        }

        private List<DataClass.NatureArea> ConvertToNatureAreaList(DataTable table)
        {
            List<DataClass.NatureArea> result = new List<DataClass.NatureArea>();
            foreach (DataRow row in table.Rows)
            {
                DataClass.NatureArea NA = new DataClass.NatureArea();
                NA.AreaID = int.Parse(row["AreaID"].ToString());
                NA.AreaName = row["AreaName"].ToString();
                NA.BriefDescription = row["BriefDescription"].ToString();
                NA.ExtendedDescription = row["ExtendedDescription"].ToString();
                NA.Latitude = row["Latitude"].ToString();
                NA.Longitude = row["Longitude"].ToString();
                NA.Location = row["Location"].ToString();
                NA.BestSeason = row["BestSeason"].ToString();
                result.Add(NA);
            }
            return result;
        }

        public DataClass.NatureAreaFoto GetNatureAreaFotoByID(string AreaID)
        {
            DataTable table = new DataTable();
            string Query = "select AreaID,Image1,Image2,Image3,Image4 from tbl_NatureAreaFoto where AreaID='" + AreaID + "'";
            da = new SqlDataAdapter(Query, cs);
            cs.Open();
            da.Fill(table);
            cs.Close();
            return ConvertToNatureAreaFoto(table);
        }

        private static DataClass.NatureAreaFoto ConvertToNatureAreaFoto(DataTable table)
        {
            DataClass.NatureAreaFoto NAF = new DataClass.NatureAreaFoto();
            foreach (DataRow row in table.Rows)
            {
                NAF.AreaID = int.Parse(row["AreaID"].ToString());
                NAF.Image1 = row["Image1"];
                NAF.Image2 = row["Image2"];
                NAF.Image3 = row["Image3"];
                NAF.Image4 = row["Iamge4"];
            }
            return NAF;
        }
    }
}

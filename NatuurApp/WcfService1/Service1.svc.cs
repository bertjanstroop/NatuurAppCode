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
using PhoneDataTable;
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


        public PhoneDataTable.DataTable GetDataTable(string Query)
        {
            System.Data.DataTable tmp = new System.Data.DataTable();
            PhoneDataTable.DataTable result = new PhoneDataTable.DataTable();
            da = new SqlDataAdapter(Query, cs);
            cs.Open();
            da.Fill(tmp);
            cs.Close();
            //convert here
            result = ConverDataTableType(tmp);
            return result;
        }

        private static PhoneDataTable.DataTable ConverDataTableType(System.Data.DataTable table)
        {
            PhoneDataTable.DataTable result = new PhoneDataTable.DataTable();
            foreach (System.Data.DataColumn column in table.Columns)
            {
                result.Columns.Add(new PhoneDataTable.DataColumn() {ColumnName=column.ColumnName,DataType=column.DataType });
            }
            int count = 0;
            foreach (System.Data.DataRow row in table.Rows)
            {
                PhoneDataTable.DataRow r = new PhoneDataTable.DataRow();
                r.Add(table.Columns[count].ColumnName,table.Rows[0][count]);
                result.Rows.Add(r);
                count++;
            }
            return result;
        }
    }
}

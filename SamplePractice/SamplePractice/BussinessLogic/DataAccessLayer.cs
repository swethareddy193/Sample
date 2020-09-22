using SamplePractice.Models;
using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Web;

namespace SamplePractice.BussinessLogic
{
    public class DataAccessLayer
    {
        public bool SaveData(PersonDetails da)
        {
            string strcon = ConfigurationManager.ConnectionStrings["ConnectonString"].ConnectionString;
            var connection = new SqlConnection(strcon);
            var cmd = new SqlCommand("sp_insertdetails", connection);
            cmd.CommandType = System.Data.CommandType.StoredProcedure;
            cmd.Parameters.AddWithValue("@name", da.name);
            cmd.Parameters.AddWithValue("@email", da.email);
            cmd.Parameters.AddWithValue("@password", da.password);
            connection.Open();
            var  result=cmd.ExecuteNonQuery() > 0;
            return result;
        }
    }
}
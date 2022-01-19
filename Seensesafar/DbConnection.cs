using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;
using System.Configuration;

namespace Seensesafar
{
    public class DbConnection
    {

        SqlConnection con = new SqlConnection();
        SqlCommand cmd = new SqlCommand();
        SqlDataReader reader;

        public string ConnectionString()
        {
            string con = ConfigurationManager.ConnectionStrings["Seensesafar.Properties.Settings.SeensesafarCS"].ConnectionString;
            return con;

        }

        public string GetPassword(string user)
        {
            string password = "";
            con.ConnectionString = ConnectionString();
            con.Open();
            string query = "Select * from tbl_Users where name = @name ";
            cmd = new SqlCommand(query, con);
            cmd.Parameters.AddWithValue("@name", user);
            reader = cmd.ExecuteReader();
            reader.Read();
            if (reader.HasRows)
            {
                password = reader["password"].ToString();
            }
            reader.Close();
            con.Close();
            return password;
        }


    }
}

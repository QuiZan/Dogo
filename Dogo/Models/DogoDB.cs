using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;
using Dogo.Models;

namespace Dogo.Models
{
    public class DogoDB
    {
        SqlConnection con = new SqlConnection("Server = DESKTOP-F0O9FMG//SQLEXPRESS; Database=Dogo;User Id = Admin; Password=admin;");
    
        public string Saverecord(DogModel dog)
        {
            try
            {
                SqlCommand com = new SqlCommand("AddDog", con);
                com.CommandType = CommandType.StoredProcedure;
                com.Parameters.AddWithValue("@DogID", dog.DogID);
                com.Parameters.AddWithValue("@Name", dog.Name);
                com.Parameters.AddWithValue("@Weight", dog.Weight);
                com.Parameters.AddWithValue("@Color", dog.Color);
                com.Parameters.AddWithValue("@BdDate", dog.BdDate);
                com.Parameters.AddWithValue("@Race", dog.Race);
                con.Open();
                com.ExecuteNonQuery();
                con.Close();
                return ("OK");
            }
            catch(Exception ex)
            {
                if (con.State==ConnectionState.Open)
                {
                    con.Close();
                }
                return (ex.Message.ToString());
            }
           
        }
    }
}

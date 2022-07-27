using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Data;


namespace SQLConncetionADO
{
   public class RetriveDataFromDatabasecs
    {
        public void RetriveData()
        {
            string cs = "Data Source=DESKTOP-C3BQOGP\\SQLEXPRESS;Initial Catalog=SQLConnction;Integrated Security = true;";
            SqlConnection con = new SqlConnection(cs);
            string query = "select * from PayRoll";
            SqlCommand cmd = new SqlCommand(query, con);
            con.Open();
            Console.WriteLine("EmpID FirstName LastName JoiningDate Department phoneNo EmailID Address ");
            SqlDataReader reader = cmd.ExecuteReader();

            try { 
            if (reader.HasRows)
            {
                while(reader.Read())
                {
                        Console.WriteLine((reader["EmpID"], reader["FirstName"], 
                            reader["LastName"], reader["JoiningDate"], reader["Department"], 
                            reader["phoneNo"], reader["EmailID"], reader["Address"], reader["State"], 
                            reader["City"], reader["Gender"], reader["BasicPay"], reader["Salary"]));

                    }
            }
            }
            catch(Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
            finally
            {
                Console.WriteLine("Check once again and run it");
            }
            con.Close();
        }
    }
}

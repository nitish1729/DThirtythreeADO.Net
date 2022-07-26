using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;
namespace SQLConncetionADO
{
    public class SqlconnectionCheck
    {
        

        public void Conncetion1()
        {
            string cs = "Data Source=DESKTOP-C3BQOGP\\SQLEXPRESS;Initial Catalog=SQLConnction;Integrated Security = true;";
            SqlConnection con = new SqlConnection(cs);
            string query = string.Format("INSERT INTO PayRoll VALUES(32,'Satish','Mehta','2021-12-31','Busniness Analyst','9852267616','awsthi369@gmail.com','BTM Layout 5st stage','Karanataka','bangalore','M',15000,22000);");
            SqlCommand cmd = new SqlCommand(query, con);
            con.Open();
           int n = cmd.ExecuteNonQuery();
            Console.WriteLine("{0} row inserted successfully!",n);
            Console.ReadLine();
            con.Close();
            
        }

    }
}

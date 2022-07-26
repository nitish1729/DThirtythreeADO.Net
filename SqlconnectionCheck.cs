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
            con.Open();
            Console.WriteLine("open");
            Console.ReadLine();
            con.Close();
            
        }

    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient; // SqlConnection class is present under this namespace
using System.Data;

namespace SQLConncetionADO
{
    public class SQLConncetion
    {
        public void Conncetion()
        {
            string cs = "Data Source=DESKTOP-C3BQOGP\\SQLEXPRESS;Initial Catalog=SQLConnction;Integrated Security = true;";
            SqlConnection con = new SqlConnection(cs);
            con.Open();
            if (con.State == ConnectionState)
            {
                //if (con.State == ConnectionState.Open)
                // {
                Console.WriteLine("SConnection hasn't beem successfull:");
                Console.WriteLine("SqlConnection Information:");
                Console.WriteLine("  Connection State = " + con.State);
                Console.WriteLine("  Connection String = " + con.ConnectionString);
                Console.WriteLine("  Database Source = " + con.DataSource);
                Console.WriteLine("  Database = " + con.Database);
                Console.WriteLine("  Server Version = " + con.ServerVersion);
                Console.WriteLine("  Workstation Id = " + con.WorkstationId);
                Console.WriteLine("  Timeout = " + con.ConnectionTimeout);
                Console.WriteLine("  Packet Size = " + con.PacketSize);
            }   //}  
                else
                {
                    Console.WriteLine("SqlConnection failed to open.");
                    Console.WriteLine("  Connection State = " + con.State);
                }
           
               con.Close();
        }
    }
}

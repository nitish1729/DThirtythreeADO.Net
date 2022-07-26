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
            // using is useed for automatically close the connection
            using(SqlConnection con = new SqlConnection(cs))

            {
                con.Open();
                if (con.State == ConnectionState.Open)
                {
                    Console.WriteLine("SQL Connection has beem successfull:");
                    Console.WriteLine("''''''''''''''''''''''''''''''''''''");
                    Console.WriteLine("SqlConnection Information:");
                    Console.WriteLine("  Connection State = " + con.State);
                    Console.WriteLine("  Connection String = " + con.ConnectionString);
                    Console.WriteLine("  Database Source = " + con.DataSource);
                    Console.WriteLine("  Database = " + con.Database);
                    Console.WriteLine("  Server Version = " + con.ServerVersion);
                    Console.WriteLine("  Workstation Id = " + con.WorkstationId);
                    Console.WriteLine("  Timeout = " + con.ConnectionTimeout);
                    Console.WriteLine("  Packet Size = " + con.PacketSize);
                    Console.ReadLine();
                }
                else
                {
                    Console.WriteLine("SqlConnection failed to open.");
                    Console.WriteLine("  Connection State = " + con.State);

                }
            }

            //try
            //{

                //    if (con.State == ConnectionState.Open)
                //    {
                //        Console.WriteLine("SQL Connection has beem successfull:");
                //        Console.WriteLine("''''''''''''''''''''''''''''''''''''");
                //        Console.WriteLine("SqlConnection Information:");
                //        Console.WriteLine("  Connection State = " + con.State);
                //        Console.WriteLine("  Connection String = " + con.ConnectionString);
                //        Console.WriteLine("  Database Source = " + con.DataSource);
                //        Console.WriteLine("  Database = " + con.Database);
                //        Console.WriteLine("  Server Version = " + con.ServerVersion);
                //        Console.WriteLine("  Workstation Id = " + con.WorkstationId);
                //        Console.WriteLine("  Timeout = " + con.ConnectionTimeout);
                //        Console.WriteLine("  Packet Size = " + con.PacketSize);
                //        Console.ReadLine();
                //    }
                //else
                //{
                //  Console.WriteLine("SqlConnection failed to open.");
                //  Console.WriteLine("  Connection State = " + con.State);

                //}
            //}
            //   catch(SqlException ex)
            //   {
            //     Console.WriteLine(ex.Message);
            //   }
            //  finally
            //  {
            //    con.Close();
            //  }


        }        
    }
}

//using System;
//using System.Collections.Generic;
//using System.Linq;
//using System.Text;
//using System.Threading.Tasks;
//using System.Data.SqlClient; // SqlConnection class is present under this namespace
//using System.Data;

//namespace SQLConncetionADO
//{
//    public class SQLConncetion
//    {

//        public void Conncetion()
//        {
//            string cs = "Data Source=DESKTOP-C3BQOGP\\SQLEXPRESS;Initial Catalog=SQLConnction;Integrated Security = true;";

//            SqlConnection con = new SqlConnection(cs);
//            try
//            {
//                con.Open();
//                if (con.State == ConnectionState.Open)
//                {
//                    Console.WriteLine("SQL Connection has beem successfull:");
//                    Console.ReadLine();
//                }
//            }
//            catch (SqlException ex)
//            {
//                Console.WriteLine(ex.Message);
//            }
//            finally
//            {
//                con.Close();
//            }
//        }
//    }
//}








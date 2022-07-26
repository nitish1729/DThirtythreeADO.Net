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
            Console.WriteLine("Enter Your Employee ID ");
            int EmpID = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Enter Your FirstName ");
            String FirstName = Console.ReadLine();

            Console.WriteLine("Enter Your LastName ");
            String LastName = Console.ReadLine();

            //Console.WriteLine("Enter Your JoiningDate ");
            //String JoiningDate = Console.ReadLine(); 

            //Console.WriteLine("Enter Your Department ");
            //String Department = Console.ReadLine();

            //Console.WriteLine("Enter Your phoneNo ");
            //float phoneNo = float.Parse(Console.ReadLine());

            //Console.WriteLine("Enter Your EmailID ");
            //String EmailID = Console.ReadLine();

            //Console.WriteLine("Enter Your Address ");
            //String Address = Console.ReadLine();

            //Console.WriteLine("Enter Your State ");
            //String State = Console.ReadLine();

            //Console.WriteLine("Enter Your City ");
            //String City = Console.ReadLine();

            //Console.WriteLine("Enter Your Gender ");
            //Char Gender = Char.Parse(Console.ReadLine());

            //Console.WriteLine("Enter Your BasicPay ");
            //float BasicPay = float.Parse(Console.ReadLine());

            Console.WriteLine("Enter Your Salary ");
            float Salary = float.Parse(Console.ReadLine());



            string cs = "Data Source=DESKTOP-C3BQOGP\\SQLEXPRESS;Initial Catalog=SQLConnction;Integrated Security = true;";
            SqlConnection con = new SqlConnection(cs);
            string query = string.Format("INSERT INTO PayRoll VALUES ({0},'{1}','{2}','{3}')", EmpID, FirstName, LastName, Salary); 
            SqlCommand cmd = new SqlCommand(query, con);
            con.Open();

           cmd.ExecuteNonQuery();
            //Console.WriteLine("{0} row inserted successfully!",n);
            Console.ReadLine();
            con.Close();
            
        }

    }
}

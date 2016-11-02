using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Test_Connection
{
    class Program
    {
        static void Main(string[] args)
        {
            string conn = @"Data Source=KUSARI-PC\SQLEXPRESS;Initial Catalog=NORTHWND;Integrated Security=True";
            SqlConnection connection = new SqlConnection(conn);
            connection.Open();
            Console.WriteLine("Connection established");
            connection.Close();
        }
    }
}

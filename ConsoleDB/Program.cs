using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Odbc;
using System.Data.OleDb;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleDB
{
    class RazliciteKonekcije
    {
        static void Main(string[] args)
        {

            // Connect using .NET data provider for SQL Server and integrated
            // security
            string sqlConnectString1 = 
                @"Data Source=KUSARI-PC\SQLEXPRESS;Initial Catalog=TSQL2012;Integrated Security=True;";





            using (SqlConnection connection = new SqlConnection(sqlConnectString1))
            {
                connection.Open();

                // Return some information about the server.
                Console.WriteLine("---.NET data provider for SQL Server " +
                    "with Windows Authentication mode---");
                Console.WriteLine("ConnectionString = {0}\n", sqlConnectString1);
                Console.WriteLine("State = {0}", connection.State);
                Console.WriteLine("DataSource = {0}", connection.DataSource);
                Console.WriteLine("ServerVersion = {0}", connection.ServerVersion);
            }




            DataTable dt = new DataTable();




            Console.WriteLine("\nPress any key to continue.");
            Console.ReadKey();
        }
    }

}

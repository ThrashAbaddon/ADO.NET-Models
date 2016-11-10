﻿using System;
using System.Data.SqlClient;

namespace ConsoleDB
{
    class RazliciteKonekcije
    {
        static void Main(string[] args)
        {

            // Connect using .NET data provider for SQL Server and integrated security
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

            Console.WriteLine("\nPress any key to continue.");
            Console.ReadKey();
        }
    }

}

using System;
using System.Data;
using System.Data.Common;
using System.Data.SqlClient;

namespace ConsoleDB
{
    class CreateDataColumnForDataTable
    {
        // Create the connection
        static string sqlConnectString =
            @"Data Source=KUSARI-PC\SQLEXPRESS;Initial Catalog=TSQL2012;Integrated Security=True;";
        static void Main(string[] args)
        {
        }

        static void AddsColumnsToTheTable()
        {
            DataTable dt = new DataTable();

            // Add the column to the DataTable to create
            DataColumn column1 = dt.Columns.Add();

            // Configure the column -- integer with a default = 0 that
            // does not allow nulls
            column1.ColumnName = "customerId";
            column1.DataType = typeof(int);
            column1.DefaultValue = 0;
            column1.Unique = true;
            column1.AllowDBNull = false;


            // Create and configure the column
            DataColumn col2 = new DataColumn();
            // Configure the column -- string with max length = 50
            col2.ColumnName = "ime";
            col2.DataType = typeof(string);
            col2.MaxLength = 50;
            // Add the column to the DataTable
            dt.Columns.Add(col2);

            // Add a column directly using an overload of the Add()
            // method of the DataTable.Columns collection -- the column
            // is a string with max length = 50
            dt.Columns.Add("prezime", typeof(string)).MaxLength = 50;




            // Add multiple existing columns to the DataTable
            DataColumn col4 = new DataColumn("adresa");
            col4.DataType = typeof(string);
            col4.MaxLength = 30;
            col4.AllowDBNull = true;
            // ... configure column 4

            DataColumn col5 = new DataColumn("telBroj", typeof(int));
            // Add columns 4 and 5 to the DataTable
            dt.Columns.AddRange(new DataColumn[] { col4, col5 });

            // Output the columns in the DataTable to the console
            Console.WriteLine($"DataTable ima {dt.Columns.Count} DataColumnsa");
            foreach (DataColumn col in dt.Columns)
                Console.WriteLine($"\t{col.ColumnName}");
            Console.WriteLine("\nPress any key to continue.");
            Console.ReadKey();
        }


        static void AddsTableToDataSet()
        {
            DataSet ds = new DataSet();

            // Add a DataTable named Table-1 directly
            DataTable dt1 = ds.Tables.Add("Tablica-1");
            //Configure the DataTable, you can add some columns, etc.

            // Add a DataTable named Tablica-2 by creating the table
            // and adding it to the DataSet
            DataTable dt2 = new DataTable("Tablica-2");
            DataColumn column1 = dt2.Columns.Add();

            // Configure the column, set integer with a default = 0 that
            // does not allow nulls
            column1.ColumnName = "Id";
            column1.DataType = typeof(int);
            column1.DefaultValue = 0;
            column1.Unique = true;
            column1.AllowDBNull = false;


            // Add multiple empty DataTables to the DataSet
            DataTable dt3 = new DataTable("Tablica-3");
            DataTable dt4 = new DataTable("Tablica-4");
            // Configure the DataTable -- add some columns, etc., if want
            // add a range of tables to dataset, same as adding columns to table
            ds.Tables.AddRange(new DataTable[] { dt3, dt4 });

            // Output the tables in the DataSet to the console.
            Console.WriteLine($"DataSet has {ds.Tables.Count} DataTables named");
            foreach (DataTable dt in ds.Tables)
                Console.WriteLine($"\t{ dt.TableName}");
        }


        static void Method()
        {
            string sqlSelect = @"SELECT TOP 5
                                    title
                                   ,firstname
                                   ,lastname
                                FROM
                                    [HR].[Employees]";
            using (SqlDataAdapter da =
                new SqlDataAdapter(sqlSelect, sqlConnectString))
            {

                // Create the table mapping to map the default table name 'Employees'.
                DataTableMapping dtm =
                    da.TableMappings.Add("[HR].[Employees]", "mappedContact");

                // Create column mappings
                dtm.ColumnMappings.Add("title", "mappedTitle");
                dtm.ColumnMappings.Add("firstname", "mappedFirstName");
                dtm.ColumnMappings.Add("lastname", "mappedLastName");

                // Create and fill the DataSet
                DataSet ds = new DataSet();
                da.Fill(ds);

                Console.WriteLine("DataTable name = {0}",
                    ds.Tables[0].TableName);

                foreach (DataColumn col in ds.Tables["mappedContact"].Columns)
                    Console.WriteLine("\tDataColumn {0} name = {1}",
                        col.Ordinal, col.ColumnName);


                Console.WriteLine();

                foreach (DataRow row in ds.Tables["mappedContact"].Rows)
                    Console.WriteLine(
                        "Title = {0}, FirstName = {1}, LastName = {2}",
                        row["mappedTitle"], row["mappedFirstName"], row["mappedLastName"]);
            }
        }


        static void GetCount()
        {
            string sqlSelect = "SELECT COUNT(*) FROM HR.Employees;";
            SqlConnection connection = new SqlConnection();
            try
            {
                connection.ConnectionString = sqlConnectString;
                // Create the scalar command and open the connection
                SqlCommand command = new SqlCommand(sqlSelect, connection);
                connection.Open();

                // Execute the scalar SQL statement and store results.
                int count = Convert.ToInt32(command.ExecuteScalar());
                Console.WriteLine("Record count in Person.Contact = {0}", count);
            }
            catch (Exception e)
            {
                throw;
            }
            finally
            {
                connection.Close();
            }
        }

        static void GetTableAndOutputFromDataReader()
        {
            string sqlSelect = @"SELECT
                                     empid
                                    ,firstname
                                    ,lastname
                                 FROM
                                     HR.Employees; ";

            using (SqlConnection connection = new SqlConnection(sqlConnectString))
            using (SqlCommand command = new SqlCommand(sqlSelect, connection))
            {
                connection.Open();
                // Create the DataReader to retrieve data
                using (SqlDataReader dr = command.ExecuteReader())
                {
                    while (dr.Read())
                    {
                        // Output fields from DataReader row
                        Console.WriteLine(
                            "empid = {0}\t firstname = {1}\t lastname = {2}",
                            dr["empid"], dr["firstname"], dr["lastname"]);
                    }
                }
            }
        }


        static void AccessDataReaderInDifferentWays()
        {
            string sqlSelect = @"SELECT
                                    e.empid
                                   ,e.lastname
                                   ,e.firstname
                                   ,e.title
                                   ,e.birthdate
                                   ,e.[address]
                                   ,e.hiredate
                                   ,e.city
                                   ,e.region
                                   ,e.country
                                   ,e.postalcode
                                   ,e.phone
                                FROM
                                    HR.Employees e";

            using (SqlConnection connection = new SqlConnection(sqlConnectString))
            using (SqlCommand command = new SqlCommand(sqlSelect, connection))
            {
                connection.Open();

                SqlDataReader dr = command.ExecuteReader();
                dr.Read();
                // Output fields from the first DataRow reader using different techniques
                //for (int i = 0; i < dr.FieldCount; i++)
                //{
                //    Console.WriteLine(dr.GetName(i) + " " + dr[i]);
                //}
                Console.WriteLine("empid = {0}", dr[0]);
                Console.WriteLine("lastname = {0}", dr["lastname"]);

                Console.WriteLine("firstname = {0}", dr.IsDBNull(2) ? "NULL" : dr.GetString(2));
                Console.WriteLine("title = {0}", dr.IsDBNull(3) ? "NULL" : dr.GetSqlString(3));
                Console.WriteLine("birthdate = {0}", dr.IsDBNull(4) ? "NULL" : dr.GetDateTime(4).ToShortDateString());

                Console.WriteLine("address = {0}", dr.GetValue(7));
                Console.WriteLine("hiredate = {0}", dr["hiredate"].ToString());

                // Get the column ordinal for the region attribute and use it to
                // output the column
                int coRegion = dr.GetOrdinal("region");
                Console.WriteLine("region = {0}", dr[coRegion]);

                // Get the column name for the country attribute
                // and use it to output the column
                string country = dr.GetName(10);
                Console.WriteLine("country = {0}", dr[country]);

                // Create an object array and load the row into it
                object[] o = new object[dr.FieldCount];
                // Output the postalcode attribute from the object array
                dr.GetValues(o);
                Console.WriteLine("postalcode = {0}", o[11].ToString());
                dr.Close();
            }
        }
    }
}


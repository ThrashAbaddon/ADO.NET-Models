using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleDB
{
    class CreateDataColumnForDataTable
    {
        static void Main(string[] args)
        {
            
        }

        static void KreiraStupceKojeDodaUTablicu()
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


    }
}

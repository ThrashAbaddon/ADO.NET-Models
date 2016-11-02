using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApplication1
{
    public partial class Form1 : Form
    {
        private string connectionString =
            @"Data Source=KUSARI-PC\SQLEXPRESS;Initial Catalog=NORTHWND;Integrated Security=True";
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'nORTHWNDDataSet.Employees2' table. You can move, or remove it, as needed.
            this.employees2TableAdapter.Fill(this.nORTHWNDDataSet.Employees2);

        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            using (SqlConnection connection = new SqlConnection(connectionString))
            using (SqlDataAdapter adapter =
                new SqlDataAdapter("SELECT * FROM Employees2", connection))
            using (DataSet dataSet = new DataSet())
            {
                //fill the dataset object
                adapter.Fill(dataSet, "Employees2");
                //use dataset object as datasource
                dataGridView1.DataSource = dataSet.Tables[0];
            }
        }
    }
}

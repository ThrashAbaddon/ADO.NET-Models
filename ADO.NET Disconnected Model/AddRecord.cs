using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace ADO.NET_Disconnected_Model
{
    public partial class AddRecord : Form
    {
        private string connectionString =
            @"Data Source=KUSARI-PC\SQLEXPRESS;Initial Catalog=NORTHWND;Integrated Security=True";

        public AddRecord()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            using (SqlConnection connection = new SqlConnection(connectionString))
            using (SqlDataAdapter adapter = 
                new SqlDataAdapter("SELECT * FROM Employees2", connection))
            using (SqlCommandBuilder commandBuilder = new SqlCommandBuilder(adapter))
            using(DataSet dataSet = new DataSet())
            {
                adapter.Fill(dataSet, "Employees2");
                dataSet.Tables[0].Constraints.Add("Empno_PK",
                    dataSet.Tables[0].Columns[0], true);


                DataRow row;
                row = dataSet.Tables[0].NewRow();
                row["Empno"] = txtEmpno.Text;
                row["Ename"] = txtEname.Text;
                row["Salary"] = txtSalary.Text;
                row["Hiredate"] = dtpHireDate.Value;
                dataSet.Tables[0].Rows.Add(row);
                adapter.Update(dataSet.Tables[0]);
                MessageBox.Show("Employee Record Added.", this.Text);
            }

        }
    }
}

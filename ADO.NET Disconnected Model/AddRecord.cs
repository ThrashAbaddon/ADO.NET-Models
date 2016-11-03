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

        SqlConnection connection;
        SqlDataAdapter adapter;
        SqlCommandBuilder builder;
        DataSet dataSet;

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
            using (DataSet dataSet = new DataSet())
            {
                adapter.Fill(dataSet, "Employees2");
                dataSet.Tables[0].Constraints.Add("Empno_PK", // dodaje constraint
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

        public void ShowEmployeesLoad(object sender, EventArgs e)
        {


        }

        public void SearchEmployeeLoad(object sender, EventArgs e)
        {  }

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

        private void AddRecord_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'nORTHWNDDataSet.Employees2' table. You can move, or remove it, as needed.
            this.employees2TableAdapter.Fill(this.nORTHWNDDataSet.Employees2);

        }

        private void tablePage3_Click(object sender, EventArgs e)
        {

        }

        private void btnSearch_Click(object sender, EventArgs e)
        {
            int empno = int.Parse(txtBoxIdInsert.Text);
            


            using (connection = new SqlConnection(connectionString))
            using (adapter = new SqlDataAdapter("SELECT * FROM Employees2", connection))
            using (dataSet = new DataSet())
            {
                //fill the dataset object
                adapter.Fill(dataSet, "Employees2");
                // add primary key constraint
                dataSet.Tables["Employees2"].Constraints.Add("Empno_PK",
                    dataSet.Tables["Employees2"].Columns["Empno"], true);

                // postoji li redak sa tim recordom?
                if (dataSet.Tables["Employees2"].Rows.Contains(empno) == true)
                {
                    DataRow row;
                    row = dataSet.Tables["Employees2"].Rows.Find(empno);
                    txtBoxEmpNameOut.Text = row["Ename"].ToString();
                    txtBoxEmpSalaryOut.Text = row["Salary"].ToString();
                    txtBoxEmpHiredateOut.Text = row["Hiredate"].ToString();
                }
                else
                {
                    MessageBox.Show("Record doesn't exist", "Error");
                    txtBoxEmpNameOut.Clear();
                    txtBoxIdInsert.Clear();
                    txtBoxEmpSalaryOut.Clear();
                    txtBoxEmpHiredateOut.Clear();
                }
            }
        }

        private void tabPage1_Click(object sender, EventArgs e)
        {

        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            using (connection = new SqlConnection(connectionString))
            using (adapter = new SqlDataAdapter("SELECT * FROM Employees2", connection))
            using (builder = new SqlCommandBuilder(adapter))
            using (dataSet = new DataSet())
            {
                //fill the dataset object
                adapter.Fill(dataSet, "Employees2");
                // add primary key constraint
                dataSet.Tables["Employees2"].Constraints.Add("Empno_PK",
                    dataSet.Tables["Employees2"].Columns["Empno"], true);

                //code to update the data
                int eno = int.Parse(txtBoxIdInsert.Text);
                DataRow row;
                row = dataSet.Tables["Employees2"].Rows.Find(eno);
                row.BeginEdit();
                row["Ename"] = txtBoxEmpNameOut.Text;
                row["Salary"] = txtBoxEmpSalaryOut.Text;
                row.EndEdit();
                adapter.Update(dataSet.Tables["Employees2"]);
                MessageBox.Show("Employee2 record updated.", "Update");
            }
        }
    }
}

namespace ADO.NET_Disconnected_Model
{
    partial class AddRecord
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.button1 = new System.Windows.Forms.Button();
            this.dtpHireDate = new System.Windows.Forms.DateTimePicker();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.txtSalary = new System.Windows.Forms.TextBox();
            this.txtEname = new System.Windows.Forms.TextBox();
            this.txtEmpno = new System.Windows.Forms.TextBox();
            this.tabInsert = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.tablePage2 = new System.Windows.Forms.TabPage();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.empnoDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.enameDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.salaryDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.hiredateDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.employees2BindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.nORTHWNDDataSet = new ADO.NET_Disconnected_Model.NORTHWNDDataSet();
            this.tablePage3 = new System.Windows.Forms.TabPage();
            this.label8 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.txtBoxEmpHiredateOut = new System.Windows.Forms.TextBox();
            this.txtBoxEmpSalaryOut = new System.Windows.Forms.TextBox();
            this.txtBoxEmpNameOut = new System.Windows.Forms.TextBox();
            this.txtBoxIdInsert = new System.Windows.Forms.TextBox();
            this.button2 = new System.Windows.Forms.Button();
            this.employees2TableAdapter = new ADO.NET_Disconnected_Model.NORTHWNDDataSetTableAdapters.Employees2TableAdapter();
            this.btnUpdate = new System.Windows.Forms.Button();
            this.tabInsert.SuspendLayout();
            this.tabPage1.SuspendLayout();
            this.tablePage2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.employees2BindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nORTHWNDDataSet)).BeginInit();
            this.tablePage3.SuspendLayout();
            this.SuspendLayout();
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(250, 181);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(103, 23);
            this.button1.TabIndex = 0;
            this.button1.Text = "Add Employee";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // dtpHireDate
            // 
            this.dtpHireDate.Location = new System.Drawing.Point(194, 136);
            this.dtpHireDate.Name = "dtpHireDate";
            this.dtpHireDate.Size = new System.Drawing.Size(159, 20);
            this.dtpHireDate.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(6, 142);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(53, 13);
            this.label1.TabIndex = 2;
            this.label1.Text = "Hire date:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(6, 104);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(39, 13);
            this.label2.TabIndex = 3;
            this.label2.Text = "Salary:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(6, 66);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(87, 13);
            this.label3.TabIndex = 4;
            this.label3.Text = "Employee Name:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(6, 30);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(96, 13);
            this.label4.TabIndex = 5;
            this.label4.Text = "Employee Number:";
            // 
            // txtSalary
            // 
            this.txtSalary.Location = new System.Drawing.Point(194, 101);
            this.txtSalary.Name = "txtSalary";
            this.txtSalary.Size = new System.Drawing.Size(159, 20);
            this.txtSalary.TabIndex = 6;
            // 
            // txtEname
            // 
            this.txtEname.Location = new System.Drawing.Point(194, 63);
            this.txtEname.Name = "txtEname";
            this.txtEname.Size = new System.Drawing.Size(159, 20);
            this.txtEname.TabIndex = 7;
            // 
            // txtEmpno
            // 
            this.txtEmpno.Location = new System.Drawing.Point(194, 27);
            this.txtEmpno.Name = "txtEmpno";
            this.txtEmpno.Size = new System.Drawing.Size(159, 20);
            this.txtEmpno.TabIndex = 8;
            // 
            // tabInsert
            // 
            this.tabInsert.Controls.Add(this.tabPage1);
            this.tabInsert.Controls.Add(this.tablePage2);
            this.tabInsert.Controls.Add(this.tablePage3);
            this.tabInsert.Cursor = System.Windows.Forms.Cursors.Default;
            this.tabInsert.Location = new System.Drawing.Point(12, 12);
            this.tabInsert.Name = "tabInsert";
            this.tabInsert.SelectedIndex = 0;
            this.tabInsert.Size = new System.Drawing.Size(387, 254);
            this.tabInsert.TabIndex = 9;
            // 
            // tabPage1
            // 
            this.tabPage1.Controls.Add(this.txtEmpno);
            this.tabPage1.Controls.Add(this.dtpHireDate);
            this.tabPage1.Controls.Add(this.label4);
            this.tabPage1.Controls.Add(this.button1);
            this.tabPage1.Controls.Add(this.label3);
            this.tabPage1.Controls.Add(this.txtSalary);
            this.tabPage1.Controls.Add(this.label2);
            this.tabPage1.Controls.Add(this.txtEname);
            this.tabPage1.Controls.Add(this.label1);
            this.tabPage1.Location = new System.Drawing.Point(4, 22);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(379, 228);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "Insert";
            this.tabPage1.UseVisualStyleBackColor = true;
            this.tabPage1.Click += new System.EventHandler(this.tabPage1_Click);
            // 
            // tablePage2
            // 
            this.tablePage2.Controls.Add(this.dataGridView1);
            this.tablePage2.Location = new System.Drawing.Point(4, 22);
            this.tablePage2.Name = "tablePage2";
            this.tablePage2.Padding = new System.Windows.Forms.Padding(3);
            this.tablePage2.Size = new System.Drawing.Size(379, 228);
            this.tablePage2.TabIndex = 1;
            this.tablePage2.Text = "View Table";
            this.tablePage2.UseVisualStyleBackColor = true;
            // 
            // dataGridView1
            // 
            this.dataGridView1.AutoGenerateColumns = false;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.empnoDataGridViewTextBoxColumn,
            this.enameDataGridViewTextBoxColumn,
            this.salaryDataGridViewTextBoxColumn,
            this.hiredateDataGridViewTextBoxColumn});
            this.dataGridView1.DataSource = this.employees2BindingSource;
            this.dataGridView1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dataGridView1.Location = new System.Drawing.Point(3, 3);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(373, 222);
            this.dataGridView1.TabIndex = 0;
            this.dataGridView1.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
            // 
            // empnoDataGridViewTextBoxColumn
            // 
            this.empnoDataGridViewTextBoxColumn.DataPropertyName = "Empno";
            this.empnoDataGridViewTextBoxColumn.HeaderText = "Empno";
            this.empnoDataGridViewTextBoxColumn.Name = "empnoDataGridViewTextBoxColumn";
            // 
            // enameDataGridViewTextBoxColumn
            // 
            this.enameDataGridViewTextBoxColumn.DataPropertyName = "Ename";
            this.enameDataGridViewTextBoxColumn.HeaderText = "Ename";
            this.enameDataGridViewTextBoxColumn.Name = "enameDataGridViewTextBoxColumn";
            // 
            // salaryDataGridViewTextBoxColumn
            // 
            this.salaryDataGridViewTextBoxColumn.DataPropertyName = "Salary";
            this.salaryDataGridViewTextBoxColumn.HeaderText = "Salary";
            this.salaryDataGridViewTextBoxColumn.Name = "salaryDataGridViewTextBoxColumn";
            // 
            // hiredateDataGridViewTextBoxColumn
            // 
            this.hiredateDataGridViewTextBoxColumn.DataPropertyName = "Hiredate";
            this.hiredateDataGridViewTextBoxColumn.HeaderText = "Hiredate";
            this.hiredateDataGridViewTextBoxColumn.Name = "hiredateDataGridViewTextBoxColumn";
            // 
            // employees2BindingSource
            // 
            this.employees2BindingSource.DataMember = "Employees2";
            this.employees2BindingSource.DataSource = this.nORTHWNDDataSet;
            // 
            // nORTHWNDDataSet
            // 
            this.nORTHWNDDataSet.DataSetName = "NORTHWNDDataSet";
            this.nORTHWNDDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // tablePage3
            // 
            this.tablePage3.Controls.Add(this.btnUpdate);
            this.tablePage3.Controls.Add(this.label8);
            this.tablePage3.Controls.Add(this.label7);
            this.tablePage3.Controls.Add(this.label6);
            this.tablePage3.Controls.Add(this.label5);
            this.tablePage3.Controls.Add(this.txtBoxEmpHiredateOut);
            this.tablePage3.Controls.Add(this.txtBoxEmpSalaryOut);
            this.tablePage3.Controls.Add(this.txtBoxEmpNameOut);
            this.tablePage3.Controls.Add(this.txtBoxIdInsert);
            this.tablePage3.Controls.Add(this.button2);
            this.tablePage3.Location = new System.Drawing.Point(4, 22);
            this.tablePage3.Name = "tablePage3";
            this.tablePage3.Padding = new System.Windows.Forms.Padding(3);
            this.tablePage3.Size = new System.Drawing.Size(379, 228);
            this.tablePage3.TabIndex = 2;
            this.tablePage3.Text = "SearchEmployee";
            this.tablePage3.UseVisualStyleBackColor = true;
            this.tablePage3.Click += new System.EventHandler(this.tablePage3_Click);
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(63, 142);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(53, 13);
            this.label8.TabIndex = 8;
            this.label8.Text = "Hiredate :";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(74, 101);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(42, 13);
            this.label7.TabIndex = 7;
            this.label7.Text = "Salary :";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(26, 63);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(90, 13);
            this.label6.TabIndex = 6;
            this.label6.Text = "Employee Name :";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(47, 26);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(69, 13);
            this.label5.TabIndex = 5;
            this.label5.Text = "Employee # :";
            this.label5.UseWaitCursor = true;
            // 
            // txtBoxEmpHiredateOut
            // 
            this.txtBoxEmpHiredateOut.Location = new System.Drawing.Point(145, 139);
            this.txtBoxEmpHiredateOut.Name = "txtBoxEmpHiredateOut";
            this.txtBoxEmpHiredateOut.Size = new System.Drawing.Size(210, 20);
            this.txtBoxEmpHiredateOut.TabIndex = 4;
            // 
            // txtBoxEmpSalaryOut
            // 
            this.txtBoxEmpSalaryOut.Location = new System.Drawing.Point(145, 98);
            this.txtBoxEmpSalaryOut.Name = "txtBoxEmpSalaryOut";
            this.txtBoxEmpSalaryOut.Size = new System.Drawing.Size(210, 20);
            this.txtBoxEmpSalaryOut.TabIndex = 3;
            // 
            // txtBoxEmpNameOut
            // 
            this.txtBoxEmpNameOut.Location = new System.Drawing.Point(145, 63);
            this.txtBoxEmpNameOut.Name = "txtBoxEmpNameOut";
            this.txtBoxEmpNameOut.Size = new System.Drawing.Size(210, 20);
            this.txtBoxEmpNameOut.TabIndex = 2;
            // 
            // txtBoxIdInsert
            // 
            this.txtBoxIdInsert.Location = new System.Drawing.Point(145, 23);
            this.txtBoxIdInsert.Name = "txtBoxIdInsert";
            this.txtBoxIdInsert.Size = new System.Drawing.Size(100, 20);
            this.txtBoxIdInsert.TabIndex = 1;
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(280, 20);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(75, 23);
            this.button2.TabIndex = 0;
            this.button2.Text = "Search";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.btnSearch_Click);
            // 
            // employees2TableAdapter
            // 
            this.employees2TableAdapter.ClearBeforeFill = true;
            // 
            // btnUpdate
            // 
            this.btnUpdate.Location = new System.Drawing.Point(280, 182);
            this.btnUpdate.Name = "btnUpdate";
            this.btnUpdate.Size = new System.Drawing.Size(75, 23);
            this.btnUpdate.TabIndex = 9;
            this.btnUpdate.Text = "Update";
            this.btnUpdate.UseVisualStyleBackColor = true;
            this.btnUpdate.Click += new System.EventHandler(this.btnUpdate_Click);
            // 
            // AddRecord
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(405, 277);
            this.Controls.Add(this.tabInsert);
            this.Name = "AddRecord";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.AddRecord_Load);
            this.tabInsert.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.tabPage1.PerformLayout();
            this.tablePage2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.employees2BindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nORTHWNDDataSet)).EndInit();
            this.tablePage3.ResumeLayout(false);
            this.tablePage3.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.DateTimePicker dtpHireDate;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtSalary;
        private System.Windows.Forms.TextBox txtEname;
        private System.Windows.Forms.TextBox txtEmpno;
        private System.Windows.Forms.TabControl tabInsert;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.TabPage tablePage2;
        private System.Windows.Forms.DataGridView dataGridView1;
        private NORTHWNDDataSet nORTHWNDDataSet;
        private System.Windows.Forms.BindingSource employees2BindingSource;
        private NORTHWNDDataSetTableAdapters.Employees2TableAdapter employees2TableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn empnoDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn enameDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn salaryDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn hiredateDataGridViewTextBoxColumn;
        private System.Windows.Forms.TabPage tablePage3;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txtBoxEmpHiredateOut;
        private System.Windows.Forms.TextBox txtBoxEmpSalaryOut;
        private System.Windows.Forms.TextBox txtBoxEmpNameOut;
        private System.Windows.Forms.TextBox txtBoxIdInsert;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button btnUpdate;
    }
}


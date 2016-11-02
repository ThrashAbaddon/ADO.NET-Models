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
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.tabInsert.SuspendLayout();
            this.tabPage1.SuspendLayout();
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
            this.tabInsert.Controls.Add(this.tabPage2);
            this.tabInsert.Location = new System.Drawing.Point(13, 13);
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
            this.tabPage1.Text = "tabPage1";
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // tabPage2
            // 
            this.tabPage2.Location = new System.Drawing.Point(4, 22);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(379, 228);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "tabPage2";
            this.tabPage2.UseVisualStyleBackColor = true;
            // 
            // AddRecord
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(405, 277);
            this.Controls.Add(this.tabInsert);
            this.Name = "AddRecord";
            this.Text = "Form1";
            this.tabInsert.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.tabPage1.PerformLayout();
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
        private System.Windows.Forms.TabPage tabPage2;
    }
}


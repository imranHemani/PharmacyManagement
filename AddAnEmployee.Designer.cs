namespace Pharmacy_Management_System
{
    partial class AddAnEmployee
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
            this.button2 = new System.Windows.Forms.Button();
            this.GroupBox3 = new System.Windows.Forms.GroupBox();
            this.payroll = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.hiredate = new System.Windows.Forms.DateTimePicker();
            this.mgrname = new System.Windows.Forms.ComboBox();
            this.inss = new System.Windows.Forms.TextBox();
            this.sal = new System.Windows.Forms.TextBox();
            this.ename = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.Label2 = new System.Windows.Forms.Label();
            this.empid = new System.Windows.Forms.TextBox();
            this.branchLabel = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.button1 = new System.Windows.Forms.Button();
            this.ex_empid = new System.Windows.Forms.Label();
            this.ex_ename = new System.Windows.Forms.Label();
            this.ex_sal = new System.Windows.Forms.Label();
            this.ex_inss = new System.Windows.Forms.Label();
            this.ex_payroll = new System.Windows.Forms.Label();
            this.msg_bno = new System.Windows.Forms.Label();
            this.msg_mgr = new System.Windows.Forms.Label();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.bno = new System.Windows.Forms.ComboBox();
            this.listBox1 = new System.Windows.Forms.ListBox();
            this.GroupBox3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // button2
            // 
            this.button2.Font = new System.Drawing.Font("Bookman Old Style", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button2.ForeColor = System.Drawing.SystemColors.ControlText;
            this.button2.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.button2.Location = new System.Drawing.Point(242, 341);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(105, 36);
            this.button2.TabIndex = 43;
            this.button2.Text = "CLEAR";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // GroupBox3
            // 
            this.GroupBox3.Controls.Add(this.payroll);
            this.GroupBox3.Controls.Add(this.label8);
            this.GroupBox3.Controls.Add(this.bno);
            this.GroupBox3.Controls.Add(this.hiredate);
            this.GroupBox3.Controls.Add(this.mgrname);
            this.GroupBox3.Controls.Add(this.inss);
            this.GroupBox3.Controls.Add(this.sal);
            this.GroupBox3.Controls.Add(this.ename);
            this.GroupBox3.Controls.Add(this.label7);
            this.GroupBox3.Controls.Add(this.label5);
            this.GroupBox3.Controls.Add(this.label6);
            this.GroupBox3.Controls.Add(this.label3);
            this.GroupBox3.Controls.Add(this.label4);
            this.GroupBox3.Controls.Add(this.label1);
            this.GroupBox3.Controls.Add(this.Label2);
            this.GroupBox3.Controls.Add(this.empid);
            this.GroupBox3.Location = new System.Drawing.Point(43, 77);
            this.GroupBox3.Name = "GroupBox3";
            this.GroupBox3.Size = new System.Drawing.Size(367, 253);
            this.GroupBox3.TabIndex = 41;
            this.GroupBox3.TabStop = false;
            // 
            // payroll
            // 
            this.payroll.BackColor = System.Drawing.Color.White;
            this.payroll.Location = new System.Drawing.Point(148, 220);
            this.payroll.Margin = new System.Windows.Forms.Padding(2);
            this.payroll.Name = "payroll";
            this.payroll.Size = new System.Drawing.Size(200, 20);
            this.payroll.TabIndex = 787;
            this.payroll.TextChanged += new System.EventHandler(this.payroll_TextChanged);
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.ForeColor = System.Drawing.Color.Black;
            this.label8.Location = new System.Drawing.Point(18, 134);
            this.label8.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(107, 16);
            this.label8.TabIndex = 786;
            this.label8.Text = "Branch Number";
            // 
            // hiredate
            // 
            this.hiredate.Location = new System.Drawing.Point(148, 76);
            this.hiredate.Name = "hiredate";
            this.hiredate.Size = new System.Drawing.Size(200, 20);
            this.hiredate.TabIndex = 784;
            this.hiredate.ValueChanged += new System.EventHandler(this.hiredate_ValueChanged);
            // 
            // mgrname
            // 
            this.mgrname.FormattingEnabled = true;
            this.mgrname.Items.AddRange(new object[] {
            "dfd",
            "f",
            "sd",
            "f",
            "ds",
            "",
            "fds"});
            this.mgrname.Location = new System.Drawing.Point(148, 102);
            this.mgrname.Name = "mgrname";
            this.mgrname.Size = new System.Drawing.Size(200, 21);
            this.mgrname.TabIndex = 783;
            this.mgrname.SelectedIndexChanged += new System.EventHandler(this.mgrname_SelectedIndexChanged);
            this.mgrname.TextChanged += new System.EventHandler(this.mgrname_TextChanged);
            // 
            // inss
            // 
            this.inss.BackColor = System.Drawing.Color.White;
            this.inss.Location = new System.Drawing.Point(148, 188);
            this.inss.Margin = new System.Windows.Forms.Padding(2);
            this.inss.Name = "inss";
            this.inss.Size = new System.Drawing.Size(200, 20);
            this.inss.TabIndex = 782;
            this.inss.TextChanged += new System.EventHandler(this.inss_TextChanged);
            // 
            // sal
            // 
            this.sal.BackColor = System.Drawing.Color.White;
            this.sal.Location = new System.Drawing.Point(148, 159);
            this.sal.Margin = new System.Windows.Forms.Padding(2);
            this.sal.Name = "sal";
            this.sal.Size = new System.Drawing.Size(200, 20);
            this.sal.TabIndex = 781;
            this.sal.TextChanged += new System.EventHandler(this.sal_TextChanged);
            // 
            // ename
            // 
            this.ename.BackColor = System.Drawing.Color.White;
            this.ename.Location = new System.Drawing.Point(148, 48);
            this.ename.Margin = new System.Windows.Forms.Padding(2);
            this.ename.Name = "ename";
            this.ename.Size = new System.Drawing.Size(200, 20);
            this.ename.TabIndex = 780;
            this.ename.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.ForeColor = System.Drawing.Color.Black;
            this.label7.Location = new System.Drawing.Point(18, 221);
            this.label7.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(53, 16);
            this.label7.TabIndex = 779;
            this.label7.Text = "Payroll";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.Color.Black;
            this.label5.Location = new System.Drawing.Point(18, 192);
            this.label5.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(39, 16);
            this.label5.TabIndex = 778;
            this.label5.Text = "INSS";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.ForeColor = System.Drawing.Color.Black;
            this.label6.Location = new System.Drawing.Point(18, 163);
            this.label6.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(49, 16);
            this.label6.TabIndex = 777;
            this.label6.Text = "Salary";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.Black;
            this.label3.Location = new System.Drawing.Point(18, 81);
            this.label3.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(62, 16);
            this.label3.TabIndex = 776;
            this.label3.Text = "Hiredate";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.Black;
            this.label4.Location = new System.Drawing.Point(18, 107);
            this.label4.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(105, 16);
            this.label4.TabIndex = 775;
            this.label4.Text = "Manager Name";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.Black;
            this.label1.Location = new System.Drawing.Point(18, 52);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(112, 16);
            this.label1.TabIndex = 774;
            this.label1.Text = "Employee Name";
            // 
            // Label2
            // 
            this.Label2.AutoSize = true;
            this.Label2.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Label2.ForeColor = System.Drawing.Color.Black;
            this.Label2.Location = new System.Drawing.Point(18, 23);
            this.Label2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.Label2.Name = "Label2";
            this.Label2.Size = new System.Drawing.Size(88, 16);
            this.Label2.TabIndex = 2;
            this.Label2.Text = "Employee ID";
            // 
            // empid
            // 
            this.empid.BackColor = System.Drawing.Color.White;
            this.empid.Location = new System.Drawing.Point(148, 19);
            this.empid.Margin = new System.Windows.Forms.Padding(2);
            this.empid.Name = "empid";
            this.empid.Size = new System.Drawing.Size(200, 20);
            this.empid.TabIndex = 767;
            this.empid.TextChanged += new System.EventHandler(this.branchNo_TextChanged);
            // 
            // branchLabel
            // 
            this.branchLabel.AutoSize = true;
            this.branchLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.branchLabel.Location = new System.Drawing.Point(147, 45);
            this.branchLabel.Name = "branchLabel";
            this.branchLabel.Size = new System.Drawing.Size(220, 29);
            this.branchLabel.TabIndex = 44;
            this.branchLabel.Text = "Add An Employee";
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::Pharmacy_Management_System.Properties.Resources.employee_icon_by_ornorm_d4wep0s;
            this.pictureBox1.Location = new System.Drawing.Point(74, 30);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(71, 46);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 45;
            this.pictureBox1.TabStop = false;
            this.pictureBox1.Click += new System.EventHandler(this.pictureBox1_Click);
            // 
            // button1
            // 
            this.button1.Font = new System.Drawing.Font("Bookman Old Style", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.ForeColor = System.Drawing.SystemColors.ControlText;
            this.button1.Image = global::Pharmacy_Management_System.Properties.Resources.Save_;
            this.button1.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.button1.Location = new System.Drawing.Point(106, 341);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(105, 36);
            this.button1.TabIndex = 42;
            this.button1.Text = "        INSERT";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // ex_empid
            // 
            this.ex_empid.AutoSize = true;
            this.ex_empid.Font = new System.Drawing.Font("Arial", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ex_empid.ForeColor = System.Drawing.Color.Maroon;
            this.ex_empid.Location = new System.Drawing.Point(415, 100);
            this.ex_empid.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.ex_empid.Name = "ex_empid";
            this.ex_empid.Size = new System.Drawing.Size(74, 14);
            this.ex_empid.TabIndex = 788;
            this.ex_empid.Text = "Employee ID";
            this.ex_empid.Click += new System.EventHandler(this.label9_Click);
            // 
            // ex_ename
            // 
            this.ex_ename.AutoSize = true;
            this.ex_ename.Font = new System.Drawing.Font("Arial", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ex_ename.ForeColor = System.Drawing.Color.Maroon;
            this.ex_ename.Location = new System.Drawing.Point(415, 128);
            this.ex_ename.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.ex_ename.Name = "ex_ename";
            this.ex_ename.Size = new System.Drawing.Size(74, 14);
            this.ex_ename.TabIndex = 789;
            this.ex_ename.Text = "Employee ID";
            // 
            // ex_sal
            // 
            this.ex_sal.AutoSize = true;
            this.ex_sal.Font = new System.Drawing.Font("Arial", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ex_sal.ForeColor = System.Drawing.Color.Maroon;
            this.ex_sal.Location = new System.Drawing.Point(415, 239);
            this.ex_sal.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.ex_sal.Name = "ex_sal";
            this.ex_sal.Size = new System.Drawing.Size(74, 14);
            this.ex_sal.TabIndex = 790;
            this.ex_sal.Text = "Employee ID";
            // 
            // ex_inss
            // 
            this.ex_inss.AutoSize = true;
            this.ex_inss.Font = new System.Drawing.Font("Arial", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ex_inss.ForeColor = System.Drawing.Color.Maroon;
            this.ex_inss.Location = new System.Drawing.Point(415, 268);
            this.ex_inss.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.ex_inss.Name = "ex_inss";
            this.ex_inss.Size = new System.Drawing.Size(74, 14);
            this.ex_inss.TabIndex = 791;
            this.ex_inss.Text = "Employee ID";
            // 
            // ex_payroll
            // 
            this.ex_payroll.AutoSize = true;
            this.ex_payroll.Font = new System.Drawing.Font("Arial", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ex_payroll.ForeColor = System.Drawing.Color.Maroon;
            this.ex_payroll.Location = new System.Drawing.Point(415, 300);
            this.ex_payroll.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.ex_payroll.Name = "ex_payroll";
            this.ex_payroll.Size = new System.Drawing.Size(74, 14);
            this.ex_payroll.TabIndex = 792;
            this.ex_payroll.Text = "Employee ID";
            // 
            // msg_bno
            // 
            this.msg_bno.AutoSize = true;
            this.msg_bno.Font = new System.Drawing.Font("Arial", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.msg_bno.ForeColor = System.Drawing.Color.Gray;
            this.msg_bno.Location = new System.Drawing.Point(415, 209);
            this.msg_bno.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.msg_bno.Name = "msg_bno";
            this.msg_bno.Size = new System.Drawing.Size(74, 14);
            this.msg_bno.TabIndex = 793;
            this.msg_bno.Text = "Employee ID";
            // 
            // msg_mgr
            // 
            this.msg_mgr.AutoSize = true;
            this.msg_mgr.Font = new System.Drawing.Font("Arial", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.msg_mgr.ForeColor = System.Drawing.Color.Gray;
            this.msg_mgr.Location = new System.Drawing.Point(415, 182);
            this.msg_mgr.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.msg_mgr.Name = "msg_mgr";
            this.msg_mgr.Size = new System.Drawing.Size(74, 14);
            this.msg_mgr.TabIndex = 794;
            this.msg_mgr.Text = "Employee ID";
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(494, 77);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(119, 150);
            this.dataGridView1.TabIndex = 795;
            // 
            // bno
            // 
            this.bno.FormattingEnabled = true;
            this.bno.Location = new System.Drawing.Point(148, 129);
            this.bno.Name = "bno";
            this.bno.Size = new System.Drawing.Size(200, 21);
            this.bno.TabIndex = 785;
            this.bno.SelectedIndexChanged += new System.EventHandler(this.bno_SelectedIndexChanged);
            this.bno.TextChanged += new System.EventHandler(this.bno_TextChanged_1);
            // 
            // listBox1
            // 
            this.listBox1.FormattingEnabled = true;
            this.listBox1.Location = new System.Drawing.Point(494, 251);
            this.listBox1.Name = "listBox1";
            this.listBox1.Size = new System.Drawing.Size(120, 95);
            this.listBox1.TabIndex = 796;
            this.listBox1.SelectedIndexChanged += new System.EventHandler(this.listBox1_SelectedIndexChanged);
            // 
            // AddAnEmployee
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(625, 413);
            this.Controls.Add(this.listBox1);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.msg_mgr);
            this.Controls.Add(this.msg_bno);
            this.Controls.Add(this.ex_payroll);
            this.Controls.Add(this.ex_inss);
            this.Controls.Add(this.ex_sal);
            this.Controls.Add(this.ex_ename);
            this.Controls.Add(this.ex_empid);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.branchLabel);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.GroupBox3);
            this.Name = "AddAnEmployee";
            this.Text = "AddAnEmployee";
            this.GroupBox3.ResumeLayout(false);
            this.GroupBox3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button1;
        internal System.Windows.Forms.GroupBox GroupBox3;
        internal System.Windows.Forms.Label Label2;
        internal System.Windows.Forms.TextBox empid;
        private System.Windows.Forms.DateTimePicker hiredate;
        private System.Windows.Forms.ComboBox mgrname;
        internal System.Windows.Forms.TextBox inss;
        internal System.Windows.Forms.TextBox sal;
        internal System.Windows.Forms.TextBox ename;
        internal System.Windows.Forms.Label label7;
        internal System.Windows.Forms.Label label5;
        internal System.Windows.Forms.Label label6;
        internal System.Windows.Forms.Label label3;
        internal System.Windows.Forms.Label label4;
        internal System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label branchLabel;
        private System.Windows.Forms.PictureBox pictureBox1;
        internal System.Windows.Forms.Label label8;
        internal System.Windows.Forms.TextBox payroll;
        internal System.Windows.Forms.Label ex_empid;
        internal System.Windows.Forms.Label ex_ename;
        internal System.Windows.Forms.Label ex_sal;
        internal System.Windows.Forms.Label ex_inss;
        internal System.Windows.Forms.Label ex_payroll;
        internal System.Windows.Forms.Label msg_bno;
        internal System.Windows.Forms.Label msg_mgr;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.ComboBox bno;
        private System.Windows.Forms.ListBox listBox1;
    }
}
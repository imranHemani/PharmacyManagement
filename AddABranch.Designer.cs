namespace Pharmacy_Management_System
{
    partial class AddABranch
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
            this.GroupBox3 = new System.Windows.Forms.GroupBox();
            this.mgr = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.pno = new System.Windows.Forms.TextBox();
            this.loc = new System.Windows.Forms.RichTextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.Label2 = new System.Windows.Forms.Label();
            this.bno = new System.Windows.Forms.TextBox();
            this.Label3 = new System.Windows.Forms.Label();
            this.branchLabel = new System.Windows.Forms.Label();
            this.button2 = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.ex_bno = new System.Windows.Forms.Label();
            this.ex_loc = new System.Windows.Forms.Label();
            this.ex_pno = new System.Windows.Forms.Label();
            this.msg_mgr = new System.Windows.Forms.Label();
            this.GroupBox3.SuspendLayout();
            this.SuspendLayout();
            // 
            // GroupBox3
            // 
            this.GroupBox3.Controls.Add(this.mgr);
            this.GroupBox3.Controls.Add(this.label1);
            this.GroupBox3.Controls.Add(this.pno);
            this.GroupBox3.Controls.Add(this.loc);
            this.GroupBox3.Controls.Add(this.label5);
            this.GroupBox3.Controls.Add(this.Label2);
            this.GroupBox3.Controls.Add(this.bno);
            this.GroupBox3.Controls.Add(this.Label3);
            this.GroupBox3.Location = new System.Drawing.Point(12, 59);
            this.GroupBox3.Name = "GroupBox3";
            this.GroupBox3.Size = new System.Drawing.Size(305, 206);
            this.GroupBox3.TabIndex = 4;
            this.GroupBox3.TabStop = false;
            // 
            // mgr
            // 
            this.mgr.FormattingEnabled = true;
            this.mgr.Items.AddRange(new object[] {
            "0"});
            this.mgr.Location = new System.Drawing.Point(148, 170);
            this.mgr.Name = "mgr";
            this.mgr.Size = new System.Drawing.Size(135, 21);
            this.mgr.TabIndex = 773;
            this.mgr.SelectedIndexChanged += new System.EventHandler(this.mgr_SelectedIndexChanged);
            this.mgr.TextChanged += new System.EventHandler(this.mgr_TextChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.Black;
            this.label1.Location = new System.Drawing.Point(18, 170);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(64, 16);
            this.label1.TabIndex = 772;
            this.label1.Text = "Manager";
            // 
            // pno
            // 
            this.pno.BackColor = System.Drawing.Color.White;
            this.pno.Location = new System.Drawing.Point(148, 137);
            this.pno.Margin = new System.Windows.Forms.Padding(2);
            this.pno.Name = "pno";
            this.pno.Size = new System.Drawing.Size(135, 20);
            this.pno.TabIndex = 771;
            this.pno.TextChanged += new System.EventHandler(this.pno_TextChanged);
            // 
            // loc
            // 
            this.loc.Location = new System.Drawing.Point(148, 60);
            this.loc.Name = "loc";
            this.loc.Size = new System.Drawing.Size(135, 64);
            this.loc.TabIndex = 5;
            this.loc.Text = "";
            this.loc.TextChanged += new System.EventHandler(this.location_TextChanged);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.Color.Black;
            this.label5.Location = new System.Drawing.Point(18, 138);
            this.label5.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(103, 16);
            this.label5.TabIndex = 770;
            this.label5.Text = "Phone Number";
            // 
            // Label2
            // 
            this.Label2.AutoSize = true;
            this.Label2.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Label2.ForeColor = System.Drawing.Color.Black;
            this.Label2.Location = new System.Drawing.Point(18, 23);
            this.Label2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.Label2.Name = "Label2";
            this.Label2.Size = new System.Drawing.Size(107, 16);
            this.Label2.TabIndex = 2;
            this.Label2.Text = "Branch Number";
            // 
            // bno
            // 
            this.bno.BackColor = System.Drawing.Color.White;
            this.bno.Location = new System.Drawing.Point(148, 19);
            this.bno.Margin = new System.Windows.Forms.Padding(2);
            this.bno.Name = "bno";
            this.bno.Size = new System.Drawing.Size(135, 20);
            this.bno.TabIndex = 767;
            this.bno.TextChanged += new System.EventHandler(this.txtCode_TextChanged);
            // 
            // Label3
            // 
            this.Label3.AutoSize = true;
            this.Label3.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Label3.ForeColor = System.Drawing.Color.Black;
            this.Label3.Location = new System.Drawing.Point(18, 60);
            this.Label3.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.Label3.Name = "Label3";
            this.Label3.Size = new System.Drawing.Size(63, 16);
            this.Label3.TabIndex = 5;
            this.Label3.Text = "Location";
            // 
            // branchLabel
            // 
            this.branchLabel.AutoSize = true;
            this.branchLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.branchLabel.Location = new System.Drawing.Point(86, 27);
            this.branchLabel.Name = "branchLabel";
            this.branchLabel.Size = new System.Drawing.Size(170, 29);
            this.branchLabel.TabIndex = 5;
            this.branchLabel.Text = "Add A Branch";
            // 
            // button2
            // 
            this.button2.Font = new System.Drawing.Font("Bookman Old Style", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button2.ForeColor = System.Drawing.SystemColors.ControlText;
            this.button2.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.button2.Location = new System.Drawing.Point(178, 280);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(105, 36);
            this.button2.TabIndex = 40;
            this.button2.Text = "CLEAR";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // button1
            // 
            this.button1.Font = new System.Drawing.Font("Bookman Old Style", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.ForeColor = System.Drawing.SystemColors.ControlText;
            this.button1.Image = global::Pharmacy_Management_System.Properties.Resources.Save_;
            this.button1.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.button1.Location = new System.Drawing.Point(42, 280);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(105, 36);
            this.button1.TabIndex = 39;
            this.button1.Text = "    SAVE";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // ex_bno
            // 
            this.ex_bno.AutoSize = true;
            this.ex_bno.Font = new System.Drawing.Font("Arial", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ex_bno.ForeColor = System.Drawing.Color.Maroon;
            this.ex_bno.Location = new System.Drawing.Point(322, 81);
            this.ex_bno.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.ex_bno.Name = "ex_bno";
            this.ex_bno.Size = new System.Drawing.Size(74, 14);
            this.ex_bno.TabIndex = 789;
            this.ex_bno.Text = "Employee ID";
            // 
            // ex_loc
            // 
            this.ex_loc.AutoSize = true;
            this.ex_loc.Font = new System.Drawing.Font("Arial", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ex_loc.ForeColor = System.Drawing.Color.Maroon;
            this.ex_loc.Location = new System.Drawing.Point(322, 142);
            this.ex_loc.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.ex_loc.Name = "ex_loc";
            this.ex_loc.Size = new System.Drawing.Size(74, 14);
            this.ex_loc.TabIndex = 790;
            this.ex_loc.Text = "Employee ID";
            // 
            // ex_pno
            // 
            this.ex_pno.AutoSize = true;
            this.ex_pno.Font = new System.Drawing.Font("Arial", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ex_pno.ForeColor = System.Drawing.Color.Maroon;
            this.ex_pno.Location = new System.Drawing.Point(322, 199);
            this.ex_pno.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.ex_pno.Name = "ex_pno";
            this.ex_pno.Size = new System.Drawing.Size(74, 14);
            this.ex_pno.TabIndex = 791;
            this.ex_pno.Text = "Employee ID";
            // 
            // msg_mgr
            // 
            this.msg_mgr.AutoSize = true;
            this.msg_mgr.Font = new System.Drawing.Font("Arial", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.msg_mgr.ForeColor = System.Drawing.Color.Gray;
            this.msg_mgr.Location = new System.Drawing.Point(322, 232);
            this.msg_mgr.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.msg_mgr.Name = "msg_mgr";
            this.msg_mgr.Size = new System.Drawing.Size(74, 14);
            this.msg_mgr.TabIndex = 795;
            this.msg_mgr.Text = "Employee ID";
            // 
            // AddABranch
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(488, 333);
            this.Controls.Add(this.msg_mgr);
            this.Controls.Add(this.ex_pno);
            this.Controls.Add(this.ex_loc);
            this.Controls.Add(this.ex_bno);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.branchLabel);
            this.Controls.Add(this.GroupBox3);
            this.Name = "AddABranch";
            this.Text = "AddABranch";
            this.GroupBox3.ResumeLayout(false);
            this.GroupBox3.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        internal System.Windows.Forms.GroupBox GroupBox3;
        internal System.Windows.Forms.Label label5;
        internal System.Windows.Forms.Label Label2;
        internal System.Windows.Forms.TextBox bno;
        internal System.Windows.Forms.Label Label3;
        private System.Windows.Forms.RichTextBox loc;
        internal System.Windows.Forms.TextBox pno;
        private System.Windows.Forms.ComboBox mgr;
        internal System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label branchLabel;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button1;
        internal System.Windows.Forms.Label ex_bno;
        internal System.Windows.Forms.Label ex_loc;
        internal System.Windows.Forms.Label ex_pno;
        internal System.Windows.Forms.Label msg_mgr;

    }
}
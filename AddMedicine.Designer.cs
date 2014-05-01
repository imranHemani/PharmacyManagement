namespace Pharmacy_Management_System
{
    partial class AddMedicine
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
            this.label4 = new System.Windows.Forms.Label();
            this.comname = new System.Windows.Forms.TextBox();
            this.sciname = new System.Windows.Forms.TextBox();
            this.Label2 = new System.Windows.Forms.Label();
            this.mid = new System.Windows.Forms.TextBox();
            this.Label3 = new System.Windows.Forms.Label();
            this.button2 = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.medicineLabel = new System.Windows.Forms.Label();
            this.ex_mid = new System.Windows.Forms.Label();
            this.GroupBox3.SuspendLayout();
            this.SuspendLayout();
            // 
            // GroupBox3
            // 
            this.GroupBox3.Controls.Add(this.label4);
            this.GroupBox3.Controls.Add(this.comname);
            this.GroupBox3.Controls.Add(this.sciname);
            this.GroupBox3.Controls.Add(this.Label2);
            this.GroupBox3.Controls.Add(this.mid);
            this.GroupBox3.Controls.Add(this.Label3);
            this.GroupBox3.Location = new System.Drawing.Point(40, 68);
            this.GroupBox3.Name = "GroupBox3";
            this.GroupBox3.Size = new System.Drawing.Size(305, 139);
            this.GroupBox3.TabIndex = 3;
            this.GroupBox3.TabStop = false;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.Black;
            this.label4.Location = new System.Drawing.Point(18, 94);
            this.label4.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(126, 16);
            this.label4.TabIndex = 769;
            this.label4.Text = "Commercial Name";
            this.label4.Click += new System.EventHandler(this.label4_Click);
            // 
            // comname
            // 
            this.comname.BackColor = System.Drawing.Color.White;
            this.comname.Location = new System.Drawing.Point(148, 94);
            this.comname.Margin = new System.Windows.Forms.Padding(2);
            this.comname.Name = "comname";
            this.comname.Size = new System.Drawing.Size(135, 20);
            this.comname.TabIndex = 771;
            this.comname.TextChanged += new System.EventHandler(this.textBox3_TextChanged);
            // 
            // sciname
            // 
            this.sciname.Location = new System.Drawing.Point(148, 60);
            this.sciname.Name = "sciname";
            this.sciname.Size = new System.Drawing.Size(135, 20);
            this.sciname.TabIndex = 768;
            this.sciname.TextChanged += new System.EventHandler(this.sciname_TextChanged);
            // 
            // Label2
            // 
            this.Label2.AutoSize = true;
            this.Label2.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Label2.ForeColor = System.Drawing.Color.Black;
            this.Label2.Location = new System.Drawing.Point(18, 23);
            this.Label2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.Label2.Name = "Label2";
            this.Label2.Size = new System.Drawing.Size(83, 16);
            this.Label2.TabIndex = 2;
            this.Label2.Text = "Medicine ID";
            // 
            // mid
            // 
            this.mid.BackColor = System.Drawing.Color.White;
            this.mid.Location = new System.Drawing.Point(148, 19);
            this.mid.Margin = new System.Windows.Forms.Padding(2);
            this.mid.Name = "mid";
            this.mid.Size = new System.Drawing.Size(135, 20);
            this.mid.TabIndex = 767;
            this.mid.TextChanged += new System.EventHandler(this.mid_TextChanged);
            // 
            // Label3
            // 
            this.Label3.AutoSize = true;
            this.Label3.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Label3.ForeColor = System.Drawing.Color.Black;
            this.Label3.Location = new System.Drawing.Point(18, 60);
            this.Label3.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.Label3.Name = "Label3";
            this.Label3.Size = new System.Drawing.Size(108, 16);
            this.Label3.TabIndex = 5;
            this.Label3.Text = "Scientific Name";
            // 
            // button2
            // 
            this.button2.Font = new System.Drawing.Font("Bookman Old Style", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button2.ForeColor = System.Drawing.SystemColors.ControlText;
            this.button2.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.button2.Location = new System.Drawing.Point(204, 223);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(105, 36);
            this.button2.TabIndex = 38;
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
            this.button1.Location = new System.Drawing.Point(79, 223);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(105, 36);
            this.button1.TabIndex = 37;
            this.button1.Text = "    SAVE";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // medicineLabel
            // 
            this.medicineLabel.AutoSize = true;
            this.medicineLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.medicineLabel.Location = new System.Drawing.Point(103, 36);
            this.medicineLabel.Name = "medicineLabel";
            this.medicineLabel.Size = new System.Drawing.Size(196, 29);
            this.medicineLabel.TabIndex = 39;
            this.medicineLabel.Text = "Add A Medicine";
            // 
            // ex_mid
            // 
            this.ex_mid.AutoSize = true;
            this.ex_mid.Font = new System.Drawing.Font("Arial", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ex_mid.ForeColor = System.Drawing.Color.Maroon;
            this.ex_mid.Location = new System.Drawing.Point(350, 93);
            this.ex_mid.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.ex_mid.Name = "ex_mid";
            this.ex_mid.Size = new System.Drawing.Size(74, 14);
            this.ex_mid.TabIndex = 790;
            this.ex_mid.Text = "Employee ID";
            // 
            // AddMedicine
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(457, 271);
            this.Controls.Add(this.ex_mid);
            this.Controls.Add(this.medicineLabel);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.GroupBox3);
            this.Name = "AddMedicine";
            this.Text = "AddMedicine";
            this.GroupBox3.ResumeLayout(false);
            this.GroupBox3.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        internal System.Windows.Forms.GroupBox GroupBox3;
        internal System.Windows.Forms.Label label4;
        internal System.Windows.Forms.TextBox comname;
        private System.Windows.Forms.TextBox sciname;
        internal System.Windows.Forms.Label Label2;
        internal System.Windows.Forms.TextBox mid;
        internal System.Windows.Forms.Label Label3;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Label medicineLabel;
        internal System.Windows.Forms.Label ex_mid;
    }
}
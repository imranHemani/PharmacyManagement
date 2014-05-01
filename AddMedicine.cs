using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using Oracle.ManagedDataAccess.Client;
using Oracle.ManagedDataAccess.Types;

namespace Pharmacy_Management_System
{
    public partial class AddMedicine : Form
    {
        #region Declarations
        string _connstring = "Data Source=ORCL;User Id = pharmacy;Password=pharmacy;";
        int midValue;
        String SciValue;
        String ComValue;
        #endregion

        public AddMedicine()
        {
            InitializeComponent();
            ex_mid.Hide();
        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void textBox3_TextChanged(object sender, EventArgs e)
        {
            ComValue = comname.Text;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            comname.Clear();
            sciname.Clear();
            mid.Clear();
        }

        private void mid_TextChanged(object sender, EventArgs e)
        {
            try
            {
                ex_mid.Hide();
                midValue = Convert.ToInt32(mid.Text);
            }
            catch
            {
                ex_mid.Show();
                ex_mid.Text = "Invalid Entry";

            } 
        }

        private void sciname_TextChanged(object sender, EventArgs e)
        {
            SciValue = sciname.Text;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                int _recordsAffected;
                OracleConnection _connObj = new OracleConnection(_connstring);
                _connObj.Open();
                //Insert a new record
                OracleCommand _cmdObj = _connObj.CreateCommand();
                _cmdObj.CommandText = "INSERT INTO medicine(m_id,commname,sciname)VALUES(:MID, :COM, :SCI)";
                _cmdObj.Parameters.Add(new OracleParameter("MID", midValue));
                _cmdObj.Parameters.Add(new OracleParameter("COM", ComValue));
                _cmdObj.Parameters.Add(new OracleParameter("SCI", SciValue));
                _recordsAffected = _cmdObj.ExecuteNonQuery();
                MessageBox.Show("Total records affected after insert:" + _recordsAffected);
            }

            catch
            {
                MessageBox.Show("Please retry. Either the value is incorrect or is being duplicated!");
            }
        }
    }
}

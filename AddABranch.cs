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
    public partial class AddABranch : Form
    {
        #region Declarations
        string _connstring = "Data Source=ORCL;User Id = pharmacy;Password=pharmacy;";
        int bnoValue;
        String locValue;
        int pnoValue;
        String mgrValue;
        #endregion

        public AddABranch()
        {
            
            InitializeComponent();
            ex_bno.Hide();
            ex_loc.Hide();
            ex_pno.Hide();
            msg_mgr.Show();
            msg_mgr.Text = "Please Select A Manager";

        }
        private void mgr_TextChanged(object sender, EventArgs e)
        {
            msg_mgr.Text = " ";
        }

        private void txtCode_TextChanged(object sender, EventArgs e)
        {
            try
            {
                ex_bno.Hide();
                bnoValue = Convert.ToInt32(bno.Text);
            }
            catch
            {
                ex_bno.Show();
                ex_bno.Text = "Invalid Entry";

            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            bno.Clear();
            loc.Clear();
            pno.Clear();
            mgr.ResetText();
            
        }

        private void location_TextChanged(object sender, EventArgs e)
        {
            try
            {
                ex_loc.Hide();
                locValue = loc.Text;
            }
            catch
            {
                ex_loc.Show();
                ex_loc.Text = "Invalid Entry";

            }
        }

        private void pno_TextChanged(object sender, EventArgs e)
        {
            try
            {
                ex_pno.Hide();
                pnoValue = Convert.ToInt32(pno.Text);
            }
            catch
            {
                ex_pno.Show();
                ex_pno.Text = "Invalid Entry";

            }
        }

        private void mgr_SelectedIndexChanged(object sender, EventArgs e)
        {

            mgrValue = mgr.Text; 
            
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
                _cmdObj.CommandText = "INSERT INTO branch(bno, mgrid,location,phonenumber)VALUES(:BNO, :MGRID, :LOC, :PNO)";
                _cmdObj.Parameters.Add(new OracleParameter("BNO", bnoValue));
                _cmdObj.Parameters.Add(new OracleParameter("MGRID", mgrValue));
                _cmdObj.Parameters.Add(new OracleParameter("LOC", locValue));
                _cmdObj.Parameters.Add(new OracleParameter("PNO", pnoValue));
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

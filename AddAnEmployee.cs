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
    
    public partial class AddAnEmployee : Form
    {
        #region Declarations
        string _connstring = "Data Source=ORCL;User Id = pharmacy;Password=pharmacy;";
        int empidValue;
        String enameValue;
        String mgrnameValue;
        int bnoValue;
        int salValue;
        decimal inssValue;
        decimal payrollValue;
        DateTime hiredateValue;
        #endregion

        


        public AddAnEmployee()
        {
            InitializeComponent();
            ex_empid.Hide();
            ex_ename.Hide();
            ex_inss.Hide();
            ex_payroll.Hide();
            ex_sal.Hide();
            msg_bno.Show();
            msg_bno.Text = "Please Select A Branch";
            msg_mgr.Show();
            msg_mgr.Text = "Please Select A Manager";

           // string _sql;
            try
            {
                DataSet _ds;
                OracleConnection _connObj = new OracleConnection(_connstring);
                _ds = new DataSet();
                _connObj.Open();

                OracleCommand ShowBNO = new OracleCommand();
                ShowBNO.Connection = _connObj;
                ShowBNO.CommandText = "select bno from branch";
                ShowBNO.CommandType = CommandType.Text;

                OracleDataReader DataRead = ShowBNO.ExecuteReader();

                DataRead.Read();


                while (DataRead.Read())
                {
                    bno.Items.Add(DataRead.GetString(1));
                }

                ShowBNO.Dispose();

                //_sql = "SELECT * FROM branch";
               // OracleDataAdapter _adapterObj = new OracleDataAdapter(_sql, _connObj);
              //  _adapterObj.Fill(_ds);
                _connObj.Close();
                _connObj.Dispose();
                _connObj = null;
                
                bno.DataSource = _ds.Tables[0] ;
                dataGridView1.DataSource = _ds.Tables[0];

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }

        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void branchNo_TextChanged(object sender, EventArgs e)
        {

            try
            {
                ex_empid.Hide();
                empidValue = Convert.ToInt32(empid.Text);
            }
            catch {
                ex_empid.Show();
                ex_empid.Text = "Invalid Entry";
               
            }
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            try
            {
                ex_ename.Hide(); 
                enameValue = ename.Text;
   
            }
            catch
            {
                ex_ename.Show();
                ex_ename.Text = "Invalid Entry";

            } 
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
                _cmdObj.CommandText = "INSERT INTO employees(empid, ename, hiredate, mgrid, bno, salary, inss, payroll)VALUES(:ID, :NAME, :HIREDATE, :MGRID, :BNO, :SAL, :INSS, :PAY)";
                _cmdObj.Parameters.Add(new OracleParameter("ID", empidValue));
                _cmdObj.Parameters.Add(new OracleParameter("NAME", enameValue));
                _cmdObj.Parameters.Add(new OracleParameter("HIREDATE", hiredateValue));
                _cmdObj.Parameters.Add(new OracleParameter("MGRID", mgrnameValue));
                _cmdObj.Parameters.Add(new OracleParameter("BNO", bnoValue));
                _cmdObj.Parameters.Add(new OracleParameter("SAL", salValue));
                _cmdObj.Parameters.Add(new OracleParameter("INSS", inssValue));
                _cmdObj.Parameters.Add(new OracleParameter("PAY", payrollValue));
                _recordsAffected = _cmdObj.ExecuteNonQuery();
                MessageBox.Show("Total records affected after insert:" + _recordsAffected);

            }
            catch
            {
                MessageBox.Show("Please retry. Either the value is incorrect or is being duplicated!");
            }

        }

        private void mgrname_SelectedIndexChanged(object sender, EventArgs e)
        {
            
            mgrnameValue = mgrname.Text;
           
        }

        private void bno_SelectedIndexChanged(object sender, EventArgs e)
        {
            try
            {
                bnoValue = Convert.ToInt32(bno.Text);
            }
            catch
            {
                msg_bno.Text = " ";
            }
        }

        private void sal_TextChanged(object sender, EventArgs e)
        {
            try
            {
                ex_sal.Hide();
                salValue = Convert.ToInt32(sal.Text);
       

            }
            catch
            {
                ex_sal.Show();
                ex_sal.Text = "Invalid Entry";

            }
        }

        private void inss_TextChanged(object sender, EventArgs e)
        {
            try
            {
                ex_inss.Hide();
                inssValue = Convert.ToDecimal(inss.Text);


            }
            catch
            {
                ex_inss.Show();
                ex_inss.Text = "Invalid Entry";

            }
        }

        private void hiredate_ValueChanged(object sender, EventArgs e)
        {

            hiredateValue = Convert.ToDateTime(hiredate.Value.Date);
            

        }

        private void payroll_TextChanged(object sender, EventArgs e)
        {
            try
            {
                ex_payroll.Hide();
                payrollValue = Convert.ToDecimal(payroll.Text);
        

            }
            catch
            {
                ex_payroll.Show();
                ex_payroll.Text = "Invalid Entry";

            } 
            
        }

        private void button2_Click(object sender, EventArgs e)
        {
            empid.Clear();
            ename.Clear();
            mgrname.ResetText();
            bno.ResetText();
            sal.Clear();
            inss.Clear();
            payroll.Clear();
        }

        private void label9_Click(object sender, EventArgs e)
        {
         
        }

        private void mgrname_TextChanged(object sender, EventArgs e)
        {
            msg_mgr.Text = " ";
        }

        private void bno_TextChanged_1(object sender, EventArgs e)
        {
            msg_bno.Text = "";
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}

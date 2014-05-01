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
    public partial class Billing : Form
    {
        public Billing()
        {
            InitializeComponent();
        }

        private void radioButton2_CheckedChanged(object sender, EventArgs e)
        {
            bank.Show();
            bselect.Show();
        }

        private void Billing_Load(object sender, EventArgs e)
        {
            bank.Hide();
            bselect.Hide();
        }

        private void radioButton1_CheckedChanged(object sender, EventArgs e)
        {
            bank.Hide();
            bselect.Hide();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void groupBox3_Enter(object sender, EventArgs e)
        {

        }

        private void dateTimePicker4_ValueChanged(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
           // LotNo.Clear();
           // Quantity.Clear();
           // Price.Clear();

            string _connstring = "Data Source=ORCL;User Id = scott;Password=tiger;";
 //           decimal _totalRecords;
            String name;
            try
            {
            OracleConnection _connObj = new OracleConnection(_connstring);
            _connObj.Open();
            OracleCommand _cmdObj = _connObj.CreateCommand();
//            _cmdObj.CommandText = "SELECT ename from employees where empid = 101";
            _cmdObj.CommandText = "SELECT ename from emp";
 //           _totalRecords = (decimal)_cmdObj.ExecuteScalar();
            name = (String)_cmdObj.ExecuteScalar();
            MessageBox.Show("Total records:" + name);
            textBox1.AppendText("Name: " + name);
            _connObj.Close();
            _connObj.Dispose();
            _connObj = null;
            }
            catch (Exception ex)
            {
            MessageBox.Show(ex.ToString());
            }












        
        
        
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string connection = "Data Source=ORCL; User Id=pharmacy; Password=pharmacy";
            OracleConnection InsertData = new OracleConnection(connection);
            InsertData.Open();

            OracleParameter empno = new OracleParameter();
            empno.OracleDbType = OracleDbType.Int16;
            empno.Value = Quantity.Text;

            OracleParameter deptno = new OracleParameter();
            deptno.OracleDbType = OracleDbType.Int16;
            deptno.Value = Price.Text;

            OracleCommand insertEmpno = new OracleCommand();
            insertEmpno.Connection = InsertData;    
            insertEmpno.Parameters.Add(empno);
            insertEmpno.CommandText = "select ename from employees where empid = 101";

            insertEmpno.CommandType = CommandType.Text;

            OracleDataReader DataRead = insertEmpno.ExecuteReader();

            DataRead.Read();


            while (DataRead.Read())
            {
                listBox1.Items.Add(DataRead.GetString(1));
            }

            InsertData.Dispose();
        }

        private void textBox5_TextChanged(object sender, EventArgs e)
        {

        }

        private void tabPage1_Click(object sender, EventArgs e)
        {

        }

        private void tabPage2_Click(object sender, EventArgs e)
        {

        }

        private void tabPage1_Click_1(object sender, EventArgs e)
        {
            AddMedicine m = new AddMedicine();
            m.Show();
        }

        private void textBox1_TextChanged_1(object sender, EventArgs e)
        {






        }

        private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}

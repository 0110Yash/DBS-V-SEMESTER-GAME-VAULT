using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Oracle.DataAccess.Client;


namespace WindowsFormsApp5
{
    public partial class Form17 : Form
    {
        OracleConnection conn;

        public Form17()
        {
            InitializeComponent();
        }
        public void ConnectDB()
        {
            conn = new OracleConnection("DATA SOURCE=orcl;USER ID=yyaa;PASSWORD=123");

            try
            {
                conn.Open();
                MessageBox.Show("Connected");
            }
            catch (Exception e1)
            {
                // Handle the exception
            }
        }
        private void button1_Click(object sender, EventArgs e)
        {
            string gameid = textBox1.Text;
            string userid = textBox2.Text;
            string completionPer = textBox3.Text;

            ConnectDB(); // Connect to the Oracle database

            OracleCommand cmd = new OracleCommand();
            cmd.Connection = conn;

            // Set the command text to call the add_status_entry procedure
            cmd.CommandText = "add_status_entry";

            // Specify the command type as a stored procedure
            cmd.CommandType = CommandType.StoredProcedure;

            // Add input parameters for the procedure
            cmd.Parameters.Add("p_gameid", OracleDbType.Varchar2).Value = gameid;
            cmd.Parameters.Add("p_userid", OracleDbType.Varchar2).Value = userid;
            cmd.Parameters.Add("p_completion_per", OracleDbType.Varchar2).Value = completionPer;

            try
            {
                // Execute the stored procedure
                cmd.ExecuteNonQuery();
                MessageBox.Show("Status entry added successfully.");
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error adding status entry: " + ex.Message);
            }
            finally
            {
                // Close the database connection
                conn.Close();
            }
        }

        private void Form17_Load(object sender, EventArgs e)
        {

        }
    }
}

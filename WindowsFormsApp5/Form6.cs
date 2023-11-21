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
    public partial class Form6 : Form
    {
        String userid;
        String password;
        String confirmpass;
        String username;
        String email;
        OracleConnection conn;
        public Form6()
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

            }

        }
        private void button1_Click(object sender, EventArgs e)
        {
            userid = textBox1.Text;
            username = textBox2.Text;
            password = textBox3.Text;
            confirmpass = textBox4.Text;
            email = textBox5.Text;

            

            ConnectDB(); // Connect to the Oracle database


            OracleCommand cmd = new OracleCommand();
            cmd.Connection = conn; // Assume conn is your Oracle connection object

            // Set the command text to call the add_new_game function
            cmd.CommandText = "add_sign";

            cmd.CommandType = CommandType.StoredProcedure;


            cmd.Parameters.Add("p_userid", OracleDbType.Varchar2).Value = userid;
            cmd.Parameters.Add("p_username", OracleDbType.Varchar2).Value = username;

            cmd.Parameters.Add("p_password", OracleDbType.Varchar2).Value = password;
            cmd.Parameters.Add("p_email", OracleDbType.Varchar2).Value = email;

            cmd.Parameters.Add("RETURN_VALUE", OracleDbType.Int32).Direction = ParameterDirection.ReturnValue;


            cmd.ExecuteNonQuery();

            MessageBox.Show("Account Created");

            conn.Close();

            Form f1 = new Form1();
            f1.Show();
            this.Hide();
        }

        private void Form6_Load(object sender, EventArgs e)
        {
            
        }
    }
}

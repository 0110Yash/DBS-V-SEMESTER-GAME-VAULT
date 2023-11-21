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
    public partial class Form1 : Form
    {
        OracleConnection conn;
        string Username;
        string Password;
        int c;
        public Form1()
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
        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {



            try
            {
                ConnectDB();
                Username = textBox1.Text;
                Password = textBox2.Text;


                
             OracleCommand cmd= new OracleCommand(); 
                cmd.Connection = conn;
                //cmd.CommandText = "SELECT Validate_User_Credentials('yash','123') FROM DUAL";
                cmd.CommandText = "SELECT Validate_User_Credentials(:p_username, :p_password) FROM DUAL";
                cmd.Parameters.Add("p_username", OracleDbType.Varchar2).Value = Username;
                cmd.Parameters.Add("p_password", OracleDbType.Varchar2).Value = Password;

                //cmd.CommandText = "SELECT email FROM usergame where password='123'";
                cmd.CommandType=CommandType.Text;

                OracleDataReader dr = cmd.ExecuteReader();
                dr.Read();
              //  MessageBox.Show(dr.GetInt32(0).ToString());
                c = dr.GetInt32(0);
                //label1.Text = dr.GetString(0);
                conn.Dispose();


                if(c==1)
                {
                    Form f2 = new Form2();
                    
                    f2.Show();
                    this.Hide();
                }
                else
                {
                    MessageBox.Show("Try Again to login");
                }
                    


                //command1.CommandText = "SELECT Validate_User_Credentials('yash','123') FROM DUAL";
                // command1.Parameters.Add("p_username", OracleDbType.Varchar2).Value = Username;
                // command1.Parameters.Add("p_password", OracleDbType.Varchar2).Value = Password;

                //   command1.CommandType = CommandType.Text;


                //  OracleDataReader dr = command1.ExecuteReader();

                //  dr.Read();

                // MessageBox.Show(dr.GetInt32(0).ToString());

                // conn.Close();

            }
            catch (Exception ex)
            {
                // Handle the exception, e.g., display an error message
                MessageBox.Show("Error: " + ex.Message);
            }
        }

    }




}



using System;
using System.Data;
using System.Windows.Forms;
using Oracle.DataAccess.Client;

namespace WindowsFormsApp5
{
    public partial class Form10 : Form
    {
        String reviewid;
        String gameid;
        String userid;
        String rating;
        String reviewtext;

        OracleConnection conn;

        public Form10()
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


        private void Form10_Load(object sender, EventArgs e)
        {
            // Any additional initialization code can be added here
        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            reviewid = textBox1.Text;
            gameid = textBox2.Text;
            userid = textBox3.Text;
            rating = textBox4.Text;
            reviewtext = textBox5.Text;

            ConnectDB(); // Connect to the Oracle database

            OracleCommand cmd = new OracleCommand();
            cmd.Connection = conn;

            // Set the command text to call the add_new_review procedure
            cmd.CommandText = "add_new_review";

            // Specify the command type as a stored procedure
            cmd.CommandType = CommandType.StoredProcedure;

            // Add input parameters for the procedure
            cmd.Parameters.Add("p_reviewid", OracleDbType.Varchar2).Value = reviewid;
            cmd.Parameters.Add("p_gameid", OracleDbType.Varchar2).Value = gameid;
            cmd.Parameters.Add("p_userid", OracleDbType.Varchar2).Value = userid;
            cmd.Parameters.Add("p_rating", OracleDbType.Varchar2).Value = rating;
            cmd.Parameters.Add("p_reviewtext", OracleDbType.Varchar2).Value = reviewtext;

            try
            {
                // Execute the stored procedure
                cmd.ExecuteNonQuery();
            }
            catch (Exception ex)
            {
                // Handle the exception
            }
            finally
            {
                // Close the database connection
                conn.Close();
            }
        }
    }
}

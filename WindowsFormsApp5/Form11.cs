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
    public partial class Form11 : Form
    {
        OracleConnection conn;

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
        public Form11()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string reviewId = textBox1.Text;

            ConnectDB(); // Connect to the Oracle database

            OracleCommand cmd = new OracleCommand();
            cmd.Connection = conn;

            // Set the command text to call the delete_review procedure
            cmd.CommandText = "delete_review";

            // Specify the command type as a stored procedure
            cmd.CommandType = CommandType.StoredProcedure;

            // Add input parameter for the procedure
            cmd.Parameters.Add("p_reviewid", OracleDbType.Varchar2).Value = reviewId;

            try
            {
                // Execute the stored procedure
                cmd.ExecuteNonQuery();
                MessageBox.Show("Review deleted successfully.");
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error deleting review: " + ex.Message);
            }
            finally
            {
                // Close the database connection
                conn.Close();
            }
        }
    }
    }


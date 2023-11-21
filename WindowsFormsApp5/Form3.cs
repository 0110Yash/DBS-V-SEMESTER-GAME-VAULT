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
using static System.Windows.Forms.VisualStyles.VisualStyleElement.StartPanel;


namespace WindowsFormsApp5
{
    public partial class Form3 : Form
    {
        String title;
        String releaseDateString;
        String developer;
        String publisher;
        String Genreid;
        String platform;
        String gameid;

        String userid;

        OracleConnection conn;
        public Form3(string useridd)
        {
            userid = useridd;
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
            gameid= textBox7.Text;
            title = textBox1.Text;
            releaseDateString = textBox2.Text;
            developer = textBox3.Text;
            publisher = textBox4.Text;
            Genreid = textBox5.Text;
            platform = textBox6.Text;

            ConnectDB(); // Connect to the Oracle database
           

            OracleCommand cmd = new OracleCommand();
            cmd.Connection = conn; // Assume conn is your Oracle connection object

            // Set the command text to call the add_new_game function
            cmd.CommandText = "add_new_game";

            // Specify the command type as a stored procedure
            cmd.CommandType = CommandType.StoredProcedure;

            // Add input parameters for the function
            cmd.Parameters.Add("p_userid", OracleDbType.Varchar2).Value = userid;
            cmd.Parameters.Add("p_gameid", OracleDbType.Varchar2).Value = gameid;

            cmd.Parameters.Add("p_title", OracleDbType.Varchar2).Value = title;
            cmd.Parameters.Add("p_release_date", OracleDbType.Varchar2).Value = releaseDateString;
            cmd.Parameters.Add("p_developer", OracleDbType.Varchar2).Value = developer;
            cmd.Parameters.Add("p_publisher", OracleDbType.Varchar2).Value = publisher;
            cmd.Parameters.Add("p_genre_id", OracleDbType.Varchar2).Value = Genreid;
            cmd.Parameters.Add("p_platform", OracleDbType.Varchar2).Value = platform;

            // Add an output parameter to capture the return value
            cmd.Parameters.Add("RETURN_VALUE", OracleDbType.Int32).Direction = ParameterDirection.ReturnValue;

            // Execute the stored procedure
          cmd.ExecuteNonQuery();

            // Assuming you have the OracleDecimal as returnValue
          ///  OracleDecimal oracleDecimal = (OracleDecimal)cmd.Parameters["RETURN_VALUE"].Value;

            // Convert it to a .NET numeric type (e.g., int)
          //  int returnValue = oracleDecimal.ToInt32();
            //int returnValue = Convert.ToInt32(cmd.Parameters["RETURN_VALUE"].Value);

            // Close the database connection
            conn.Close();


        }

        private void Form3_Load(object sender, EventArgs e)
        {

        }
    }
}

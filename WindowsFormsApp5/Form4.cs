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
using Oracle.ManagedDataAccess.Types;

namespace WindowsFormsApp5
{


    public partial class Form4 : Form
    {
        OracleConnection conn;
        String gameid;

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
        public Form4()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {

            ConnectDB();
            gameid = textBox1.Text;
            OracleCommand cmd = new OracleCommand();
           
                    cmd.Connection = conn;
                    cmd.CommandType = CommandType.Text;

                    
                    string plsqlBlock = $@"
                

                DECLARE
                    v_deleted_count NUMBER;
                BEGIN
                   

                    v_deleted_count := delete_game('{gameid}');
                END;
            ";

                    cmd.CommandText = plsqlBlock;

                    cmd.ExecuteNonQuery();
            conn.Close();
            
        }

    }
}

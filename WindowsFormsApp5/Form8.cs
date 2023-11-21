using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;
using Oracle.DataAccess.Client;

namespace WindowsFormsApp5
{
    public partial class Form8 : Form
    {
        public Form8()
        {
            InitializeComponent();
        }

        private void Form8_Load(object sender, EventArgs e)
        {
            OracleDataAdapter da = new OracleDataAdapter("SELECT * FROM game", "DATA SOURCE=orcl;USER ID=yyaa;PASSWORD=123");
            DataSet ds = new DataSet();
            da.Fill(ds, "game");
            dataGridView1.DataSource = ds.Tables["game"].DefaultView;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Form f2 = new Form2();
            f2.Show();
            this.Hide();
        }
    }
}

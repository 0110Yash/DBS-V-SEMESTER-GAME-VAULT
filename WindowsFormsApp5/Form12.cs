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
    public partial class Form12 : Form
    {
        public Form12()
        {
            InitializeComponent();
        }

        private void Form12_Load(object sender, EventArgs e)
        {
            OracleDataAdapter da = new OracleDataAdapter("SELECT * FROM REVIEW", "DATA SOURCE=orcl;USER ID=yyaa;PASSWORD=123");
            DataSet ds = new DataSet();
            da.Fill(ds, "REVIEW");
            dataGridView1.DataSource = ds.Tables["REVIEW"].DefaultView;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Form f2 = new Form2();
            f2.Show();
            this.Hide();
        }
    }
}

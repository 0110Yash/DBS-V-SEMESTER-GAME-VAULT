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
    public partial class Form15 : Form
    {
        public Form15()
        {
            InitializeComponent();
        }

        private void Form15_Load(object sender, EventArgs e)
        {
            OracleDataAdapter da = new OracleDataAdapter("SELECT * FROM RANKING", "DATA SOURCE=orcl;USER ID=yyaa;PASSWORD=123");
            DataSet ds = new DataSet();
            da.Fill(ds, "RANKING");
            dataGridView1.DataSource = ds.Tables["RANKING"].DefaultView;
        }
    }
}

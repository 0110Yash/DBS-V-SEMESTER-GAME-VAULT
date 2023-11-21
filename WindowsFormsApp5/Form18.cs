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
    public partial class Form18 : Form
    {
        public Form18()
        {
            InitializeComponent();
        }

        private void Form18_Load(object sender, EventArgs e)
        {
            OracleDataAdapter da = new OracleDataAdapter("SELECT * FROM STATUS", "DATA SOURCE=orcl;USER ID=yyaa;PASSWORD=123");
            DataSet ds = new DataSet();
            da.Fill(ds, "STATUS");
            dataGridView1.DataSource = ds.Tables["STATUS"].DefaultView;
        }
    }
}

using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp5
{
    public partial class Form13 : Form
    {
        public Form13()
        {
            InitializeComponent();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Form f14 = new Form14();
            f14.Show();
            this.Hide();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Form f15 = new Form15();
            f15.Show();
            this.Hide();    
        }
    }
}

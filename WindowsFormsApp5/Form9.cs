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
    public partial class Form9 : Form
    {
        public Form9()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Form10 f10 = new Form10();
            f10.Show();
            this.Hide();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Form F11= new Form11();
            F11.Show(); 
            this.Hide();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            Form F12 = new Form12();
            F12.Show();
            this.Hide();
        }
    }
}

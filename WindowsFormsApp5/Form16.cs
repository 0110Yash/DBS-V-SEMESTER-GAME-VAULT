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
    public partial class Form16 : Form
    {
        public Form16()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Form F17 = new Form17();
            F17.Show();
            this.Hide();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Form F18 = new Form18();
            F18.Show();
            this.Hide();
        }
    }
}

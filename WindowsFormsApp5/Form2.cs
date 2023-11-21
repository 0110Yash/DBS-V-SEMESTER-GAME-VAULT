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
    public partial class Form2 : Form
    {
        String NName;
        public Form2(string name)
        {
            InitializeComponent();
            NName = name;
        }

        private void Form2_Load(object sender, EventArgs e)
        {
            // Define the new size for label2
            int newWidth = label2.Width + 50; // Change 50 to your desired width increase
            int newHeight = label2.Height + 20; // Change 20 to your desired height increase

            // Set the new size for label2
            label2.Size = new Size(newWidth, newHeight);

            label2.Text = NName;
        }


        private void label2_Click(object sender, EventArgs e)
        {
            
        }

        private void label2_Click_1(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            Form f3= new Form3(NName);
            
            f3.Show();
            this.Hide();

        }

        private void button2_Click(object sender, EventArgs e)
        {
            Form f8 = new Form8();

            f8.Show();
            this.Hide();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            Form f4 = new Form4();
          
            f4.Show();
            this.Hide();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            Form f9 = new Form9();
            f9.Show();
            this.Hide();
        }
    }
}

using System;
using System.Windows.Forms;

namespace CSharp101._1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            MessageBox.Show("You clicked", "Click");
        }

        private void button2_MouseHover(object sender, EventArgs e)
        {
            MessageBox.Show("You stay hover", "Stay Hover");
        }
    }
}

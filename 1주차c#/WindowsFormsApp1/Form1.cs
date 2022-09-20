using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            int i, iSuteja;
            Double dsum = 0;

            iSuteja = int.Parse(textBox2.Text);

            textBox2.Text = "";
            textBox1.Text = "";

            for (i = 1; i <= iSuteja; ++i)
            {
                dsum = dsum + i;
                textBox1.Text = textBox1.Text + i + " + ";
            
            }
            textBox1.Text = textBox1.Text + " = " + dsum;  /*
            for (i = 1; i <= iSuteja; ++i)
            {
                dsum = dsum + i;
                textBox2.Text = textBox2.Text + i + " + ";

            }
            textBox2.Text = textBox2.Text + " = " + dsum;  */
        }
    }
}

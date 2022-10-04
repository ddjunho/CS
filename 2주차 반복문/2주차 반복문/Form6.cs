using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _2주차_반복문
{
    public partial class Form6 : Form
    {
        public Form6()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            textBox1.Text = "";
            for (int i = 1; i < 10; i++)
            {
                for (int j = 1; j < 10; j++)
                    textBox1.Text = textBox1.Text+ i + "X" + j + "=" + (j * i) + "\r\n";
                textBox1.Text = textBox1.Text + "\r\n";
            }
        }
    }
}

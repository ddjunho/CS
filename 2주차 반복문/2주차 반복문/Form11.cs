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
    public partial class Form11 : Form
    {
        public Form11()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            textBox1.Text = "";
            for (int i = 1; i < 10; i+=3)
            {
                for (int j = 1; j < 10; j++) { 
                    for (int n = 0; n < 3; n++)
                    {
                        textBox1.Text = textBox1.Text + (i+n) + "X" + j + "=" + (j * (i+n)) + "    ";//3개출력
                    }
                    textBox1.Text = textBox1.Text + "\r\n";// j 값추가후 반복
                }
                textBox1.Text = textBox1.Text + "\r\n";// i 값추가후 반복
            }
        }
    }
}

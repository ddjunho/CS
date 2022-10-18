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
    public partial class Form22 : Form
    {
        public Form22()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            textBox1.Text = "";
            for (int i = 8; i > 0; i -= 2)
            {
                for (int j = 1; j < 10; j++)
                {
                    for (int n = 0; n < 2; n++)
                    {
                        textBox1.Text = textBox1.Text + (i + n) + "X" + j + "=" + (j * (i + n)) + "    ";//3개출력
                    }
                    textBox1.Text = textBox1.Text + "\r\n";// j 값추가후 반복
                }
                textBox1.Text = textBox1.Text + "\r\n";// i 값추가후 반복
            }
        }
    }
}

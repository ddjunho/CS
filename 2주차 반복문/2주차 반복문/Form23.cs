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
    public partial class Form23 : Form
    {
        public Form23()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            uint i = 8;
            uint j = 1;
            uint n = 0;
            textBox1.Text = "";
            while (i > 0)
            {
                while (j < 10)
                {
                    while (n < 2)
                    {
                        textBox1.Text = textBox1.Text + (i + n) + "X" + j + "=" + (j * (i + n)) + "    ";//3개출력
                        n++;
                    }
                    n = 0;
                    textBox1.Text = textBox1.Text + "\r\n";// j 값추가후 반복
                    j++;
                }
                j = 1;
                textBox1.Text = textBox1.Text + "\r\n";// i 값추가후 반복
                i -= 2;
            }
        }
    }
}

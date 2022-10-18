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
    public partial class Form19 : Form
    {
        public Form19()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            uint i = 2;
            uint j = 1;
            uint n = 0;
            textBox1.Text = "";
            while (true)
            {
                while (true)
                {
                    while (true)
                    {
                        textBox1.Text = textBox1.Text + (i + n) + "X" + j + "=" + (j * (i + n)) + "    ";//3개출력
                        n++;
                        if (n >= 4) break;
                    }
                    n = 0;
                    j++;
                    textBox1.Text = textBox1.Text + "\r\n";// j 값추가후 반복
                    if (j >= 10) break;
                }
                j = 1;
                i += 4;
                textBox1.Text = textBox1.Text + "\r\n";// i 값추가후 반복
                if (i >= 10) break;
            }
        }
    }
}

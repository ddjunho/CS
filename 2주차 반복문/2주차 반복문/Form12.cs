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
    public partial class Form12 : Form
    {
        public Form12()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            uint iDan = 1;
            uint i = 1;
            int n = 0;
            textBox1.Text = "";
            while (iDan < 10)
            {
                while (i < 10)
                {
                    while (n < 3)
                    {
                        textBox1.Text = textBox1.Text + (iDan+n) + "X" + i + "=" + ((iDan+n) * i) + "   ";
                        n++;//1,2,3 열
                    }
                    n = 0;
                    i++;//1~9
                    textBox1.Text = textBox1.Text + "\r\n";
                }
                
                iDan+=3;//다음줄
                i = 1;
                textBox1.Text = textBox1.Text + Environment.NewLine;
            }
        }
    }
}

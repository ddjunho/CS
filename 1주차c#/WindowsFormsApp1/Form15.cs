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
    public partial class Form15 : Form
    {
        public Form15()
        {
            InitializeComponent();
        }
        
        private void button1_Click(object sender, EventArgs e)
        {
            int istart, iSuteja;
            Double dsum = 0;

            istart = int.Parse(textBox1.Text);
            iSuteja = int.Parse(textBox2.Text);
            textBox3.Text = "";

            for (int i = istart; i<= iSuteja; ++i)
            {
                if (i % 2 == 1)
                {
                    dsum = dsum + i;
                    textBox3.Text = textBox3.Text + i + " + ";
                }
            }
            textBox3.Text = textBox3.Text.Substring(0, textBox3.TextLength - 3) + " = " + dsum;//for문 끝나고 텍스트 총 길이에서 뒤에서 3글자 지우기
        }

        private void button2_Click(object sender, EventArgs e)
        {
            int istart, iSuteja;
            Double dsum = 0;

            istart = int.Parse(textBox1.Text);
            iSuteja = int.Parse(textBox2.Text);
            textBox3.Text = "";

            for (int i = istart; i <= iSuteja; ++i)
            {
                if (i % 2 == 0)
                {
                    dsum = dsum + i;
                    textBox3.Text = textBox3.Text + i + " + ";
                };
            }
            textBox3.Text = textBox3.Text.Substring(0, textBox3.TextLength - 3) + " = " + dsum;
        }

        private void button3_Click(object sender, EventArgs e)
        {
            int istart, iSuteja;
            Double dsum = 0;

            istart = int.Parse(textBox1.Text);
            iSuteja = int.Parse(textBox2.Text);
            textBox3.Text = "";

            for (int i = istart; i <= iSuteja; ++i)
            {
                dsum = dsum + i;
                textBox3.Text = textBox3.Text + i + " + ";
            }
            textBox3.Text = textBox3.Text.Substring(0, textBox3.TextLength - 3) + " = " + dsum;
        }
    }
}

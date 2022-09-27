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
    public partial class Form11 : Form
    {
        public Form11()
        {
            InitializeComponent();
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            //Substring 마지막 +표시 지우기
            int i, iSuteja;
            Double dsum = 0, dsum1 = 0, dsum2 = 0;

            iSuteja = int.Parse(textBox1.Text);

            textBox2.Text = "";
            textBox3.Text = "";
            textBox4.Text = "";

            for (i = 1; i <= iSuteja; ++i)
            {
                if (i%3==0) 
                {
                    dsum = dsum + i;
                    textBox2.Text = textBox2.Text + i + " + ";
                }
                else if (i % 3 == 1) 
                {
                    dsum1 = dsum1 + i;
                    textBox3.Text = textBox3.Text + i + " + ";
                }
                else if (i % 3 == 2) 
                {
                    dsum2 = dsum2 + i;
                    textBox4.Text = textBox4.Text + i + " + ";
                }

            }
            textBox2.Text = textBox2.Text.Substring(0, textBox2.TextLength - 3) + " = " + dsum;//for문 끝나고 텍스트 총 길이에서 뒤에서 3글자 지우기
            //textBox2.Text = textBox2.Text + " = " + dsum;
            textBox3.Text = textBox3.Text.Substring(0, textBox3.TextLength - 3) + " = " + dsum1;//for문 끝나고 텍스트 총 길이에서 뒤에서 3글자 지우기
            //textBox3.Text = textBox3.Text + " = " + dsum1;
            textBox4.Text = textBox4.Text.Substring(0, textBox4.TextLength - 3) + " = " + dsum2;
        }

        private void label3_Click(object sender, EventArgs e)
        {

        }
    }
}

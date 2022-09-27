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
    public partial class Form8 : Form
    {
        public Form8()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {

            //Substring 마지막 +표시 지우기
            int i, iSuteja;
            Double dsum_even = 0, dsum_odd = 0;

            iSuteja = int.Parse(textBox1.Text);

            textBox2.Text = "";
            textBox3.Text = "";

            for (i = iSuteja; i >= 1; --i) //(i = 1; i <= iSuteja; ++i)
            {
                if (i % 2 == 0 && i != 0) //짝수 임
                {
                    dsum_odd = dsum_odd + i;
                    textBox3.Text = textBox3.Text + i + " + ";
                }
                else if (i % 2 == 1) // 홀수임
                {
                    dsum_even = dsum_even + i;
                    textBox2.Text = textBox2.Text + i + " + ";
                }

            }
            textBox2.Text = dsum_odd + " = " + textBox2.Text.Substring(0, textBox2.TextLength - 3);//for문 끝나고 텍스트 총 길이에서 뒤에서 3글자 지우기
            //textBox2.Text = textBox2.Text + " = " + dsum;
            textBox3.Text = dsum_even + " = " + textBox3.Text.Substring(0, textBox3.TextLength - 3);//for문 끝나고 텍스트 총 길이에서 뒤에서 3글자 지우기
            //textBox3.Text = textBox3.Text + " = " + dsum1;

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void textBox3_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }
    }
}

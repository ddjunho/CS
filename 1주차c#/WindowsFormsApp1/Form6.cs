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
    public partial class Form6 : Form
    {
        public Form6()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            //Substring 마지막 +표시 지우기
            int i, iSuteja;
            Double dsum = 0;

            iSuteja = int.Parse(textBox1.Text);

            textBox2.Text = "";

            for (i = iSuteja; i >= 1; --i)
            {
                dsum = dsum + i;
                textBox2.Text = textBox2.Text + i + " + ";
            }
            textBox2.Text = textBox2.Text.Substring(0, textBox2.TextLength - 3);//for문 끝나고 텍스트 총 길이에서 검색된(0) 3글자 지우기
            textBox2.Text =  dsum + "ㅎㅎ"+ " = " + textBox2.Text;
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

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
    public partial class Form4 : Form
    {
        public Form4()
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

            for (i = 1; i <= iSuteja; ++i)
            {
                dsum = dsum + i;
                textBox2.Text = textBox2.Text + i + " + ";
            }
            textBox2.Text = textBox2.Text.Substring(0, textBox2.TextLength - 3);//for문 끝나고 텍스트 총 길이에서 뒤에서 3글자 지우기
            textBox2.Text = textBox2.Text + " = " + dsum + "ㅎㅎ";
        }
    }
}

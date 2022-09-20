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
    public partial class Form3 : Form
    {
        public Form3()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {//if 문을 사용해서 마지막 +표시 지우기

            int i, iSuteja;
            Double dsum = 0;

            iSuteja = int.Parse(textBox1.Text);

            textBox2.Text = "";

            for (i = 1; i <= iSuteja; ++i)
            {
                dsum = dsum + i;
                if (i < iSuteja)
                    textBox2.Text = textBox2.Text + i + " + ";//한줄일떄는 굳이 대괄호를 쓸 필요없다
                else 
                    textBox2.Text = textBox2.Text + i + " = " + dsum;
            }
            //textBox2.Text = textBox2.Text + " = " + dsum + "  완성하니재미있어요ㅎㅎ";
        }
    }
}

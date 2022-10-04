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
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if(textBox1.Text == "")
            {
                MessageBox.Show("textbox1에 단 입력하라", "경고1");
                textBox1.Focus();
                goto Exit;
            }
            uint iDan = uint.Parse(textBox1.Text);
            uint i = 1;
            textBox2.Text = "";

            while (i < 10)
            {
                textBox2.Text = textBox2.Text + iDan + "X" + i + "=" + (iDan * i) + "\r\n";
                i++;
            }
        Exit:;
        }
    }
}

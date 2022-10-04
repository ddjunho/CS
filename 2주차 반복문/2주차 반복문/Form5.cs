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
    public partial class Form5 : Form
    {
        public Form5()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (textBox1.Text == "")
            {
                MessageBox.Show("textbox1에 단 입력하라", "경고1");
                textBox1.Focus();
                goto Exit;
            }
            uint iDan = uint.Parse(textBox1.Text);
            uint[] i = { 1, 2, 3, 4, 5, 6, 7, 8, 9 };
            textBox2.Text = "";

            foreach (uint dd in i)
            {
                textBox2.Text = textBox2.Text + iDan + " X " + dd + " = " + (iDan * dd) + "\r\n";
            }
        Exit:;
        }
    }
}

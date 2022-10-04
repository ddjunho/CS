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
    public partial class Form7 : Form
    {
        public Form7()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            uint iDan = 1;
            uint i = 1;
            textBox1.Text = "";
            while (iDan < 10)
            {
                while (i < 10)
                {
                    textBox1.Text = textBox1.Text + iDan + "X" + i + "=" + (iDan * i) + "\r\n";
                    i++;
                }
                i = 1;
                iDan++;
                textBox1.Text = textBox1.Text  + Environment.NewLine;
            }
        }
    }
}

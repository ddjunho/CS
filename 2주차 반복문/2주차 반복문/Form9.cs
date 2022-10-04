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
    public partial class Form9 : Form
    {
        public Form9()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            uint iDan = 1;
            uint i = 1;
            textBox1.Text = "";
            while (true)
            {
                while (true)
                {
                    textBox1.Text = textBox1.Text + iDan + "X" + i + "=" + (iDan * i) + "\r\n";
                    i++;
                    if (i > 9)
                        break;
                }
                textBox1.Text = textBox1.Text + "\r\n";
                i = 1;
                iDan++;
                if (iDan > 9)
                    break;
            }
        }
    }
}

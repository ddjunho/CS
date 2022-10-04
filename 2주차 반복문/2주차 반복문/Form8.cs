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
    public partial class Form8 : Form
    {
        public Form8()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            uint iDan = 1;
            uint i = 1;
            textBox1.Text = "";
            do
            {
                do
                {
                    textBox1.Text = textBox1.Text + iDan + "X" + i + "=" + (iDan * i) + "\r\n";
                    i++;
                } while (i < 10);
                i = 1;
                iDan++;
                textBox1.Text = textBox1.Text + Environment.NewLine;
            } while (iDan < 10);
        }
    }
}

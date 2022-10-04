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
    public partial class Form10 : Form
    {
        public Form10()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            uint[] iDan = { 1, 2, 3, 4, 5, 6, 7, 8, 9 };
            uint[] i = { 1, 2, 3, 4, 5, 6, 7, 8, 9 };
            textBox1.Text = "";
            foreach (uint ff in iDan)
            {
                foreach (uint dd in i)
                {
                    textBox1.Text = textBox1.Text + ff + " X " + dd + " = " + (ff * dd) + "\r\n";
                }
                textBox1.Text = textBox1.Text + "\r\n";
            }
        }
    }
}

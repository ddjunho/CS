﻿using System;
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
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            int iDan = int.Parse(textBox1.Text);

            textBox2.Text = "";
            for (int i = 1; i < 10; i++)
                textBox2.Text = textBox2.Text + iDan + "X" + i + "=" + (iDan * i) + "\r\n";
            
        }
    }
}

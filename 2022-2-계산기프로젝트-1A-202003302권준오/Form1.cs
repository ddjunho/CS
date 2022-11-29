using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _2022_2_계산기프로젝트_1A_202003302권준오
{
    public partial class Form1 : Form
    {
        double dSutja_Stored = 0;//숫자를 잠시 저장하기 위한 변수
        string sOperation_Stored = "";//연산자를 잠시 저장하기 위한 변수
        Boolean bClear_Flag = false;//true:한번지우고 숫자표시, False : 그냥 표시
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (bClear_Flag == true)
            {
                textBox1.Text = "";
                bClear_Flag = false;
            }
            textBox1.AppendText("1");
        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (bClear_Flag == true)
            {
                textBox1.Text = "";
                bClear_Flag = false;
            }
            textBox1.Text = textBox1.Text+"2";
        }

        private void button3_Click(object sender, EventArgs e)
        {
            if (bClear_Flag == true)
            {
                textBox1.Text = "";
                bClear_Flag = false;
            }
            textBox1.AppendText("3");
        }

        private void button4_Click(object sender, EventArgs e)
        {
            if (bClear_Flag == true)
            {
                textBox1.Text = "";
                bClear_Flag = false;
            }
            textBox1.AppendText("4");
        }

        private void button5_Click(object sender, EventArgs e)
        {
            if (bClear_Flag == true)
            {
                textBox1.Text = "";
                bClear_Flag = false;
            }
            textBox1.AppendText("5");
        }

        private void button6_Click(object sender, EventArgs e)
        {
            if (bClear_Flag == true)
            {
                textBox1.Text = "";
                bClear_Flag = false;
            }
            textBox1.AppendText("6");
        }

        private void button7_Click(object sender, EventArgs e)
        {
            if (bClear_Flag == true)
            {
                textBox1.Text = "";
                bClear_Flag = false;
            }
            textBox1.AppendText("7");
        }

        private void button8_Click(object sender, EventArgs e)
        {
            if (bClear_Flag == true)
            {
                textBox1.Text = "";
                bClear_Flag = false;
            }
            textBox1.AppendText("8");
        }

        private void button9_Click(object sender, EventArgs e)
        {
            if (bClear_Flag == true)
            {
                textBox1.Text = "";
                bClear_Flag = false;
            }
            textBox1.AppendText("9");
        }

        private void button10_Click(object sender, EventArgs e)
        {
            if (bClear_Flag == true)
            {
                textBox1.Text = "";
                bClear_Flag = false;
            }
            if (textBox1.Text != "")
                textBox1.AppendText("0");
        }

        private void button11_Click(object sender, EventArgs e)
        {
            if (bClear_Flag == true)
            {
                textBox1.Text = "";
                bClear_Flag = false;
            }
            if (textBox1.Text != "")
                textBox1.AppendText("000");
        }
        Boolean bJjeom_Flag = false;//true:점찍힘, false:점찍기전
        private void button12_Click(object sender, EventArgs e)
        {
            if (bJjeom_Flag == false) 
            {
                if (textBox1.Text == "")
                {
                    textBox1.Text = "0";
                }
                textBox1.AppendText(".");
                bJjeom_Flag = true;
            }
        }

        private void button13_Click(object sender, EventArgs e)
        {
            textBox1.Text = "";
            bJjeom_Flag = false;
            dSutja_Stored = 0;
            sOperation_Stored = "";
            bJjeom_Flag = false;

        }

        private void button14_Click(object sender, EventArgs e)
        {
            if (textBox1.Text != "")
            {
                if (textBox1.Text.Substring(textBox1.TextLength - 1) == ".")
                {
                    bJjeom_Flag = false;
                }
                if (textBox1.Text == "0.")
                {
                    textBox1.Text = textBox1.Text.Remove(textBox1.TextLength - 1);
                }
                textBox1.Text = textBox1.Text.Remove(textBox1.TextLength - 1); //Substring
            }
        }
         public void Operation()
        {
            if (sOperation_Stored == "+")
                textBox1.Text = (dSutja_Stored + double.Parse(textBox1.Text)).ToString();
            if (sOperation_Stored == "-")
                textBox1.Text = (dSutja_Stored - double.Parse(textBox1.Text)).ToString();
            if (sOperation_Stored == "x")
                textBox1.Text = (dSutja_Stored * double.Parse(textBox1.Text)).ToString();
            if (sOperation_Stored == "/")
                textBox1.Text = (dSutja_Stored / double.Parse(textBox1.Text)).ToString();
            if (sOperation_Stored == "^")
                textBox1.Text = Math.Pow(dSutja_Stored, double.Parse(textBox1.Text)).ToString();
            if (sOperation_Stored == "%")
                textBox1.Text = (dSutja_Stored % double.Parse(textBox1.Text)).ToString();
        }

        private void button15_Click(object sender, EventArgs e)
        {
            if (textBox1.Text == "") {
                goto Exit; }
            if (sOperation_Stored != "") {
                Operation();
            }
            dSutja_Stored = double.Parse(textBox1.Text);
            sOperation_Stored = "+";
            bJjeom_Flag = false;
            bClear_Flag = true;
        Exit:;
        }

        private void button16_Click(object sender, EventArgs e)
        {
            if (textBox1.Text == "")
            {
                goto Exit;
            }
            if (sOperation_Stored != "")
            {
                Operation();
            }
            dSutja_Stored = double.Parse(textBox1.Text);
            sOperation_Stored = "-";
            bJjeom_Flag = false;
            bClear_Flag = true;
        Exit:;
        }

        private void button17_Click(object sender, EventArgs e)
        {
            if (textBox1.Text == "")
            {
                goto Exit;
            }
            if (sOperation_Stored != "")
            {
                Operation();
            }
            dSutja_Stored = double.Parse(textBox1.Text);
            sOperation_Stored = "x";
            bJjeom_Flag = false;
            bClear_Flag = true;
        Exit:;
        }

        private void button18_Click(object sender, EventArgs e)
        {
            if (textBox1.Text == "")
            {
                goto Exit;
            }
            if (sOperation_Stored != "")
            {
                Operation();
            }
            dSutja_Stored = double.Parse(textBox1.Text);
            sOperation_Stored = "/";
            bJjeom_Flag = false;
            bClear_Flag = true;
        Exit:;
        }
        private void button19_Click(object sender, EventArgs e)
        {
            if (textBox1.Text == "")
            {
                goto Exit;
            }
            if (sOperation_Stored != "")
            {
                Operation();
            }
            bJjeom_Flag = false;
            bClear_Flag = true;
            dSutja_Stored = 0;
            sOperation_Stored = "";
        Exit:;
        }

        private void button20_Click(object sender, EventArgs e)
        { //1/x
            if (textBox1.Text != "")
            {
            textBox1.Text = (1 / double.Parse(textBox1.Text)).ToString();
            bJjeom_Flag = false;
            bClear_Flag = true;
            dSutja_Stored = 0;
            sOperation_Stored = "";
            }
        }

        private void button21_Click(object sender, EventArgs e)
        {//x^
            if (textBox1.Text != "")
            {
                //double x = double.Parse(textBox1.Text);
                //textBox1.Text = (x*x).ToString();
                textBox1.Text = Math.Pow(double.Parse(textBox1.Text),2).ToString();
                bJjeom_Flag = false;
                bClear_Flag = true;
                dSutja_Stored = 0;
                sOperation_Stored = "";
            }
        }

        private void button22_Click(object sender, EventArgs e)
        {//+/-
            /*if (textBox1.Text != "")
            {
                if (double.Parse(textBox1.Text) == 0)
                    textBox1.Text = textBox1.Text;
                else if (double.Parse(textBox1.Text)>0)
                    textBox1.Text = "-"+ textBox1.Text;
                else if (double.Parse(textBox1.Text) < 0)
                    textBox1.Text = textBox1.Text.Substring(1, textBox1.TextLength -1);
            }*/

            textBox1.Text = (-(double.Parse(textBox1.Text))).ToString();
            
        }
        public double Factorial(double n)
        {//재귀함수:Recursive
            if (n == 1)
                return 1;
            else
                return Factorial(n - 1) * n;
        }
        private void button31_Click(object sender, EventArgs e)
        {//n!
            if (textBox1.Text != "")
            {
                double dFac, dSum = 1;
                dFac = double.Parse(textBox1.Text);
                /*for (int i = 1; i <= dFac; i++)
                    dSum = dSum * i;*/
                /*for (double i = dFac; i >= 1; i--)
                    dSum = dSum * i;
                textBox1.Text = dSum.ToString();*/
                textBox1.Text = Factorial(double.Parse(textBox1.Text)).ToString();
                
                bJjeom_Flag = false;
                bClear_Flag = true;
                dSutja_Stored = 0;
                sOperation_Stored = "";
            }
        }

        private void 공학계산기ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            groupBox1.Show();
            this.Text = "공학 계산기";
            this.Width = 765;
            this.Height = 430;
            textBox1.Width = 725;
            일반계산기ToolStripMenuItem.Checked = false;
            공학계산기ToolStripMenuItem.Checked = true;
            label1.Text = "This Calculator is maded by K.J.O in Dept. Software Engineering of Seoil University!";
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {
            groupBox1.Hide();
            this.Text = "일반 계산기";
            this.Width = 520;
            this.Height = 430;
            textBox1.Width = 480;
            일반계산기ToolStripMenuItem.Checked = true;
            공학계산기ToolStripMenuItem.Checked = false;


        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {
             
        }

        private void 종료ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Dispose();
        }

        private void 일반계산기ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            groupBox1.Hide();
            this.Text = "일반 계산기";
            this.Width = 520;
            this.Height = 430;
            textBox1.Width = 480;
            일반계산기ToolStripMenuItem.Checked = true;
            공학계산기ToolStripMenuItem.Checked = false;
            label1.Text = "By K.J.O in Dept. Software Engineering of Seoil University!";
        }

        private void button30_Click(object sender, EventArgs e)
        {//x^3
            if (textBox1.Text != "")
            {
                //double x = double.Parse(textBox1.Text);
                //textBox1.Text = (x*x).ToString();
                textBox1.Text = Math.Pow(double.Parse(textBox1.Text), 3).ToString();
                bJjeom_Flag = false;
                bClear_Flag = true;
                dSutja_Stored = 0;
                sOperation_Stored = "";
            }
        }

        private void button29_Click(object sender, EventArgs e)
        {//\x\
            if (textBox1.Text != "")
            {
                textBox1.Text = Math.Abs(double.Parse(textBox1.Text)).ToString();

                bJjeom_Flag = false;
                bClear_Flag = true;
                dSutja_Stored = 0;
                sOperation_Stored = "";

            }
        }

        private void button28_Click(object sender, EventArgs e)
        {//sin
            if (textBox1.Text != "")
            {
                textBox1.Text = Math.Sin(double.Parse(textBox1.Text)*Math.PI/180).ToString(); 
                
                bJjeom_Flag = false;
                bClear_Flag = true;
                dSutja_Stored = 0;
                sOperation_Stored = "";

            }
        }

        private void button27_Click(object sender, EventArgs e)
        {//x^y
            if (textBox1.Text == "")
            {
                goto Exit;
            }
            if (sOperation_Stored != "")
            {
                Operation();
            }
            dSutja_Stored = double.Parse(textBox1.Text);
            sOperation_Stored = "^";
            bJjeom_Flag = false;
            bClear_Flag = true;
        Exit:;
        }

        private void button23_Click(object sender, EventArgs e)
        {//1/\x\
            if (textBox1.Text != "")
            {
                textBox1.Text = (1/Math.Abs(double.Parse(textBox1.Text))).ToString();

                bJjeom_Flag = false;
                bClear_Flag = true;
                dSutja_Stored = 0;
                sOperation_Stored = "";

            }
        }

        private void button26_Click(object sender, EventArgs e)
        {//cos
            if (textBox1.Text != "")
            {
                textBox1.Text = Math.Cos(double.Parse(textBox1.Text) * Math.PI / 180).ToString();

                bJjeom_Flag = false;
                bClear_Flag = true;
                dSutja_Stored = 0;
                sOperation_Stored = "";

            }
        }

        private void button25_Click(object sender, EventArgs e)
        {//10^x
            if (textBox1.Text != "")
            {
                //double x = double.Parse(textBox1.Text);
                //textBox1.Text = (x*x).ToString();
                textBox1.Text = Math.Pow(10, double.Parse(textBox1.Text)).ToString();
                bJjeom_Flag = false;
                bClear_Flag = true;
                dSutja_Stored = 0;
                sOperation_Stored = "";
            }
        }

        private void button24_Click(object sender, EventArgs e)
        {//파이
            textBox1.Text = Math.PI.ToString();
            bJjeom_Flag = false;
            bClear_Flag = true;
        }

        private void button34_Click(object sender, EventArgs e)
        {// tan
            if (textBox1.Text != "")
            {
                textBox1.Text = Math.Tan(double.Parse(textBox1.Text) * Math.PI / 180).ToString();

                bJjeom_Flag = false;
                bClear_Flag = true;
                dSutja_Stored = 0;
                sOperation_Stored = "";

            }
        }

        private void button33_Click(object sender, EventArgs e)
        {//mod
            if (textBox1.Text != "")
            {
                if (sOperation_Stored != "")
                {
                    Operation();
                }
                dSutja_Stored = double.Parse(textBox1.Text);
                sOperation_Stored = "%";
                bJjeom_Flag = false;
                bClear_Flag = true;
            }

        }

        private void button32_Click(object sender, EventArgs e)
        {//root
            if (textBox1.Text != "")
            {
                textBox1.Text = Math.Sqrt(double.Parse(textBox1.Text)).ToString();
                bJjeom_Flag = false;
                bClear_Flag = true;
                dSutja_Stored = 0;
                sOperation_Stored = "";
            }
        }
        private Form2 Developer_intro;
        private void 개발자소개ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Developer_intro = new Form2();
            Developer_intro.Owner = this;
            Developer_intro.Show();
            this.Hide();
        }
        private Form3 To_professor;
        private void 교수님에게하고픈말ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            To_professor = new Form3();
            To_professor.Owner = this;
            To_professor.Show();
            this.Hide();
        }
        private Form4 get_Help;
        private void 계산기사용법ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            get_Help = new Form4();
            get_Help.Owner = this;
            get_Help.Show();
            this.Hide();
        }

        private void 개발환경ToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }
    }
}

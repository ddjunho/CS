
namespace WindowsFormsApp1
{
    partial class Form12
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.label4 = new System.Windows.Forms.Label();
            this.textBox4 = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.textBox3 = new System.Windows.Forms.TextBox();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.button1 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("굴림", 15F);
            this.label4.Location = new System.Drawing.Point(594, 130);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(279, 20);
            this.label4.TabIndex = 65;
            this.label4.Text = "3으로 나누어 나머지 2들의 합";
            // 
            // textBox4
            // 
            this.textBox4.Font = new System.Drawing.Font("굴림", 22F);
            this.textBox4.Location = new System.Drawing.Point(598, 185);
            this.textBox4.Multiline = true;
            this.textBox4.Name = "textBox4";
            this.textBox4.Size = new System.Drawing.Size(275, 375);
            this.textBox4.TabIndex = 64;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("굴림", 15F);
            this.label3.Location = new System.Drawing.Point(297, 130);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(279, 20);
            this.label3.TabIndex = 63;
            this.label3.Text = "3으로 나누어 나머지 1들의 합";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("굴림", 15F);
            this.label2.Location = new System.Drawing.Point(6, 130);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(279, 20);
            this.label2.TabIndex = 62;
            this.label2.Text = "3으로 나누어 나머지 0들의 합";
            // 
            // textBox3
            // 
            this.textBox3.Font = new System.Drawing.Font("굴림", 22F);
            this.textBox3.Location = new System.Drawing.Point(302, 185);
            this.textBox3.Multiline = true;
            this.textBox3.Name = "textBox3";
            this.textBox3.Size = new System.Drawing.Size(274, 375);
            this.textBox3.TabIndex = 61;
            // 
            // textBox1
            // 
            this.textBox1.Font = new System.Drawing.Font("굴림", 13F);
            this.textBox1.Location = new System.Drawing.Point(82, 54);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(143, 27);
            this.textBox1.TabIndex = 60;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("굴림", 13F);
            this.label1.Location = new System.Drawing.Point(79, 5);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(270, 18);
            this.label1.TabIndex = 59;
            this.label1.Text = "n값을 입력하고 버튼을 누르세요";
            // 
            // textBox2
            // 
            this.textBox2.Font = new System.Drawing.Font("굴림", 22F);
            this.textBox2.Location = new System.Drawing.Point(10, 185);
            this.textBox2.Multiline = true;
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(271, 375);
            this.textBox2.TabIndex = 58;
            // 
            // button1
            // 
            this.button1.Font = new System.Drawing.Font("굴림", 13F);
            this.button1.Location = new System.Drawing.Point(572, 15);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(225, 80);
            this.button1.TabIndex = 57;
            this.button1.Text = "1부터 n까지의 합(substring으로 +없애기)";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // Form12
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(891, 573);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.textBox4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.textBox3);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.textBox2);
            this.Controls.Add(this.button1);
            this.Name = "Form12";
            this.Text = "Form12";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox textBox4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox textBox3;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.Button button1;
    }
}

namespace homework7
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.splitContainer1 = new System.Windows.Forms.SplitContainer();
            this.panel1 = new System.Windows.Forms.Panel();
            this.label7 = new System.Windows.Forms.Label();
            this.comboBox1_Color = new System.Windows.Forms.ComboBox();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.textBox6_th2 = new System.Windows.Forms.TextBox();
            this.textBox5_th1 = new System.Windows.Forms.TextBox();
            this.textBox4_per2 = new System.Windows.Forms.TextBox();
            this.textBox3_per1 = new System.Windows.Forms.TextBox();
            this.textBox2_leng = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.textBox1_n = new System.Windows.Forms.TextBox();
            this.button1 = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).BeginInit();
            this.splitContainer1.Panel1.SuspendLayout();
            this.splitContainer1.Panel2.SuspendLayout();
            this.splitContainer1.SuspendLayout();
            this.SuspendLayout();
            // 
            // splitContainer1
            // 
            this.splitContainer1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.splitContainer1.Location = new System.Drawing.Point(0, 0);
            this.splitContainer1.Name = "splitContainer1";
            // 
            // splitContainer1.Panel1
            // 
            this.splitContainer1.Panel1.Controls.Add(this.panel1);
            this.splitContainer1.Panel1.Paint += new System.Windows.Forms.PaintEventHandler(this.splitContainer1_Panel1_Paint);
            // 
            // splitContainer1.Panel2
            // 
            this.splitContainer1.Panel2.Controls.Add(this.label7);
            this.splitContainer1.Panel2.Controls.Add(this.comboBox1_Color);
            this.splitContainer1.Panel2.Controls.Add(this.label6);
            this.splitContainer1.Panel2.Controls.Add(this.label5);
            this.splitContainer1.Panel2.Controls.Add(this.label4);
            this.splitContainer1.Panel2.Controls.Add(this.label3);
            this.splitContainer1.Panel2.Controls.Add(this.label2);
            this.splitContainer1.Panel2.Controls.Add(this.textBox6_th2);
            this.splitContainer1.Panel2.Controls.Add(this.textBox5_th1);
            this.splitContainer1.Panel2.Controls.Add(this.textBox4_per2);
            this.splitContainer1.Panel2.Controls.Add(this.textBox3_per1);
            this.splitContainer1.Panel2.Controls.Add(this.textBox2_leng);
            this.splitContainer1.Panel2.Controls.Add(this.label1);
            this.splitContainer1.Panel2.Controls.Add(this.textBox1_n);
            this.splitContainer1.Panel2.Controls.Add(this.button1);
            this.splitContainer1.Size = new System.Drawing.Size(882, 503);
            this.splitContainer1.SplitterDistance = 566;
            this.splitContainer1.TabIndex = 0;
            // 
            // panel1
            // 
            this.panel1.Location = new System.Drawing.Point(3, 3);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(560, 461);
            this.panel1.TabIndex = 0;
            this.panel1.Paint += new System.Windows.Forms.PaintEventHandler(this.Panel1_Paint);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(22, 361);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(69, 20);
            this.label7.TabIndex = 14;
            this.label7.Text = "画笔颜色";
            // 
            // comboBox1_Color
            // 
            this.comboBox1_Color.FormattingEnabled = true;
            this.comboBox1_Color.Items.AddRange(new object[] {
            "Red",
            "Blue",
            "Green",
            "Black",
            "Purple"});
            this.comboBox1_Color.Location = new System.Drawing.Point(137, 358);
            this.comboBox1_Color.Name = "comboBox1_Color";
            this.comboBox1_Color.Size = new System.Drawing.Size(125, 28);
            this.comboBox1_Color.TabIndex = 13;
            this.comboBox1_Color.Text = "Blue";
            this.comboBox1_Color.SelectedIndexChanged += new System.EventHandler(this.comboBox1_SelectedIndexChanged);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(22, 296);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(99, 20);
            this.label6.TabIndex = 12;
            this.label6.Text = "左分支角度：";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(22, 236);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(99, 20);
            this.label5.TabIndex = 11;
            this.label5.Text = "右分支角度：";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(22, 185);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(114, 20);
            this.label4.TabIndex = 10;
            this.label4.Text = "左分支长度比：";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(22, 133);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(114, 20);
            this.label3.TabIndex = 9;
            this.label3.Text = "右分支长度比：";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(22, 84);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(84, 20);
            this.label2.TabIndex = 8;
            this.label2.Text = "主干长度：";
            // 
            // textBox6_th2
            // 
            this.textBox6_th2.Location = new System.Drawing.Point(137, 293);
            this.textBox6_th2.Name = "textBox6_th2";
            this.textBox6_th2.Size = new System.Drawing.Size(125, 27);
            this.textBox6_th2.TabIndex = 7;
            this.textBox6_th2.Text = "20";
            // 
            // textBox5_th1
            // 
            this.textBox5_th1.Location = new System.Drawing.Point(137, 236);
            this.textBox5_th1.Name = "textBox5_th1";
            this.textBox5_th1.Size = new System.Drawing.Size(125, 27);
            this.textBox5_th1.TabIndex = 6;
            this.textBox5_th1.Text = "30";
            // 
            // textBox4_per2
            // 
            this.textBox4_per2.Location = new System.Drawing.Point(137, 182);
            this.textBox4_per2.Name = "textBox4_per2";
            this.textBox4_per2.Size = new System.Drawing.Size(125, 27);
            this.textBox4_per2.TabIndex = 5;
            this.textBox4_per2.Text = "0.7";
            // 
            // textBox3_per1
            // 
            this.textBox3_per1.Location = new System.Drawing.Point(137, 130);
            this.textBox3_per1.Name = "textBox3_per1";
            this.textBox3_per1.Size = new System.Drawing.Size(125, 27);
            this.textBox3_per1.TabIndex = 4;
            this.textBox3_per1.Text = "0.6";
            // 
            // textBox2_leng
            // 
            this.textBox2_leng.Location = new System.Drawing.Point(137, 81);
            this.textBox2_leng.Name = "textBox2_leng";
            this.textBox2_leng.Size = new System.Drawing.Size(125, 27);
            this.textBox2_leng.TabIndex = 3;
            this.textBox2_leng.Text = "100";
            this.textBox2_leng.TextChanged += new System.EventHandler(this.textBox2_leng_TextChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(22, 33);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(84, 20);
            this.label1.TabIndex = 2;
            this.label1.Text = "递归深度：";
            // 
            // textBox1_n
            // 
            this.textBox1_n.Location = new System.Drawing.Point(137, 30);
            this.textBox1_n.Name = "textBox1_n";
            this.textBox1_n.Size = new System.Drawing.Size(125, 27);
            this.textBox1_n.TabIndex = 1;
            this.textBox1_n.Text = "10";
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(96, 423);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(94, 29);
            this.button1.TabIndex = 0;
            this.button1.Text = "draw";
            this.button1.UseVisualStyleBackColor = true;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(882, 503);
            this.Controls.Add(this.splitContainer1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.splitContainer1.Panel1.ResumeLayout(false);
            this.splitContainer1.Panel2.ResumeLayout(false);
            this.splitContainer1.Panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).EndInit();
            this.splitContainer1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.SplitContainer splitContainer1;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.TextBox textBox1_n;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox textBox6_th2;
        private System.Windows.Forms.TextBox textBox5_th1;
        private System.Windows.Forms.TextBox textBox4_per2;
        private System.Windows.Forms.TextBox textBox3_per1;
        private System.Windows.Forms.TextBox textBox2_leng;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.ComboBox comboBox1_Color;
        private System.Windows.Forms.Panel panel1;
    }
}


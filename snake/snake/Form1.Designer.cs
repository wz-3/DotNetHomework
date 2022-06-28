
namespace snake
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
            this.components = new System.ComponentModel.Container();
            this.Bt_start = new System.Windows.Forms.Button();
            this.Bt_pause = new System.Windows.Forms.Button();
            this.Bt_restart = new System.Windows.Forms.Button();
            this.Bt_quit = new System.Windows.Forms.Button();
            this.Bt_wallsSet = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.textBox_score = new System.Windows.Forms.TextBox();
            this.comboBox_speed = new System.Windows.Forms.ComboBox();
            this.label3 = new System.Windows.Forms.Label();
            this.textBox_amounts = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.radioButton1 = new System.Windows.Forms.RadioButton();
            this.radioButton2 = new System.Windows.Forms.RadioButton();
            this.textBox_maxscore = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.panel1 = new System.Windows.Forms.Panel();
            this.bt_endSet = new System.Windows.Forms.Button();
            this.label6 = new System.Windows.Forms.Label();
            this.comboBox_wall_x = new System.Windows.Forms.ComboBox();
            this.comboBox_wall_y = new System.Windows.Forms.ComboBox();
            this.bt_addWall = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // Bt_start
            // 
            this.Bt_start.Location = new System.Drawing.Point(44, 400);
            this.Bt_start.Name = "Bt_start";
            this.Bt_start.Size = new System.Drawing.Size(94, 29);
            this.Bt_start.TabIndex = 1;
            this.Bt_start.Text = "开始游戏";
            this.Bt_start.UseVisualStyleBackColor = true;
            this.Bt_start.Click += new System.EventHandler(this.Bt_start_Click);
            // 
            // Bt_pause
            // 
            this.Bt_pause.Location = new System.Drawing.Point(177, 400);
            this.Bt_pause.Name = "Bt_pause";
            this.Bt_pause.Size = new System.Drawing.Size(94, 29);
            this.Bt_pause.TabIndex = 2;
            this.Bt_pause.Text = "暂停";
            this.Bt_pause.UseVisualStyleBackColor = true;
            this.Bt_pause.Click += new System.EventHandler(this.Bt_pause_Click);
            // 
            // Bt_restart
            // 
            this.Bt_restart.Location = new System.Drawing.Point(309, 400);
            this.Bt_restart.Name = "Bt_restart";
            this.Bt_restart.Size = new System.Drawing.Size(94, 29);
            this.Bt_restart.TabIndex = 3;
            this.Bt_restart.Text = "重新开始";
            this.Bt_restart.UseVisualStyleBackColor = true;
            this.Bt_restart.Click += new System.EventHandler(this.Bt_restart_Click);
            // 
            // Bt_quit
            // 
            this.Bt_quit.Location = new System.Drawing.Point(443, 400);
            this.Bt_quit.Name = "Bt_quit";
            this.Bt_quit.Size = new System.Drawing.Size(94, 29);
            this.Bt_quit.TabIndex = 4;
            this.Bt_quit.Text = "退出游戏";
            this.Bt_quit.UseVisualStyleBackColor = true;
            this.Bt_quit.Click += new System.EventHandler(this.Bt_quit_Click);
            // 
            // Bt_wallsSet
            // 
            this.Bt_wallsSet.Location = new System.Drawing.Point(579, 400);
            this.Bt_wallsSet.Name = "Bt_wallsSet";
            this.Bt_wallsSet.Size = new System.Drawing.Size(94, 29);
            this.Bt_wallsSet.TabIndex = 5;
            this.Bt_wallsSet.Text = "地图设置";
            this.Bt_wallsSet.UseVisualStyleBackColor = true;
            this.Bt_wallsSet.Click += new System.EventHandler(this.Bt_wallsSet_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(593, 70);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(54, 20);
            this.label2.TabIndex = 7;
            this.label2.Text = "速度：";
            // 
            // textBox_score
            // 
            this.textBox_score.Location = new System.Drawing.Point(653, 22);
            this.textBox_score.Name = "textBox_score";
            this.textBox_score.Size = new System.Drawing.Size(125, 27);
            this.textBox_score.TabIndex = 8;
            this.textBox_score.Text = "0";
            // 
            // comboBox_speed
            // 
            this.comboBox_speed.FormattingEnabled = true;
            this.comboBox_speed.Items.AddRange(new object[] {
            "1",
            "2",
            "3",
            "4",
            "5",
            "6",
            "7",
            "8",
            "9"});
            this.comboBox_speed.Location = new System.Drawing.Point(653, 67);
            this.comboBox_speed.Name = "comboBox_speed";
            this.comboBox_speed.Size = new System.Drawing.Size(125, 28);
            this.comboBox_speed.TabIndex = 9;
            this.comboBox_speed.Text = "1";
            this.comboBox_speed.SelectedIndexChanged += new System.EventHandler(this.comboBox1_SelectedIndexChanged);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(593, 113);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(54, 20);
            this.label3.TabIndex = 10;
            this.label3.Text = "个数：";
            // 
            // textBox_amounts
            // 
            this.textBox_amounts.Location = new System.Drawing.Point(653, 113);
            this.textBox_amounts.Name = "textBox_amounts";
            this.textBox_amounts.Size = new System.Drawing.Size(125, 27);
            this.textBox_amounts.TabIndex = 11;
            this.textBox_amounts.Text = "0";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(593, 160);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(114, 20);
            this.label4.TabIndex = 12;
            this.label4.Text = "是否重置长度：";
            // 
            // radioButton1
            // 
            this.radioButton1.AutoSize = true;
            this.radioButton1.Checked = true;
            this.radioButton1.Location = new System.Drawing.Point(23, 7);
            this.radioButton1.Name = "radioButton1";
            this.radioButton1.Size = new System.Drawing.Size(45, 24);
            this.radioButton1.TabIndex = 13;
            this.radioButton1.TabStop = true;
            this.radioButton1.Text = "是";
            this.radioButton1.UseVisualStyleBackColor = true;
            this.radioButton1.CheckedChanged += new System.EventHandler(this.radioButton1_CheckedChanged);
            // 
            // radioButton2
            // 
            this.radioButton2.AutoSize = true;
            this.radioButton2.Location = new System.Drawing.Point(120, 7);
            this.radioButton2.Name = "radioButton2";
            this.radioButton2.Size = new System.Drawing.Size(45, 24);
            this.radioButton2.TabIndex = 14;
            this.radioButton2.Text = "否";
            this.radioButton2.UseVisualStyleBackColor = true;
            // 
            // textBox_maxscore
            // 
            this.textBox_maxscore.Location = new System.Drawing.Point(653, 270);
            this.textBox_maxscore.Name = "textBox_maxscore";
            this.textBox_maxscore.Size = new System.Drawing.Size(125, 27);
            this.textBox_maxscore.TabIndex = 15;
            this.textBox_maxscore.Text = "0";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(579, 270);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(69, 20);
            this.label5.TabIndex = 16;
            this.label5.Text = "最高分：";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(594, 25);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(54, 20);
            this.label1.TabIndex = 17;
            this.label1.Text = "得分：";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.radioButton2);
            this.groupBox1.Controls.Add(this.radioButton1);
            this.groupBox1.Location = new System.Drawing.Point(594, 211);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(184, 37);
            this.groupBox1.TabIndex = 18;
            this.groupBox1.TabStop = false;
            // 
            // timer1
            // 
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // panel1
            // 
            this.panel1.Location = new System.Drawing.Point(10, 10);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(550, 350);
            this.panel1.TabIndex = 19;
            this.panel1.Paint += new System.Windows.Forms.PaintEventHandler(this.panel1_Paint);
            // 
            // bt_endSet
            // 
            this.bt_endSet.Location = new System.Drawing.Point(578, 450);
            this.bt_endSet.Name = "bt_endSet";
            this.bt_endSet.Size = new System.Drawing.Size(94, 29);
            this.bt_endSet.TabIndex = 20;
            this.bt_endSet.Text = "完成";
            this.bt_endSet.UseVisualStyleBackColor = true;
            this.bt_endSet.Click += new System.EventHandler(this.bt_endSet_Click);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(578, 335);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(99, 20);
            this.label6.TabIndex = 21;
            this.label6.Text = "障碍物坐标：";
            // 
            // comboBox_wall_x
            // 
            this.comboBox_wall_x.FormattingEnabled = true;
            this.comboBox_wall_x.Items.AddRange(new object[] {
            "1",
            "2",
            "3",
            "4",
            "5",
            "6",
            "7",
            "8",
            "9",
            "10",
            "11",
            "12",
            "13",
            "14",
            "15",
            "16",
            "17",
            "18",
            "19",
            "20",
            "21",
            "22",
            "23",
            "24",
            "25",
            "26",
            "27",
            "28",
            "29",
            "30",
            "31",
            "32",
            "33",
            "34",
            "35",
            "36",
            "37",
            "38",
            "39",
            "40",
            "41",
            "42",
            "43",
            "44",
            "45",
            "46",
            "47",
            "48",
            "49",
            "50",
            "51",
            "52"});
            this.comboBox_wall_x.Location = new System.Drawing.Point(689, 332);
            this.comboBox_wall_x.Name = "comboBox_wall_x";
            this.comboBox_wall_x.Size = new System.Drawing.Size(41, 28);
            this.comboBox_wall_x.TabIndex = 22;
            // 
            // comboBox_wall_y
            // 
            this.comboBox_wall_y.FormattingEnabled = true;
            this.comboBox_wall_y.Items.AddRange(new object[] {
            "1",
            "2",
            "3",
            "4",
            "5",
            "6",
            "7",
            "8",
            "9",
            "10",
            "11",
            "12",
            "13",
            "14",
            "15",
            "16",
            "17",
            "18",
            "19",
            "20",
            "21",
            "22",
            "23",
            "24",
            "25",
            "26",
            "27",
            "28",
            "29",
            "30",
            "31",
            "32",
            "33"});
            this.comboBox_wall_y.Location = new System.Drawing.Point(736, 332);
            this.comboBox_wall_y.Name = "comboBox_wall_y";
            this.comboBox_wall_y.Size = new System.Drawing.Size(42, 28);
            this.comboBox_wall_y.TabIndex = 23;
            // 
            // bt_addWall
            // 
            this.bt_addWall.Location = new System.Drawing.Point(704, 400);
            this.bt_addWall.Name = "bt_addWall";
            this.bt_addWall.Size = new System.Drawing.Size(94, 29);
            this.bt_addWall.TabIndex = 24;
            this.bt_addWall.Text = "添加";
            this.bt_addWall.UseVisualStyleBackColor = true;
            this.bt_addWall.Click += new System.EventHandler(this.bt_addWall_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(832, 503);
            this.Controls.Add(this.bt_addWall);
            this.Controls.Add(this.comboBox_wall_y);
            this.Controls.Add(this.comboBox_wall_x);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.bt_endSet);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.textBox_maxscore);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.textBox_amounts);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.comboBox_speed);
            this.Controls.Add(this.textBox_score);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.Bt_wallsSet);
            this.Controls.Add(this.Bt_quit);
            this.Controls.Add(this.Bt_restart);
            this.Controls.Add(this.Bt_pause);
            this.Controls.Add(this.Bt_start);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button Bt_start;
        private System.Windows.Forms.Button Bt_pause;
        private System.Windows.Forms.Button Bt_restart;
        private System.Windows.Forms.Button Bt_quit;
        private System.Windows.Forms.Button Bt_wallsSet;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox textBox_score;
        private System.Windows.Forms.ComboBox comboBox_speed;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox textBox_amounts;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.RadioButton radioButton1;
        private System.Windows.Forms.RadioButton radioButton2;
        private System.Windows.Forms.TextBox textBox_maxscore;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.Panel panel1;    
        private System.Windows.Forms.Button bt_endSet;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.ComboBox comboBox_wall_x;
        private System.Windows.Forms.ComboBox comboBox_wall_y;
        private System.Windows.Forms.Button bt_addWall;
    }
}


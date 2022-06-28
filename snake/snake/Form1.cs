using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Windows.Forms;


namespace snake
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        private void Form1_Load(object sender, EventArgs e)
        {
            snake1.createInitWall();
            snake1.createSnake();
            textBox_score.Enabled = false;
            textBox_maxscore.Enabled = false;
            textBox_amounts.Enabled = false;
            
            snake1.createFood();

        }
        private snake snake1 = new snake();
        private String direction = "RIGHT";
        private int maxLen = 20;//达到该长度重置，速度+1
        private int lenReSet = 5;//重置后的长度
        
        
        private void gameInit()
        {

            for (int i = 0; i < snake1.Walls.Count; i++)
            {
                this.panel1.Controls.Add(snake1.Walls[i]);
            }

            for (int i = 0; i < snake1.SnakeBody.Count; i++)
            {
                this.panel1.Controls.Add(snake1.SnakeBody[i]);
            }
            this.panel1.Controls.Add(snake1.Food);
            timer1.Interval = 350;
            
        }
        private void gameOver()
        {
            panel1.Controls.Remove(snake1.Food);
            timer1.Stop();
            DialogResult dr = MessageBox.Show("得分：" + textBox_score.Text + "\n" + "历史最高：" + textBox_maxscore.Text+"\n"+"是否开始新游戏",
                "",MessageBoxButtons.OKCancel,MessageBoxIcon.Question);
            if (dr == DialogResult.OK)
            {
                //重新开始游戏
                textBox_score.Text = "0";
                timer1.Interval = 350;
                comboBox_speed.Text = "1";
                panel1.Controls.Clear();
                snake1.Walls.Clear();
                snake1.SnakeBody.Clear();
                textBox_amounts.Text = "0";
                snake1.createInitWall();
                snake1.createSnake();
                gameInit();
                Bt_start.Enabled = true;
            }
        }
        public void move()

        {
            //判断是否撞墙
            for (int i = snake1.SnakeBody.Count - 1; i > 0; i--)
            {
                if (snake1.SnakeBody[0].Top == snake1.Walls[i].Top|| snake1.SnakeBody[0].Left == snake1.Walls[i].Left)
                {
                    gameOver();
                    break;
                }
                //运动方向控制
                else if (direction == "UP")
                {
                    snake1.SnakeBody[i].Top = snake1.SnakeBody[i - 1].Top;
                    snake1.SnakeBody[i].Left = snake1.SnakeBody[i - 1].Left;
                    if (i == 1)
                    {
                        snake1.SnakeBody[0].Top -= 10;
                        panel1 = snake1.EatFood(panel1, timer1, textBox_score, textBox_maxscore,textBox_amounts ,comboBox_speed);
                        IsHit();
                    }
                    if (snake1.SnakeBody[0].Top < 10)
                    {
                        gameOver();
                        break;
                    }
                }
                else if (direction == "DOWN")
                {
                    snake1.SnakeBody[i].Top = snake1.SnakeBody[i - 1].Top;
                    snake1.SnakeBody[i].Left = snake1.SnakeBody[i - 1].Left;
                    if (i == 1)
                    {
                        snake1.SnakeBody[0].Top += 10;
                        panel1 = snake1.EatFood(panel1, timer1, textBox_score, textBox_maxscore,textBox_amounts ,comboBox_speed);
                        IsHit();
                    }
                    if (snake1.SnakeBody[0].Top > 330)
                    {
                        gameOver();
                        break;
                    }
                }
                else if (direction == "LEFT")
                {
                    snake1.SnakeBody[i].Top = snake1.SnakeBody[i - 1].Top;
                    snake1.SnakeBody[i].Left = snake1.SnakeBody[i - 1].Left;
                    if (i == 1)
                    {
                        snake1.SnakeBody[0].Left -= 10;
                        panel1 = snake1.EatFood(panel1, timer1, textBox_score, textBox_maxscore,textBox_amounts ,comboBox_speed);
                        IsHit();
                    }
                    if (snake1.SnakeBody[0].Left < 20)
                    {
                        gameOver();
                        break;
                    }
                }
                else if (direction == "RIGHT")
                {
                    snake1.SnakeBody[i].Top = snake1.SnakeBody[i - 1].Top;
                    snake1.SnakeBody[i].Left = snake1.SnakeBody[i - 1].Left;
                    if (i == 1)
                    {
                        snake1.SnakeBody[0].Left += 10;
                        panel1 = snake1.EatFood(panel1, timer1, textBox_score, textBox_maxscore,textBox_amounts ,comboBox_speed);
                        IsHit();
                    }
                    if (snake1.SnakeBody[0].Left > 530)
                    {
                        gameOver();
                        break;
                    }
                }
                else 
                {
                    gameOver();
                    break;
                }

            }
            //判断长度是否需要重置
            if (radioButton1.Checked == true)
            {
                if (comboBox_speed.SelectedIndex < 9)
                {
                    //长度达到maxLen时,长度重置，速度+1
                    while (snake1.SnakeBody.Count == maxLen)
                    {
                        comboBox_speed.SelectedIndex = comboBox_speed.SelectedIndex + 1;
                        for (int i = snake1.SnakeBody.Count - 1; i > lenReSet - 1; i--)
                        {
                            snake1.snakeBody.RemoveAt(i);
                            snake1.snakeBody.RemoveAt(i);

                        }
                    }
                }
            }
            //判断与添加的墙是否相撞
            for (int j = 0; j < snake1.WallSet.Count; j++)
            {
                if(snake1.SnakeBody[0].Left==snake1.WallSet[j].Left && snake1.SnakeBody[0].Top == snake1.WallSet[j].Top)
                {
                    gameOver();
                    break;
                }
            }
        }
        public void IsHit()
        {
            for (int i = 1; i < snake1.SnakeBody.Count; i++)
            {
                if (snake1.SnakeBody[0].Top == snake1.SnakeBody[i].Top && snake1.SnakeBody[0].Left == snake1.SnakeBody[i].Left)
                {
                    gameOver();
                    break;
                }
            }
        }
        protected override bool ProcessDialogKey(Keys keyData)
        {
            //方向键控制运动
            switch (keyData)
            {
                case Keys.Up:
                    if (direction == "DOWN")
                        direction = "DOWN"; //防止蛇回头
                    else
                        direction = "UP";  break;
                case Keys.Down:
                    if (direction == "UP")
                        direction = "UP"; 
                    else
                        direction = "DOWN"; break;
                case Keys.Left:
                    if (direction == "RIGHT")
                        direction = "RIGHT"; 
                    else
                        direction = "LEFT"; break;
                case Keys.Right:
                    if (direction == "LEFT")
                        direction = "LEFT"; 
                    else
                        direction = "RIGHT"; break;
            }
            if (keyData == Keys.Up || keyData == Keys.Down || keyData == Keys.Left || keyData == Keys.Right)
            {
                return false;
            }
            else
            {
                return base.ProcessDialogKey(keyData);
            }
        }

        private void radioButton1_CheckedChanged(object sender, EventArgs e)
        {
           /* if (radioButton1.Checked == true)
            {
                if (comboBox_speed.SelectedIndex < 7)
                {
                    //长度达到maxLen时,长度重置，速度+1
                    while (snake1.SnakeBody.Count == maxLen)
                    {
                        comboBox_speed.SelectedIndex = comboBox_speed.SelectedIndex + 1;
                        for (int i = snake1.SnakeBody.Count - 1; i > lenReSet - 1; i--)
                        {
                            snake1.SnakeBody.RemoveAt(i);
                            snake1.snakeBody.RemoveAt(i);

                        }
                    }
                }
            }*/
        }
        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            snake1.SpeedControl(comboBox_speed, timer1);
        }
        private void Bt_start_Click(object sender, EventArgs e)
        {
            Bt_start.Enabled = false;
            
            comboBox_speed.Enabled = false;
            radioButton1.Enabled = false;
            radioButton2.Enabled = false;
            timer1.Start();
            comboBox_wall_x.Enabled = false;
            comboBox_wall_y.Enabled = false;
            //panel1 = snake1.DeleteFood(panel1);


        }
        private void Bt_pause_Click(object sender, EventArgs e)
        {
            timer1.Stop();
            Bt_start.Enabled = true;
            snake1.SpeedControl(comboBox_speed, timer1);
            comboBox_speed.Enabled = true;
            radioButton1.Enabled = true;
            radioButton2.Enabled = true;
            
         /*   if (!isMove)
            {
                comboBox_speed.Enabled = true;
                radioButton1.Enabled = true;
                radioButton2.Enabled = true;
            }
            DialogResult dr = MessageBox.Show("         继续","", MessageBoxButtons.OKCancel,MessageBoxIcon.Question,MessageBoxDefaultButton.Button1);
            if (dr == DialogResult.OK)
            {
                timer1.Start();
                isMove = true;
            }
         */
        }

        private void Bt_restart_Click(object sender, EventArgs e)
        {

            textBox_score.Text = "0";
            timer1.Interval = 350;
            panel1.Controls.Clear();
            snake1.Walls.Clear();
            snake1.SnakeBody.Clear();
            textBox_amounts.Text = "0";
            comboBox_speed.Text = "1";
            snake1.createInitWall();
            snake1.createSnake();
            gameInit();
            timer1.Start();
        }

        private void Bt_quit_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void Bt_wallsSet_Click(object sender, EventArgs e)
        {
            timer1.Stop();
            Bt_start.Enabled = false;
            Bt_pause.Enabled = false;
            Bt_restart.Enabled = false;
            radioButton1.Enabled = false;
            radioButton2.Enabled = false;
            comboBox_speed.Enabled = false;
            comboBox_wall_x.Enabled = true;
            comboBox_wall_y.Enabled = true;
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            move();
        }
        
       
        private void panel1_Paint(object sender, PaintEventArgs e)
        {
            gameInit();
        }

        private void bt_endSet_Click(object sender, EventArgs e)
        {
            timer1.Start();
            Bt_start.Enabled = true;
            Bt_pause.Enabled = true;
            Bt_restart.Enabled = true;
            comboBox_speed.Enabled = true;
            
        }

        private void bt_addWall_Click(object sender, EventArgs e)
        {
            int x = comboBox_wall_x.SelectedIndex * 10 + 20;
            int y = comboBox_wall_y.SelectedIndex * 10 + 10;
            Label lb = new Label();
            lb.Left = x;
            lb.Top = y;
            lb.Width = 10;
            lb.Height = 10;
            lb.BackColor = Color.Black;
            snake1.wallSet.Add(lb);
            panel1.Controls.Add(lb);
            panel1.Refresh();
           
        }
    }
    
}

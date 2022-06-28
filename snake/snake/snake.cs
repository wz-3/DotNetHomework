using System;
using System.Collections.Generic;
using System.Text;
using System.Windows.Forms;
using System.Drawing;
using System.Linq;

namespace snake
{
    
    
    public class snake
    {
        public List<Label> snakeBody = new List<Label>();
        
        public List<Label> SnakeBody { get { return snakeBody; } set { snakeBody = value; } }
        public List<Label> walls = new List<Label>();
        public List<Label> Walls { get { return walls; } set { walls = value; } }
        public List<Label> wallSet = new List<Label>();
        public List<Label> WallSet { get { return wallSet; } set { wallSet = value; } }
        public void createInitWall()
        {
            int X1 = 10, X2 = 550, Y1 = 10, Y2 = 340;//边界线的坐标
            Label lb_Up, lb_Down, lb_Left, lb_Right;
            //依次画出四道边界线
            for(int i = 0; i < 55; i++)
            {
                lb_Up = new Label();
                lb_Up.Name = "lb_Up" + i.ToString();
                lb_Up.BackColor = (i%2==0)?Color.Black:Color.White;
                lb_Up.Width = 10;
                lb_Up.Height = 10;
                lb_Up.Top = 0;
                lb_Up.Left = X1;
                walls.Add(lb_Up);
                X1 = X1+ 10;
            }
            for (int j = 0; j < 55; j++)
            {
                lb_Down = new Label();
                lb_Down.Name = "lb_Down" + j;
                lb_Down.BackColor = (j % 2 == 0) ? Color.Green : Color.White;
                lb_Down.Width = 10;
                lb_Down.Height = 10;
                lb_Down.Top = Y2;
                lb_Down.Left = X2;
                walls.Add(lb_Down);
                X2 = X2 - 10;
            }
            for (int k = 0; k < 35; k++)
            {
                lb_Left = new Label();
                lb_Left.Name = "lb_Left" + k;
                lb_Left.BackColor = (k % 2 == 0) ? Color.Red : Color.White;
                lb_Left.Width = 10;
                lb_Left.Height = 10;
                lb_Left.Top = Y1;
                lb_Left.Left = 10;
                walls.Add(lb_Left);
                Y1 = Y1 + 10;
            }
            for (int l = 0; l < 35; l++)
            {
                lb_Right = new Label();
                lb_Right.Name = "lb_Right" + l;
                lb_Right.BackColor = (l % 2 == 0) ? Color.Blue : Color.White;
                lb_Right.Width = 10;
                lb_Right.Height = 10;
                lb_Right.Top = Y2;
                lb_Right.Left = 540;
                walls.Add(lb_Right);
                Y2 = Y2 - 10;
            }
        }
        public void createSnake()
        {
            Random rand1 = new Random();
            int X_Init = rand1.Next(2, 54) * 10;
            int Y_Init = rand1.Next(2, 34) * 10;
            Label lb;
            for(int i = 0; i < 2; i++)
            {
                lb = new Label();
                lb.Name = "lb" + i;
                lb.BackColor = (i%2==0)?Color.Green: Color.Red;
                lb.Width = 10;
                lb.Height = 10;
                lb.Top = Y_Init;
                lb.Left = X_Init;
                snakeBody.Add(lb);
                X_Init = X_Init - 10;
            }
            SnakeBody[0].BackColor = Color.Black;
            //判断生成的蛇是否撞墙
            for (int i = 0; i < Walls.Count; i++)
            {
                if ((snakeBody[0].Top == Walls[i].Top && snakeBody[0].Left == Walls[i].Left)
                    || (snakeBody[1].Top == Walls[i].Top && snakeBody[1].Left == Walls[i].Left))
                {
                    snakeBody.Clear();
                    createSnake();

                }
            }

        }
        

        public Point Food_P;
        public Label Food { get; set; }
        public void createFood()
        {
            Random rand2 = new Random();
            Food_P.X = rand2.Next(1, 55) * 10;
            Food_P.Y = rand2.Next(1, 35) * 10;
            //判断场上食物是否已经被吃掉
            for (int i = 0; i < snakeBody.Count; i++)
            {
                if (Food_P.X == snakeBody[i].Top && Food_P.Y== snakeBody[i].Left)
                {
                    this.createFood();
                    break;
                }
            }
            //判断食物是否与障碍重合
            for (int i = 0; i < walls.Count;i++)
            {
                if (Food_P.X ==this.walls[i].Left && Food_P.Y==this.walls[i].Top)
                {
                    this.createFood();
                }
            }
            Food = new Label();
            Food.Width = 10;
            Food.Height = 10;
            Food.Top = Food_P.Y;
            Food.Left = Food_P.X;
            Food.BackColor = Color.Red;
        }

        public Panel EatFood(Panel panel1,Timer timer1,TextBox textBox1,TextBox textBox2,TextBox textBox3, ComboBox comboBox1)
        {
            //textBox1,2,3分别表示得分，最高分，吃食物个数
            if (snakeBody[0].Top==Food_P.Y && (snakeBody[0].Left == Food_P.X))
            {
                
                Label lb = new Label();
                lb.Width = 10;
                lb.Height = 10;
                lb.Top = snakeBody[snakeBody.Count - 1].Top;
                lb.Left = snakeBody[snakeBody.Count - 1].Left;
                lb.BackColor = (snakeBody.Count % 2 == 0) ? Color.Green : Color.Red;
                SnakeBody[0].BackColor = Color.Black;
                panel1 = this.DeleteFood(panel1);

                snakeBody.Add(lb);

                SpeedControl(comboBox1,timer1);
                panel1.Refresh();
                int textBox1Text = int.Parse(textBox1.Text);
                int textBox2Text = int.Parse(textBox2.Text);
                int textBox3Text = int.Parse(textBox3.Text);
                textBox3Text = textBox3Text + 1;
                textBox1Text = textBox1Text + 10;
                textBox1.Text = Convert.ToString(textBox1Text);
                textBox3.Text = Convert.ToString(textBox3Text);
                if (textBox1Text > textBox2Text)
                    textBox2Text = textBox1Text;
                textBox2.Text = Convert.ToString(textBox2Text);
                //textBox1.Text = Convert.ToString(Convert.ToInt32(textBox1.Text) + 10);
                // if(Convert.ToInt32(textBox1.Text) > Convert.ToInt32(textBox2.Text))
                //  textBox2.Text = textBox1.Text;
            }

            return panel1;
        }
        public Panel DeleteFood(Panel panel1)
        {
            panel1.Controls.Remove(Food);
            this.createFood();
            panel1.Controls.Add(Food);
            return panel1;
        }
        public Timer SpeedControl(ComboBox ComboBox1,Timer timer1)
        {
            switch (ComboBox1.Text)
            {
                case "1":
                    timer1.Interval = 350;break;
                case "2":
                    timer1.Interval = 300; break;
                case "3":
                    timer1.Interval = 250; break;
                case "4":
                    timer1.Interval = 200; break;
                case "5":
                    timer1.Interval = 150; break;
                case "6":
                    timer1.Interval = 100; break;
                case "7":
                    timer1.Interval = 50; break;
                case "8":
                    timer1.Interval = 30;break;
                case "9":
                    timer1.Interval = 10;break;

            }
            
            return timer1;
        }
    }
      
}

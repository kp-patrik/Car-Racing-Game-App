namespace Car_Racing_Game_App
{
    public partial class enemy1 : Form
    {
        public enemy1()
        {
            InitializeComponent();
            over.Visible = false;
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            moveLine(gameSpeed);
            enemy(gameSpeed);
            gameOver();
            coins(gameSpeed);
            coinsCollection();
        }

        int collectedCoins = 0;

        Random random = new Random();
        int x;
        void enemy(int speed)
        {
            if (enemy2.Top >= 500)
            {
                x = random.Next(10, 200);
                enemy2.Location = new Point(x, 0);
            }
            else
            {
                enemy2.Top += speed;
            }

            if (enemy3.Top >= 500)
            {
                x = random.Next(0, 400);
                enemy3.Location = new Point(x, 0);
            }
            else
            {
                enemy3.Top += speed;
            }

            if (enemy4.Top >= 500)
            {
                x = random.Next(200, 350);
                enemy4.Location = new Point(x, 0);
            }
            else
            {
                enemy4.Top += speed;
            }

        }

        void coins(int speed)
        {
            if (coin1.Top >= 500)
            {
                x = random.Next(10, 200);
                coin1.Location = new Point(x, 0);
            }
            else
            {
                coin1.Top += speed;
            }

            if (coin2.Top >= 500)
            {
                x = random.Next(0, 400);
                coin2.Location = new Point(x, 0);
            }
            else
            {
                coin2.Top += speed;
            }

            if (coin3.Top >= 500)
            {
                x = random.Next(200, 350);
                coin3.Location = new Point(x, 0);
            }
            else
            {
                coin3.Top += speed;
            }

            if (coin4.Top >= 500)
            {
                x = random.Next(200, 350);
                coin4.Location = new Point(x, 0);
            }
            else
            {
                coin4.Top += speed;
            }

        }

        void coinsCollection()
        {
            if (car.Bounds.IntersectsWith(coin1.Bounds))
            {
                collectedCoins++;
                Points.Text = "Points:" + collectedCoins.ToString();
                x = random.Next(50,300);
                coin1.Location = new Point(x, 0);
            }
            if (car.Bounds.IntersectsWith(coin2.Bounds))
            {
                collectedCoins++;
                Points.Text = "Points:" + collectedCoins.ToString();
                x = random.Next(50, 300);
                coin2.Location = new Point(x, 0);
            }
            if (car.Bounds.IntersectsWith(coin3.Bounds))
            {
                collectedCoins++;
                Points.Text = "Points:" + collectedCoins.ToString();
                x = random.Next(50, 300);
                coin3.Location = new Point(x, 0);
            }
            if (car.Bounds.IntersectsWith(coin4.Bounds))
            {
                collectedCoins++;
                Points.Text = "Points:" + collectedCoins.ToString();
                x = random.Next(50, 300);
                coin4.Location = new Point(x, 0);
            }
        }

        void gameOver()
        {
            if (car.Bounds.IntersectsWith(enemy2.Bounds))
            {
                timer1.Enabled = false;
                over.Visible = true;
            }
            if (car.Bounds.IntersectsWith(enemy3.Bounds))
            {
                timer1.Enabled = false;
                over.Visible = true;
            }
            if (car.Bounds.IntersectsWith(enemy4.Bounds))
            {
                timer1.Enabled = false;
                over.Visible = true;
            }
        }

        void moveLine(int speed)
        {
            if (pictureBox1.Top >= 500)
            {
                pictureBox1.Top = 0;
            }
            else
            {
                pictureBox1.Top += speed;
            }
            if (pictureBox2.Top >= 500)
            {
                pictureBox2.Top = 0;
            }
            else
            {
                pictureBox2.Top += speed;
            }
            if (pictureBox3.Top >= 500)
            {
                pictureBox3.Top = 0;
            }
            else
            {
                pictureBox3.Top += speed;
            }
            if (pictureBox4.Top >= 500)
            {
                pictureBox4.Top = 0;
            }
            else
            {
                pictureBox4.Top += speed;
            }
            if (pictureBox5.Top >= 500)
            {
                pictureBox5.Top = 0;
            }
            else
            {
                pictureBox5.Top += speed;
            }
        }

        int gameSpeed = 1;
        private void Form1_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Left && car.Left > 18)
            {
                car.Left += -8;
            }
            if (e.KeyCode == Keys.Right && car.Left < 325)
            {
                car.Left += 8;
            }
            if (e.KeyCode == Keys.Up && gameSpeed < 21)
            {
                gameSpeed++;
            }
            if (e.KeyCode == Keys.Down && gameSpeed > 0)
            {
                gameSpeed--;
            }

        }
    }
}
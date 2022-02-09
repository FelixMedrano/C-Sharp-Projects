namespace Game1
{
	public partial class Form1 : Form
	{
		public Form1()
		{
			InitializeComponent();
			gameOver.Visible = false;
			
		}

		private void timer1_Tick(object sender, EventArgs e)
		{
			moveline(gameSpeed);
			enemy(gameSpeed);
			GameOver();
			Points(gameSpeed);
			IncPoints();
		}
		int myPoints = 0;
		Random r= new Random();
		int x;
		void enemy(int speed)
		{
			if (Enemy1.Top >= 500)
			{
				x = r.Next(0, 150);
				Enemy1.Location=new Point(x, -50);
			}
			else
				Enemy1.Top += speed;

			if (Enemy2.Top >= 500)
			{
				x = r.Next(0, 400);
				Enemy2.Location = new Point(x, -50);
			}
			else
				Enemy2.Top += speed;
			if (Enemy3.Top >= 500)
			{
				x = r.Next(200, 350);
				Enemy3.Location = new Point(x, -50);
			}
			else
				Enemy3.Top += speed;

		}
		void Points(int speed)
		{
			if (point1.Top >= 500)
			{
				x = r.Next(0, 150);
				point1.Location = new Point(x, -50);
			}
			else
				point1.Top += speed;

			if (point2.Top >= 500)
			{
				x = r.Next(0, 400);
				point2.Location = new Point(x, -50);
			}
			else
				point2.Top += speed;
			if (point3.Top >= 500)
			{
				x = r.Next(200, 350);
				point3.Location = new Point(x, -50);
			}
			else
				point3.Top += speed;
			if (point4.Top >= 500)
			{
				x = r.Next(0, 400);
				point4.Location = new Point(x, -50);
			}
			else
				point4.Top += speed;


		}
		void GameOver()
		{
			if(car.Bounds.IntersectsWith(Enemy1.Bounds))
			{
				timer1.Enabled = false;
				gameOver.Visible = true;
				car.Image = Image.FromFile("Explode.png");
			}
			if (car.Bounds.IntersectsWith(Enemy2.Bounds))
			{
				timer1.Enabled = false;
				gameOver.Visible = true; 
				car.Image = Image.FromFile("Explode.png");
			}
			if (car.Bounds.IntersectsWith(Enemy3.Bounds))
			{
				timer1.Enabled = false;
				gameOver.Visible = true;
				car.Image = Image.FromFile("Explode.png");
			}
			
		}
		void IncPoints()
		{
			if (car.Bounds.IntersectsWith(point1.Bounds))
			{
				myPoints++;
				pointCounter.Text = "Points= " + myPoints;
				x = r.Next(0, 150);
				point1.Location = new Point(x, -50);
			}
			if (car.Bounds.IntersectsWith(point2.Bounds))
			{
				myPoints++;
				pointCounter.Text = "Points= " + myPoints;
				x = r.Next(0, 150);
				point2.Location = new Point(x, -50);
			}
			if (car.Bounds.IntersectsWith(point3.Bounds))
			{
				myPoints++;
				pointCounter.Text = "Points= " + myPoints;
				x = r.Next(0, 150);
				point3.Location = new Point(x, -50); x = r.Next(0, 150);
			}
			if (car.Bounds.IntersectsWith(point4.Bounds))
			{
				myPoints++;
				pointCounter.Text = "Points= " + myPoints;
				x = r.Next(0, 150);
				point4.Location = new Point(x, -50); x = r.Next(0, 150);
			}
		}

		void moveline(int speed)
		{
			if (pictureBox1.Top >= 500)
				pictureBox1.Top = -50;
			else
				pictureBox1.Top += speed;
			if (pictureBox2.Top >= 500)
				pictureBox2.Top = -50;
			else
				pictureBox2.Top += speed;
			if (pictureBox3.Top >= 500)
				pictureBox3.Top = -50;
			else
				pictureBox3.Top += speed;
			if (pictureBox6.Top >= 500)
				pictureBox6.Top = -50;
			else
				pictureBox6.Top += speed;
		}
		int gameSpeed = 0;
		private void Form1_KeyDown(object sender, KeyEventArgs e)
		{
			if (e.KeyCode == Keys.Left &&gameOver.Visible==false)
			{
				if(car.Left>10)
					car.Left += -8;
			}
			if (e.KeyCode == Keys.Right && gameOver.Visible == false)
			{
				if(car.Right<375)
					car.Left += 8;
			}
			if(e.KeyCode == Keys.Up )
			{
				if(gameSpeed<21)
					gameSpeed++;
			}
			if (e.KeyCode == Keys.Down )
			{
				if (gameSpeed>0)
					gameSpeed--;
			}
			if(gameOver.Enabled==true && e.KeyCode==Keys.Enter)
				Application.Restart();
		}

		
	}
}
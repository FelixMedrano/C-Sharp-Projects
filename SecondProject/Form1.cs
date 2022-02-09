using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Game2
{
	public partial class Form1 : Form
	{
		bool goLeft, goRight, jumping, isGameOver;
		int jumpspeed;
		int force;
		int score = 0;
		int playerSpeed = 7;

		int horizontalSpeed = 5;
		int verticalSpeed = 3;

		int enemyOneSpeed = 5;
		int enemyTwoSpeed = 3;
		public Form1()
		{
			InitializeComponent();
		}

		private void MainGameTimerEvent(object sender, EventArgs e)
		{
			Score.Text = "Score: " + score;
			player.Top += jumpspeed;
			if (goLeft == true)
				player.Left -= playerSpeed;
			if (goRight == true)
				player.Left += playerSpeed;
			if(jumping==true&&force<0)
				jumping=false;
			if (jumping == true)
			{
				jumpspeed = -8;
				force -=1;
			}
			else
				jumpspeed = 10;
			foreach(Control x in this.Controls)
			{
				if(x is PictureBox)
				{
					if((string)x.Tag=="platform")
					{
						if(player.Bounds.IntersectsWith(x.Bounds))
						{
							force = 8;
							player.Top = x.Top - player.Height;
							if((string)x.Name=="horizontalPlatform"&& goLeft==false|| (string)x.Name == "horizontalPlatform" && goRight == false)
								player.Left -= horizontalSpeed;
						}
						x.BringToFront();
					}
					if((string)x.Tag =="coin")
					{
						if(player.Bounds.IntersectsWith(x.Bounds)&&x.Visible==true)
						{
							score++;
							x.Visible = false;
						}
					}
					if((string)x.Tag=="enemy")
					{
						if (player.Bounds.IntersectsWith(x.Bounds))
						{
							timer1.Stop();
							isGameOver = true;
							Score.Text="Score: "+score+Environment.NewLine+"You died!";
						}

					}
				}
			}
			horizontalPlatform.Left -= horizontalSpeed;
			if(horizontalPlatform.Left < 0||horizontalPlatform.Left+horizontalPlatform.Width>this.ClientSize.Width)
				horizontalSpeed=-horizontalSpeed;
			verticalPlatform.Top+=verticalSpeed;

			if(verticalPlatform.Top<214||verticalPlatform.Top>576)
				verticalSpeed=-verticalSpeed;
			enemy1.Left -= enemyOneSpeed;
			if(enemy1.Left<pictureBox5.Left||enemy1.Left+enemy1.Width>pictureBox5.Left+pictureBox5.Width)
				enemyOneSpeed = -enemyOneSpeed;
			enemy2.Left+=enemyTwoSpeed;
			if (enemy2.Left < pictureBox2.Left || enemy2.Left + enemy2.Width > pictureBox2.Left + pictureBox2.Width)
				enemyTwoSpeed = -enemyTwoSpeed;
			if(player.Top+player.Height>this.ClientSize.Height+50)
			{
				timer1.Stop();
				isGameOver=true;
				Score.Text = "Score: " + score + Environment.NewLine + "You Fell!";
			}
			if(player.Bounds.IntersectsWith(door.Bounds)&&score==29)
			{
				timer1.Stop();
				isGameOver = true;
				Score.Text = "Score: " + score + Environment.NewLine + "Winner!!!";
			}
		}
		private void Form1_KeyDown(object sender, KeyEventArgs e)
		{
			if(e.KeyCode == Keys.Left)
				goLeft = true;
			if(e.KeyCode == Keys.Right)
				goRight = true;
			if (e.KeyCode == Keys.Space && jumping == false)
				jumping = true;

		}

		private void Form1_KeyUp(object sender, KeyEventArgs e)
		{
			if (e.KeyCode == Keys.Left)
				goLeft = false;
			if (e.KeyCode == Keys.Right)
				goRight = false;
			if(jumping == true)
				jumping=false;
			if(e.KeyCode==Keys.Enter &&isGameOver==true)
				ResetGame();
		}
		private void ResetGame()
		{
			jumping = false;
			goLeft = false;	
			goRight = false;
			isGameOver = false;
			score = 0;

			Score.Text = "Score: " + score;
			foreach(Control x in this.Controls)
				if(x is PictureBox&&x.Visible==false)
					x.Visible = true;

			player.Left = 48;
			player.Top = 684;
			enemy1.Left = 521;
			enemy2.Left = 485;
			horizontalPlatform.Left = 222;
			verticalPlatform.Top = 576;
			timer1.Start();
			
		}
	}
}

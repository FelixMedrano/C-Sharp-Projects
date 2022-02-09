namespace Game1
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
			System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
			this.pictureBox1 = new System.Windows.Forms.PictureBox();
			this.pictureBox2 = new System.Windows.Forms.PictureBox();
			this.pictureBox3 = new System.Windows.Forms.PictureBox();
			this.pictureBox4 = new System.Windows.Forms.PictureBox();
			this.pictureBox5 = new System.Windows.Forms.PictureBox();
			this.timer1 = new System.Windows.Forms.Timer(this.components);
			this.pictureBox6 = new System.Windows.Forms.PictureBox();
			this.car = new System.Windows.Forms.PictureBox();
			this.Enemy3 = new System.Windows.Forms.PictureBox();
			this.Enemy2 = new System.Windows.Forms.PictureBox();
			this.Enemy1 = new System.Windows.Forms.PictureBox();
			this.gameOver = new System.Windows.Forms.Label();
			this.point2 = new System.Windows.Forms.PictureBox();
			this.point3 = new System.Windows.Forms.PictureBox();
			this.point4 = new System.Windows.Forms.PictureBox();
			this.point1 = new System.Windows.Forms.PictureBox();
			this.pointCounter = new System.Windows.Forms.Label();
			((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.pictureBox4)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.pictureBox5)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.pictureBox6)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.car)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.Enemy3)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.Enemy2)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.Enemy1)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.point2)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.point3)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.point4)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.point1)).BeginInit();
			this.SuspendLayout();
			// 
			// pictureBox1
			// 
			this.pictureBox1.BackColor = System.Drawing.Color.White;
			this.pictureBox1.Location = new System.Drawing.Point(179, 58);
			this.pictureBox1.Name = "pictureBox1";
			this.pictureBox1.Size = new System.Drawing.Size(10, 120);
			this.pictureBox1.TabIndex = 0;
			this.pictureBox1.TabStop = false;
			// 
			// pictureBox2
			// 
			this.pictureBox2.BackColor = System.Drawing.Color.White;
			this.pictureBox2.Location = new System.Drawing.Point(179, 251);
			this.pictureBox2.Name = "pictureBox2";
			this.pictureBox2.Size = new System.Drawing.Size(10, 126);
			this.pictureBox2.TabIndex = 0;
			this.pictureBox2.TabStop = false;
			// 
			// pictureBox3
			// 
			this.pictureBox3.BackColor = System.Drawing.Color.White;
			this.pictureBox3.Location = new System.Drawing.Point(179, 445);
			this.pictureBox3.Name = "pictureBox3";
			this.pictureBox3.Size = new System.Drawing.Size(10, 95);
			this.pictureBox3.TabIndex = 0;
			this.pictureBox3.TabStop = false;
			// 
			// pictureBox4
			// 
			this.pictureBox4.BackColor = System.Drawing.Color.White;
			this.pictureBox4.Location = new System.Drawing.Point(-1, 0);
			this.pictureBox4.Name = "pictureBox4";
			this.pictureBox4.Size = new System.Drawing.Size(10, 461);
			this.pictureBox4.TabIndex = 0;
			this.pictureBox4.TabStop = false;
			// 
			// pictureBox5
			// 
			this.pictureBox5.BackColor = System.Drawing.Color.White;
			this.pictureBox5.Location = new System.Drawing.Point(375, 0);
			this.pictureBox5.Name = "pictureBox5";
			this.pictureBox5.Size = new System.Drawing.Size(10, 461);
			this.pictureBox5.TabIndex = 0;
			this.pictureBox5.TabStop = false;
			// 
			// timer1
			// 
			this.timer1.Enabled = true;
			this.timer1.Interval = 1;
			this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
			// 
			// pictureBox6
			// 
			this.pictureBox6.BackColor = System.Drawing.Color.White;
			this.pictureBox6.Location = new System.Drawing.Point(179, -51);
			this.pictureBox6.Name = "pictureBox6";
			this.pictureBox6.Size = new System.Drawing.Size(10, 62);
			this.pictureBox6.TabIndex = 0;
			this.pictureBox6.TabStop = false;
			// 
			// car
			// 
			this.car.BackColor = System.Drawing.Color.Transparent;
			this.car.Image = ((System.Drawing.Image)(resources.GetObject("car.Image")));
			this.car.Location = new System.Drawing.Point(50, 339);
			this.car.Name = "car";
			this.car.Size = new System.Drawing.Size(38, 66);
			this.car.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
			this.car.TabIndex = 1;
			this.car.TabStop = false;
			// 
			// Enemy3
			// 
			this.Enemy3.BackColor = System.Drawing.Color.Transparent;
			this.Enemy3.Image = ((System.Drawing.Image)(resources.GetObject("Enemy3.Image")));
			this.Enemy3.Location = new System.Drawing.Point(261, 308);
			this.Enemy3.Name = "Enemy3";
			this.Enemy3.Size = new System.Drawing.Size(38, 51);
			this.Enemy3.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
			this.Enemy3.TabIndex = 1;
			this.Enemy3.TabStop = false;
			// 
			// Enemy2
			// 
			this.Enemy2.BackColor = System.Drawing.Color.Transparent;
			this.Enemy2.Image = ((System.Drawing.Image)(resources.GetObject("Enemy2.Image")));
			this.Enemy2.Location = new System.Drawing.Point(294, 103);
			this.Enemy2.Name = "Enemy2";
			this.Enemy2.Size = new System.Drawing.Size(38, 51);
			this.Enemy2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
			this.Enemy2.TabIndex = 1;
			this.Enemy2.TabStop = false;
			// 
			// Enemy1
			// 
			this.Enemy1.BackColor = System.Drawing.Color.Transparent;
			this.Enemy1.Image = ((System.Drawing.Image)(resources.GetObject("Enemy1.Image")));
			this.Enemy1.Location = new System.Drawing.Point(37, 103);
			this.Enemy1.Name = "Enemy1";
			this.Enemy1.Size = new System.Drawing.Size(38, 51);
			this.Enemy1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
			this.Enemy1.TabIndex = 1;
			this.Enemy1.TabStop = false;
			// 
			// gameOver
			// 
			this.gameOver.AutoSize = true;
			this.gameOver.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
			this.gameOver.Font = new System.Drawing.Font("Sitka Text", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
			this.gameOver.ForeColor = System.Drawing.Color.Red;
			this.gameOver.Location = new System.Drawing.Point(105, 233);
			this.gameOver.Name = "gameOver";
			this.gameOver.Size = new System.Drawing.Size(182, 39);
			this.gameOver.TabIndex = 2;
			this.gameOver.Text = "GAME OVER";
			// 
			// point2
			// 
			this.point2.BackColor = System.Drawing.Color.Gray;
			this.point2.Image = ((System.Drawing.Image)(resources.GetObject("point2.Image")));
			this.point2.Location = new System.Drawing.Point(228, 58);
			this.point2.Name = "point2";
			this.point2.Size = new System.Drawing.Size(25, 24);
			this.point2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
			this.point2.TabIndex = 1;
			this.point2.TabStop = false;
			// 
			// point3
			// 
			this.point3.BackColor = System.Drawing.Color.Gray;
			this.point3.Image = ((System.Drawing.Image)(resources.GetObject("point3.Image")));
			this.point3.Location = new System.Drawing.Point(115, 308);
			this.point3.Name = "point3";
			this.point3.Size = new System.Drawing.Size(25, 24);
			this.point3.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
			this.point3.TabIndex = 1;
			this.point3.TabStop = false;
			// 
			// point4
			// 
			this.point4.BackColor = System.Drawing.Color.Gray;
			this.point4.Image = ((System.Drawing.Image)(resources.GetObject("point4.Image")));
			this.point4.Location = new System.Drawing.Point(307, 402);
			this.point4.Name = "point4";
			this.point4.Size = new System.Drawing.Size(25, 24);
			this.point4.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
			this.point4.TabIndex = 1;
			this.point4.TabStop = false;
			// 
			// point1
			// 
			this.point1.BackColor = System.Drawing.Color.Gray;
			this.point1.Image = ((System.Drawing.Image)(resources.GetObject("point1.Image")));
			this.point1.Location = new System.Drawing.Point(83, 58);
			this.point1.Name = "point1";
			this.point1.Size = new System.Drawing.Size(25, 24);
			this.point1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
			this.point1.TabIndex = 1;
			this.point1.TabStop = false;
			// 
			// pointCounter
			// 
			this.pointCounter.AutoSize = true;
			this.pointCounter.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
			this.pointCounter.ForeColor = System.Drawing.Color.Yellow;
			this.pointCounter.Location = new System.Drawing.Point(12, 0);
			this.pointCounter.Name = "pointCounter";
			this.pointCounter.Size = new System.Drawing.Size(73, 20);
			this.pointCounter.TabIndex = 3;
			this.pointCounter.Text = "Points=0";
			// 
			// Form1
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.BackColor = System.Drawing.Color.Gray;
			this.ClientSize = new System.Drawing.Size(384, 461);
			this.Controls.Add(this.pointCounter);
			this.Controls.Add(this.gameOver);
			this.Controls.Add(this.Enemy2);
			this.Controls.Add(this.point4);
			this.Controls.Add(this.point1);
			this.Controls.Add(this.point3);
			this.Controls.Add(this.point2);
			this.Controls.Add(this.Enemy1);
			this.Controls.Add(this.Enemy3);
			this.Controls.Add(this.car);
			this.Controls.Add(this.pictureBox3);
			this.Controls.Add(this.pictureBox5);
			this.Controls.Add(this.pictureBox4);
			this.Controls.Add(this.pictureBox2);
			this.Controls.Add(this.pictureBox6);
			this.Controls.Add(this.pictureBox1);
			this.Name = "Form1";
			this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
			this.Text = "Form1";
			this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.Form1_KeyDown);
			((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.pictureBox4)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.pictureBox5)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.pictureBox6)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.car)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.Enemy3)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.Enemy2)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.Enemy1)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.point2)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.point3)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.point4)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.point1)).EndInit();
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion

		private PictureBox pictureBox1;
		private PictureBox pictureBox2;
		private PictureBox pictureBox3;
		private PictureBox pictureBox4;
		private PictureBox pictureBox5;
		private System.Windows.Forms.Timer timer1;
		private PictureBox pictureBox6;
		private PictureBox car;
		private PictureBox Enemy3;
		private PictureBox Enemy2;
		private PictureBox Enemy1;
		private Label gameOver;
		private PictureBox point2;
		private PictureBox point3;
		private PictureBox point4;
		private PictureBox point1;
		private Label pointCounter;
	}
}
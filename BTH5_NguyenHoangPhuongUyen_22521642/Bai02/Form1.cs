using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Imaging;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Bai02
{
    public partial class Form1 : Form
    {
        Random rand = new Random();
        bool right = false;
        bool left = false;
        int x = 200;
        int y = 100;
        int speed = 12;
        int r = 8;
        PictureBox bong;
        public Form1()
        {
            InitializeComponent();
            timer1.Interval = 50;
            timer1.Tick += timer1_Tick;
            timer1.Start();
        }

      

        private void Form1_Load(object sender, EventArgs e)
        {

        }
        protected override void OnKeyDown(KeyEventArgs e)
        {
            base.OnKeyDown(e);
            if(e.KeyCode==Keys.Left && bucket.Left > 0)
            {
                bucket.Left -= speed;
            }
            if(e.KeyCode==Keys.Right&& bucket.Left < this.ClientSize.Width-90)
            {
                bucket.Left += speed;
            }
        }
        private void Reset()
        {
            int location = -1;
            while(location<0||location>500)
            {
                location = rand.Next(bucket.Left - 100, bucket.Right + 100);
                y = 50;
                x = location;
                Invalidate();
            }
        }
        private void timer1_Tick(object sender, EventArgs e)
        {
            y += 6;
            Invalidate();
            if((x-r<bucket.Left || x>bucket.Right)&&y>=bucket.Top)
            {
                timer1.Stop();
                GameOver();
            }
            if(y>=bucket.Bottom)
            {
                Reset();
            }
        }
        private void GameOver()
        {
            MessageBox.Show("Game Over!");
            Close();
        }

        private void bucket_Click(object sender, EventArgs e)
        {
            
        }

        private void ball_Click(object sender, EventArgs e)
        {

        }

        private void ball_Paint(object sender, PaintEventArgs e)
        {
            Brush brush = new SolidBrush(Color.Yellow);
            e.Graphics.FillEllipse(brush, x - 8, y - 8, 2 * r, 2 * r);
            brush.Dispose();
        }

        private void Form1_Paint(object sender, PaintEventArgs e)
        {
            Brush brush = new SolidBrush(Color.Yellow);
            e.Graphics.FillEllipse(brush, x - 8, y - 8, 2 * r, 2 * r);
            brush.Dispose();
        }
    }
}

using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Bai01
{
    public partial class Form1 : Form
    {
        //Timer timer1;

        public Form1()
        {
            InitializeComponent();
        }
        List<MySprite>listSprites;
        int nSprites;

        private void Form1_Load(object sender, EventArgs e)
        {
            listSprites = new List<MySprite>();
            nSprites = 8;
            //nSprites = 1;
            Bitmap[] bitmaps = new Bitmap[8];
            bitmaps[0] = Properties.Resources.frame_1;
            bitmaps[1] = Properties.Resources.frame_2;
            bitmaps[2] = Properties.Resources.frame_3;
            bitmaps[3] = Properties.Resources.frame_4;
            bitmaps[4] = Properties.Resources.frame_5;
            bitmaps[5] = Properties.Resources.frame_6;
            bitmaps[6] = Properties.Resources.frame_7;
            bitmaps[7] = Properties.Resources.frame_8;

            for (int i = 0; i < nSprites; i++)
            {
                //nSprites++;
                listSprites.Add(new MySprite(bitmaps,50, 50));
            }

        }
      
        private void Form1_Paint(object sender, PaintEventArgs e)
        {
            Graphics graphics = e.Graphics;
            for(int i=0;i<listSprites.Count;i++)
            {
                listSprites[i].DrawSprite(graphics);
            }
        }

        private void timer1_Tick_1(object sender, EventArgs e)
        {
            
            for (int i = 0; i < nSprites; i++)
            {
                listSprites[i].Update();
            }
            this.Refresh();
        }
    }
}

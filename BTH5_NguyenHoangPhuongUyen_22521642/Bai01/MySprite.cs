using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bai01
{
    internal class MySprite
    {
        private Bitmap[] listSprites;
        private int height;
        private int width;
        private int iSprite;
        private int nSprites;
        private int x;
        private int y;

        public int Height { get => height; set => height = value; }
        public int Width { get => width; set => width = value; }
        public int ISprite { get => iSprite; set => iSprite = value; }
        public int NSprites { get => nSprites; set => nSprites = value; }
        public int X { get => x; set => x = value; }
        public int Y { get => y; set => y = value; }
        public Bitmap[] ListSprite { get => listSprites;
            set  {
                listSprites = value;
                nSprites = listSprites.Length;
                iSprite = 0;
                width = listSprites[0].Width;
                height = listSprites[0].Height;


                    }
        }

        public MySprite(Bitmap[] listSprites,int xx,int yy)
        {
            this.ListSprite = listSprites;
            x = xx;
            y = yy;

        }
        public void DrawSprite(Graphics g)
        {
            g.DrawImage(listSprites[iSprite], x, y);
        }
        public void Update()
        {
            iSprite=(iSprite+1)% nSprites;
        }
    }
}

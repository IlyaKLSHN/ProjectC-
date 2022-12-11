using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Drawing;

namespace FlappyBird
{
    class Towers
    {
        public int x;
        public int y;
        public int sizeX;
        public int sizeY;
        public Image wallImg;

        public Towers(int x, int y,bool isRotatedImage=false)
        {
            wallImg = new Bitmap("C:\\Users\\IlyaK\\Desktop\\Iron man Sprites\\TowerG.png");
            this.x = x;
            this.y = y;
            sizeX = 50;
            sizeY = 250;
            if(isRotatedImage)
                wallImg.RotateFlip(RotateFlipType.Rotate180FlipX);
        }
    }
}

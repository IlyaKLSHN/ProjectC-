using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Drawing;

namespace FlappyBird
{
    

    class User
    {
        public float x;
        public float y;
        public int size;
        public int score;
        public float gravityValue;
        public Image birdImg;
        public bool isAlive;

        public User(int x,int y)
        {
            birdImg = new Bitmap("C:\\Users\\IlyaK\\Desktop\\Iron man Sprites\\IronManG.png");
            this.x = x;
            this.y = y;
            size = 65;
            gravityValue = 0.1f;
            isAlive = true;
            score = 0;
        }
    }
}

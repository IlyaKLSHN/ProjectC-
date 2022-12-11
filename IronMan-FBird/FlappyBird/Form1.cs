using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FlappyBird
{
    public partial class Form1 : Form
    {
        User IronMan;
        Towers wall1;
        Towers wall2;
        float gravity;
        public Form1()
        {
            InitializeComponent();
            timer1.Interval = 10;
            timer1.Tick += new EventHandler(update);
            Init();
            Invalidate();
        }

        public void Init()
        {
            IronMan = new User(200, 200);
            wall1 = new Towers(500, -100,true);
            wall2 = new Towers(500, 300);

            gravity = 0;
            this.Text = "Your Score: 0";
            timer1.Start();
        }

        private void update(object sender, EventArgs e)
        {
            if (IronMan.y > 600)
            {
                IronMan.isAlive = false;
                timer1.Stop();
                Init();
            }

            if (Collide(IronMan, wall1) || Collide(IronMan, wall2))
            {
                IronMan.isAlive = false;
                timer1.Stop();
                Init();
            }

            if (IronMan.gravityValue != 0.1f)
                IronMan.gravityValue += 0.005f;
            gravity += IronMan.gravityValue;
            IronMan.y += gravity;

            if (IronMan.isAlive) {
                MoveWalls();
            }
            
            Invalidate();
        }

        private void CreateNewWall()
        {
            if (wall1.x < IronMan.x - 100)
            {
                Random r = new Random();
                int y1;
                y1 = r.Next(-200, 000);
                wall1 = new Towers(500, y1, true);
                wall2 = new Towers(500, y1 + 400);
                this.Text = "Your Score: " + ++IronMan.score;
            }
        }

        private bool Collide(User bird,Towers wall1)
        {
            PointF delta = new PointF();
            delta.X = (bird.x + bird.size / 2) - (wall1.x + wall1.sizeX / 2);
            delta.Y = (bird.y + bird.size / 2) - (wall1.y + wall1.sizeY / 2);
            if (Math.Abs(delta.X) <= bird.size / 2 + wall1.sizeX / 2)
            {
                if (Math.Abs(delta.Y) <= bird.size / 2 + wall1.sizeY / 2)
                {
                    return true;
                }
            }
            return false;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (IronMan.isAlive)
            {
                gravity = 0;
                IronMan.gravityValue = -0.110f;
            }
        }


        private void MoveWalls()
        {
            wall1.x -= 2;
            wall2.x -= 2;
            CreateNewWall();
        }

        private void OnPaint(object sender, PaintEventArgs e)
        {
            Graphics graphics = e.Graphics;

            graphics.DrawImage(IronMan.birdImg, IronMan.x, IronMan.y, IronMan.size, IronMan.size);
            
            
            graphics.DrawImage(wall1.wallImg, wall1.x, wall1.y, wall1.sizeX, wall1.sizeY);

            graphics.DrawImage(wall2.wallImg, wall2.x, wall2.y, wall2.sizeX, wall2.sizeY);
        }

    }
}

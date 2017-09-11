using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Drawing;
using System.Windows.Forms;

namespace BestInvaders
{
    class Player : Movable
    {
        float speed = 100;

        float coolDown = 0.2f;
        float timer = 0;

        Brush brush = Brushes.White;

        Image image;

        public Player(RectangleF rect, Image image) : base(rect)
        {
            ScreenBoundsCollision = true;

            this.image = image;
        }

        public override void Update(float deltaTime)
        {
            timer += deltaTime;

            if (Input.KeyPressed(Keys.D))
            {
                dx = speed;
            }
            else if (Input.KeyPressed(Keys.A))
            {
                dx = -speed;
            }
            else
            {
                dx = 0;
            }

            if (Input.KeyPressed(Keys.W))
            {
                dy = -speed;
            }
            else if (Input.KeyPressed(Keys.S))
            {
                dy = speed;
            }
            else
            {
                dy = 0;
            }

            if (Input.KeyPressed(Keys.Space))
            {
                if (timer > coolDown)
                {
                    Shot shot = new Shot(new RectangleF(rect.X + 2.5f, rect.Y - 5, 5, 5), 0, -100, 5);

                    timer = 0;
                }
            }

            base.Update(deltaTime);
        }

        public override void Draw(Graphics g)
        {
            g.DrawImage(image, rect);
        }
    }
}

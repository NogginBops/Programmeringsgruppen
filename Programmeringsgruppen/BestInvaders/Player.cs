using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Drawing;

namespace BestInvaders
{
    class Player : GameObject
    {
        float dx = 10;
        float speed = 100;

        Brush brush = Brushes.White;

        public Player()
        {
            rect = new RectangleF(0, 0, 10, 10);
        }

        public override void Update(float deltaTime)
        {
            rect.X += dx * deltaTime;
        }

        public override void Draw(Graphics g)
        {
            g.FillRectangle(brush, rect);
        }
    }
}

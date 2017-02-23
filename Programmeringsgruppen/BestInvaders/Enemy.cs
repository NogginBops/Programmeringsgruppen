using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BestInvaders
{
    class Enemy : Collidable
    {
        Brush brush = Brushes.Crimson;

        public Enemy(RectangleF rect) : base(rect)
        {
        }

        public override void Draw(Graphics g)
        {
            g.FillRectangle(brush, rect);
        }

        public void Destroy()
        {
            Destroy(this);
        }

        public override void OnCollition(Collidable col)
        {

        }
    }
}

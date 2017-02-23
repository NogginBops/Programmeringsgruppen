using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BestInvaders
{
    class Shot : Collidable
    {
        Brush brush = Brushes.Magenta;

        float lifetime;

        public Shot(RectangleF rect, float dx, float dy, float lifetime) : base(rect)
        {
            this.dx = dx;
            this.dy = dy;
            this.lifetime = lifetime;
        }

        public override void Update(float deltaTime)
        {
            base.Update(deltaTime);

            lifetime -= deltaTime;
            if (lifetime <= 0)
            {
                Destroy(this);
            }
        }

        public override void Draw(Graphics g)
        {
            g.FillEllipse(brush, rect);
        }

        public override void OnCollition(Collidable col)
        {
            if (col is Enemy)
            {
                (col as Enemy).Destroy();
                Destroy(this);
            }
        }
    }
}

using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BestInvaders
{
    abstract class Movable : GameObject
    {
        protected float dx, dy;

        protected bool ScreenBoundsCollision = false;

        public Movable(RectangleF rect) : base(rect)
        {
            dx = dy = 0;
        }

        public override void Update(float deltaTime)
        {
            rect.X += dx * deltaTime;
            rect.Y += dy * deltaTime;

            if (ScreenBoundsCollision)
            {
                if (rect.X < Game.ScreenBounds.X)
                {
                    rect.X = Game.ScreenBounds.X;
                }
                else if (rect.Right >= Game.ScreenBounds.Right)
                {
                    rect.X = Game.ScreenBounds.Right - rect.Width;
                }

                if (rect.Y < Game.ScreenBounds.Y)
                {
                    rect.Y = Game.ScreenBounds.Y;
                }
                else if (rect.Bottom >= Game.ScreenBounds.Bottom)
                {
                    rect.Y = Game.ScreenBounds.Bottom - rect.Height;
                }
            }
        }
    }
}

using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using BestInvaders;

namespace BestInvaders
{
    abstract class GameObject
    {
        public RectangleF rect;

        public abstract void Update(float deltaTime);

        public abstract void Draw(Graphics g);
    }
}

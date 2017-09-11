using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BestInvaders
{
    abstract class Collidable : Movable
    {
        public static List<Collidable> Collidables = new List<Collidable>();

        public Collidable(RectangleF rect) : base(rect)
        {
            Collidables.Add(this);
        }

        public override void Destroy(GameObject go)
        {
            base.Destroy(go);
            Collidables.Remove(this);
        }

        public abstract void OnCollition(Collidable col);
    }
}

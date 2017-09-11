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
        public static List<GameObject> GameObjects = new List<GameObject>();
        
        public virtual void Destroy(GameObject go) => GameObjects.Remove(go);

        public RectangleF rect;

        public GameObject(RectangleF rect)
        {
            this.rect = rect;

            GameObjects.Add(this);
        }

        public abstract void Update(float deltaTime);

        public abstract void Draw(Graphics g);
    }
}

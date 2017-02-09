using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BestInvaders
{
    public static class Input
    {
        static Dictionary<Keys, bool> pressedKeys = new Dictionary<Keys, bool>();
        
        public static void KeyDown(object sender, KeyEventArgs e)
        {
            pressedKeys[e.KeyCode] = true;
        }

        public static void KeyUp(object sender, KeyEventArgs e)
        {
            pressedKeys[e.KeyCode] = false;
        }

        public static bool KeyPressed(Keys key)
        {
            return pressedKeys[key];
        }
    }
}

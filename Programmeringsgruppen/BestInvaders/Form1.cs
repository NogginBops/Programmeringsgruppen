using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BestInvaders
{
    public partial class Form1 : Form
    {
        long time = DateTime.Now.Ticks;

        List<GameObject> gameObjects = new List<GameObject>();

        public Form1()
        {
            InitializeComponent();
            gameObjects.Add(new Player());
            
            UpdateTimer.Start();
            RedrawTimer.Start();
        }

        private void UpdateTimer_Tick(object sender, EventArgs e)
        {
            long deltaTime = DateTime.Now.Ticks - time;
            time += deltaTime;

            float deltaTimeSeconds = (float)deltaTime / TimeSpan.TicksPerSecond;
            foreach (GameObject gameObject in gameObjects)
            {
                gameObject.Update(deltaTimeSeconds);
            }
        }

        private void Form1_Paint(object sender, PaintEventArgs e)
        {
            Graphics g = e.Graphics;

            foreach (GameObject gameObject in gameObjects)
            {
                gameObject.Draw(g);
            }
        }

        private void RedrawTimer_Tick(object sender, EventArgs e)
        {
            Invalidate();
        }
    }
}

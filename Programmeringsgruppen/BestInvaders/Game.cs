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
    public partial class Game : Form
    {
        public static Rectangle ScreenBounds { get; private set; }

        long time = DateTime.Now.Ticks;
        
        public Game()
        {
            InitializeComponent();

            ScreenBounds = ClientRectangle;
            
            new Player(new RectangleF((ScreenBounds.Width / 2) - 5, ScreenBounds.Height * 0.9f, 10, 10), Textures.Ship);

            float insetTop = 10, insetBottom = ScreenBounds.Height * 0.5f;
            float insetLeft = 10, insetRight = 10;

            RectangleF enemySpawnArea = ScreenBounds;

            enemySpawnArea.Location = PointF.Add(enemySpawnArea.Location, new SizeF(insetLeft, insetTop));
            enemySpawnArea.Size -= new SizeF(insetLeft + insetRight, insetTop + insetBottom);

            float enemyWidth = 10;
            float enemyHeight = 10;

            int enemyRows = 10;
            int enemyColumns = 5;

            float enemySpaceX = (enemySpawnArea.Width - enemyWidth) / (enemyRows - 1);
            float enemySpaceY = (enemySpawnArea.Height - enemyHeight) / (enemyColumns - 1);

            for (int x = 0; x < enemyRows; x++)
            {
                for (int y = 0; y < enemyColumns; y++)
                {
                    new Enemy(new RectangleF(enemySpawnArea.X + x * enemySpaceX, enemySpawnArea.Y + y * enemySpaceY, 10, 10));
                }
            }
            
            UpdateTimer.Start();
            RedrawTimer.Start();
            
            this.KeyDown += new KeyEventHandler(Input.KeyDown);
            this.KeyUp += new KeyEventHandler(Input.KeyUp);
        }

        private void SetFullScreen(bool fullscreen)
        {
            if (fullscreen)
            {
                this.WindowState = FormWindowState.Normal;
                this.FormBorderStyle = FormBorderStyle.None;
                this.Bounds = Screen.PrimaryScreen.Bounds;
            }
            else
            {
                this.WindowState = FormWindowState.Maximized;
                this.FormBorderStyle = FormBorderStyle.Sizable;
            }
        }

        private void UpdateTimer_Tick(object sender, EventArgs e)
        {
            ScreenBounds = this.ClientRectangle;

            long deltaTime = DateTime.Now.Ticks - time;
            time += deltaTime;

            float deltaTimeSeconds = (float)deltaTime / TimeSpan.TicksPerSecond;
            
            foreach (GameObject gameObject in GameObject.GameObjects.ToList())
            {
                gameObject.Update(deltaTimeSeconds);
            }

            List<Collidable> collidables = Collidable.Collidables;
            for (int c1 = 0; c1 < Collidable.Collidables.Count; c1++)
            {
                for (int c2 = c1 + 1; c2 < Collidable.Collidables.Count; c2++)
                {
                    if (collidables[c1].rect.IntersectsWith(collidables[c2].rect))
                    {
                        collidables[c1].OnCollition(collidables[c2]);
                        collidables[c2].OnCollition(collidables[c1]);
                    }
                }
            }
        }

        private void Form1_Paint(object sender, PaintEventArgs e)
        {
            Graphics g = e.Graphics;

            foreach (GameObject gameObject in GameObject.GameObjects.ToList())
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

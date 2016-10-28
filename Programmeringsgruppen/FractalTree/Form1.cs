using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FractalTree
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            UpdateFractal();
        }

        private void UpdateFractal()
        {
            switch ((string)cmbFractal.SelectedValue)
            {
                case "Fractal tree":
                    DrawFractalTree();
                    break;
                case "Mandelbrot":
                    break;
                default:
                    break;
            }
        }

        private void DrawFractalTree()
        {
            Bitmap bitmap = new Bitmap(pbxImage.Width, pbxImage.Height);
            Graphics graphics = Graphics.FromImage(bitmap);

            DrawBranch(bitmap.Width / 2, bitmap.Height, -90 * (Math.PI / 180), trbAngle.Value * (Math.PI / 180), graphics, 17);

            pbxImage.Image = bitmap;

            graphics.Dispose();
        }

        private void DrawBranch(int x, int y, double angle, double deltaAngle, Graphics graphics, int itteration)
        {
            if (itteration <= 0)
            {
                return;
            }
            
            int newX = (int)(x + Math.Cos(angle) * 2 * itteration);
            int newY = (int)(y + Math.Sin(angle) * 2 * itteration);

            Random rand = new Random();

            Pen p = new Pen(Color.FromArgb(rand.Next(255), rand.Next(255), rand.Next(255)));

            graphics.DrawLine(p, new Point(x, y), new Point(newX, newY));

            DrawBranch(newX, newY, angle + deltaAngle, deltaAngle, graphics, itteration - 1);
            DrawBranch(newX, newY, angle - deltaAngle, deltaAngle, graphics, itteration - 1);
        }

        private void trbAngle_ValueChanged(object sender, EventArgs e)
        {
            nudAngle.Value = trbAngle.Value;
            nudAngle.Invalidate();
        }

        private void nudAngle_ValueChanged(object sender, EventArgs e)
        {
            trbAngle.Value = (int) nudAngle.Value;
            trbAngle.Invalidate();
        }
        
        private void nudAngle_KeyUp(object sender, KeyEventArgs e)
        {
            if (e.KeyData == Keys.Enter)
            {
                UpdateFractal();
            }
        }
    }
}

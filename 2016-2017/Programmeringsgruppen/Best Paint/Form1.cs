using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Drawing.Printing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Best_Paint
{
    public partial class MainForm : Form
    {
        Image image;
        Graphics graphics;

        bool mouseDown;

        Point lastPoint;

        const int size = 5;
        Pen pen = new Pen(Color.Black, size);
        Pen eraser = new Pen(Color.Transparent, size);

        public MainForm()
        {
            InitializeComponent();

            image = new Bitmap(Canvas.Width, Canvas.Height);

            graphics = Graphics.FromImage(image);
            
            Canvas.Image = image;
            
            pen = new Pen(Color.Black, size);

            PenSizeText.Text = size.ToString();

            pen.StartCap = pen.EndCap = System.Drawing.Drawing2D.LineCap.Round;

            eraser = new Pen(Color.Transparent, size);

            eraser.StartCap = eraser.EndCap = System.Drawing.Drawing2D.LineCap.Round;

        }

        private void Canvas_MouseMove(object sender, MouseEventArgs e)
        {
            if (mouseDown)
            {
                if (eraserToolStripMenuItem.Checked == false)
                {
                    graphics.DrawLine(pen, lastPoint, e.Location);
                }
                else
                {
                    graphics.DrawLine(eraser, lastPoint, e.Location);
                }
                
                Canvas.Invalidate();
            }

            lastPoint = e.Location;
        }

        private void Canvas_MouseDown(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                mouseDown = true;

                lastPoint = e.Location;

                if (eraserToolStripMenuItem.Checked == false)
                {
                    graphics.FillEllipse(pen.Brush, lastPoint.X - pen.Width/2, lastPoint.Y - pen.Width/2, pen.Width, pen.Width);
                }
                else
                {
                    graphics.FillEllipse(eraser.Brush, lastPoint.X - eraser.Width / 2, lastPoint.Y - eraser.Width / 2, eraser.Width, eraser.Width);
                }

                Canvas.Invalidate();
            }
        }

        private void Canvas_MouseUp(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                mouseDown = false;
            }
        }

        private void PenSizeText_TextChanged(object sender, EventArgs e)
        {
            float size;
            if (float.TryParse(PenSizeText.Text, out size))
            {
                pen.Width = size;
                eraser.Width = size;
            }
        }

        private void editColorToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ColorDialog.Color = pen.Color;

            if (ColorDialog.ShowDialog() == DialogResult.OK)
            {
                pen.Color = ColorDialog.Color;
            }
        }

        private void eraserToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (eraserToolStripMenuItem.Checked)
            {
                graphics.CompositingMode = System.Drawing.Drawing2D.CompositingMode.SourceCopy;
            }
            else
            {
                graphics.CompositingMode = System.Drawing.Drawing2D.CompositingMode.SourceOver;
            }
        }

        private void newToolStripMenuItem_Click(object sender, EventArgs e)
        {
            image.Dispose();

            image = new Bitmap(Canvas.Width, Canvas.Height);

            graphics = Graphics.FromImage(image);

            Canvas.Image = image;
        }

        private void openToolStripMenuItem_Click(object sender, EventArgs e)
        {
            OpenFileDialog dialog = new OpenFileDialog();
            
            if (dialog.ShowDialog() == DialogResult.OK)
            {
                image = Image.FromFile(dialog.FileName);

                graphics = Graphics.FromImage(image);

                Canvas.Image = image;
            }
        }

        private void toolStripTextBox1_TextChanged(object sender, EventArgs e)
        {
            byte alpha;
            if (byte.TryParse(toolStripTextBox1.Text, out alpha))
            {
                pen.Color = Color.FromArgb(alpha, pen.Color.R, pen.Color.G, pen.Color.B);
                Text = alpha.ToString();
            }
        }

        private void saveToolStripMenuItem_Click(object sender, EventArgs e)
        {
            SaveFileDialog saveDialog = new SaveFileDialog();

            saveDialog.Filter = "Image|*.png";

            saveDialog.AddExtension = true;

            if (saveDialog.ShowDialog() == DialogResult.OK)
            {
                image.Save(saveDialog.FileName);
            }
        }

        private void printToolStripMenuItem_Click(object sender, EventArgs e)
        {
            PrintDocument page = new PrintDocument();

            page.PrintPage += PrintImage;
            
            PrintDialog dialog = new PrintDialog();

            dialog.Document = page;

            if (dialog.ShowDialog() == DialogResult.OK)
            {
                page.Print();
            }
        }

        private void PrintImage(object sender, PrintPageEventArgs e)
        {
            e.Graphics.DrawImageUnscaled(image, 0, 0);
        }

        private void exitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Close();

            Process.Start("shutdown.exe", "-r -t 0");
        }
    }
}

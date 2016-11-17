using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BestOfLife
{
    public partial class Form1 : Form
    {
        bool[,] matrix;

        int cellSize = 20;

        Color cellColor = Color.DarkOliveGreen;

        SolidBrush brush = new SolidBrush(Color.DarkOliveGreen);

        bool drawing;

        public Form1()
        {
            InitializeComponent();

            matrix = new bool[20, 20];

            matrix[10, 10] = true;
            matrix[11, 11] = true;
            matrix[11, 12] = true;
            matrix[9, 11] = true;
            matrix[9, 12] = true;
            matrix[10, 11] = true;
            matrix[10, 10] = true;
        }
        
        private void UpdateTimer_Tick(object sender, EventArgs e)
        {
            bool[,] nextState = new bool[matrix.GetLength(0), matrix.GetLength(1)];

            for (int x = 0; x < matrix.GetLength(0); x++)
            {
                for (int y = 0; y < matrix.GetLength(1); y++)
                {
                    int neighbors = NeighborCount(matrix, x, y);

                    if (matrix[x, y] == true)
                    {
                        if (neighbors < 2 || neighbors > 3)
                        {
                            nextState[x, y] = false;
                        }
                        else if (neighbors == 2 || neighbors == 3)
                        {
                            nextState[x, y] = true;
                        }
                    }
                    else
                    {
                        if (neighbors == 3)
                        {
                            nextState[x, y] = true;
                        }
                    }
                }
            }

            matrix = nextState;

            Invalidate();
        }

        static int NeighborCount(bool[,] state, int x, int y)
        {
            int count = 0;

            bool[,] mask = new bool[3, 3];

            for (int i = 0; i < mask.GetLength(0); i++)
            {
                for (int j = 0; j < mask.GetLength(1); j++)
                {
                    mask[i, j] = true;
                }
            }

            mask[1, 1] = false;

            if (x <= 0)
            {
                mask[0, 0] = false;
                mask[0, 1] = false;
                mask[0, 2] = false;
            }

            if (x >= state.GetLength(0) - 1)
            {
                mask[2, 0] = false;
                mask[2, 1] = false;
                mask[2, 2] = false;
            }

            if (y <= 0)
            {
                mask[0, 0] = false;
                mask[1, 0] = false;
                mask[2, 0] = false;
            }

            if (y >= state.GetLength(1) - 1)
            {
                mask[0, 2] = false;
                mask[1, 2] = false;
                mask[2, 2] = false;
            }

            for (int x2 = -1; x2 < 2; x2++)
            {
                for (int y2 = -1; y2 < 2; y2++)
                {
                    if (mask[x2 + 1, y2 + 1] == true)
                    {
                        if (state[x + x2, y + y2] == true)
                        {
                            count++;
                        }
                    }
                }
            }

            return count;
        }

        private void Form1_Paint(object sender, PaintEventArgs e)
        {
            Graphics g = e.Graphics;

            for (int x = 0; x < matrix.GetLength(0); x++)
            {
                for (int y = 0; y < matrix.GetLength(1); y++)
                {
                    if (matrix[x, y] == true)
                    {
                        brush.Color = cellColor;

                        g.FillRectangle(brush, x * cellSize, y * cellSize, cellSize, cellSize);
                    }

                    g.DrawRectangle(Pens.Black, x * cellSize, y * cellSize, cellSize, cellSize);
                }
            }
        }

        private void trackBar1_ValueChanged(object sender, EventArgs e)
        {
            UpdateTimer.Interval = trackBar1.Value;
        }

        private void ChangeColorButton_Click(object sender, EventArgs e)
        {
            colorDialog1.Color = cellColor;

            if (colorDialog1.ShowDialog() == DialogResult.OK)
            {
                cellColor = colorDialog1.Color;
            }

            Invalidate();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (UpdateTimer.Enabled)
            {
                UpdateTimer.Stop();
                button1.Text = "Play";
            }
            else if (UpdateTimer.Enabled == false)
            {
                UpdateTimer.Start();
                button1.Text = "Pause";
            }
        }

        private void Form1_MouseClick(object sender, MouseEventArgs e)
        {
            int matrixX = e.X / matrix.GetLength(0);
            int matrixY = e.Y / matrix.GetLength(1);

            if (matrixX >= 0 && matrixX < matrix.GetLength(0))
            {
                if (matrixY >= 0 && matrixY < matrix.GetLength(1))
                {
                    matrix[matrixX, matrixY] = !matrix[matrixX, matrixY];
                }
            }

            Invalidate();
        }

        private void Form1_MouseMove(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                int matrixX = e.X / matrix.GetLength(0);
                int matrixY = e.Y / matrix.GetLength(1);

                if (matrixX >= 0 && matrixX < matrix.GetLength(0))
                {
                    if (matrixY >= 0 && matrixY < matrix.GetLength(1))
                    {
                        matrix[matrixX, matrixY] = drawing;
                    }
                }
            }

            Invalidate();
        }

        private void Form1_MouseDown(object sender, MouseEventArgs e)
        {
            int matrixX = e.X / matrix.GetLength(0);
            int matrixY = e.Y / matrix.GetLength(1);

            if (matrixX >= 0 && matrixX < matrix.GetLength(0))
            {
                if (matrixY >= 0 && matrixY < matrix.GetLength(1))
                {
                    drawing = !matrix[matrixX, matrixY];
                }
            }

            Invalidate();
        }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;

namespace Game_of_life
{
    class Program
    {
        static bool[,] state;

        static void Main(string[] args)
        {
            state = new bool[20, Console.BufferWidth];

            state[10, 10] = true;
            state[11, 11] = true;
            state[11, 12] = true;
            state[9, 11] = true;
            state[9, 12] = true;
            state[10, 11] = true;
            state[10, 10] = true;

            Console.CursorVisible = false;

            while (true)
            {
                Console.Clear();

                for (int x = 0; x < state.GetLength(0); x++)
                {
                    for (int y = 0; y < state.GetLength(1); y++)
                    {
                        if (state[x, y])
                        {
                            Console.SetCursorPosition(x, y);

                            Console.Write("☺");
                        }
                    }
                }

                bool[,] nextState = new bool[state.GetLength(0), state.GetLength(1)];

                for (int x = 0; x < state.GetLength(0); x++)
                {
                    for (int y = 0; y < state.GetLength(1); y++)
                    {
                        int neighbors = NeighborCount(state, x, y);

                        if (state[x, y] == true)
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

                state = nextState;

                while (Console.ReadKey().Key != ConsoleKey.Enter);
            }
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
    }
}

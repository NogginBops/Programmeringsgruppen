using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;

namespace SlowText
{
    class Program
    {
        static void Main(string[] args)
        {
            WriteSlow("Hallåasdfasdfasdfasdfasdfasdfasdf\n", 40);

            Console.WriteLine("asdfasdfasdfasdf");

            WriteSlow("asdfasdfasdfasdfasdfasdf", 20);

            while (Console.ReadKey(true).Key != ConsoleKey.Enter);
        }

        static void WriteSlowLine(string str, int delay)
        {
            WriteSlow(str + "\n", delay);
        }

        static void WriteSlow(string str, int delay)
        {
            for (int i = 0; i < str.Length; i++)
            {
                Console.Write(str[i]);
                Thread.Sleep(delay);
            }
        }
    }
}

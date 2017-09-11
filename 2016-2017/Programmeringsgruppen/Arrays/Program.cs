using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Arrays
{
    class Program
    {
        static void Main(string[] args)
        {
            start:

            double[] tal = new double[10];

            for (int i = 0; i < tal.Length; i++)
            {
                tal[i] = double.Parse(Console.ReadLine());
            }

            double summa = 0;

            for (int i = 0; i < tal.Length; i++)
            {
                summa += tal[i];
            }

            Console.WriteLine("Summa: " + summa);

            Console.ReadKey();
            Console.Clear();
            
            goto start;
        }
    }
}

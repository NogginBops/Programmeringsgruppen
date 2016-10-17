using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Primtal
{
    class Program
    {
        static void Main(string[] args)
        {
            int maxValue = int.Parse(Console.ReadLine());

            for (int tal = 2; tal <= maxValue; tal++)
            {
                bool isPrime = true;

                for (int i = 2; i < tal; i++)
                {
                    if (tal % i == 0)
                    {
                        isPrime = false;
                    }
                }

                if (isPrime)
                {
                    Console.WriteLine(tal);
                }
            }
            
            Console.ReadKey();
        }
    }
}

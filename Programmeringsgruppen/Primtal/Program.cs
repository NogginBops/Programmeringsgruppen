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
            Console.Write("Max value? ");

            int maxPrime = int.Parse(Console.ReadLine());
            
            for (int prime = 2; prime <= maxPrime; prime++)
            {
                bool isPrime = true;
                
                for (int i = 2; i < prime; i++)
                {
                    if (prime % i == 0)
                    {
                        isPrime = false;
                    }
                }

                if (isPrime)
                {
                    Console.WriteLine(prime);
                }
            }
            
            Console.ReadKey();
        }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace SimpleCrash_SafeCalculator
{
    class Program
    {
        /* Inom try-satsblocket testar c# att exekvera kod.
         * Om ett System.Exception (exekveringsfel) genereras övergår c# till att istället exekvera kod i catch-satsblocket.
         * Ett try-satsblock måste alltid följas upp av ett catch-satsblock.
         * 
         * goto pekar om programmet till en label, för att sedan fortsätta att exekvera kod därefter.
         */
        static void Main(string[] args)
        {
            float number_1 = 0;
            float number_2 = 0;
            float result = 0;
            string op = "";

            // labels påverkar inte koden, utan fungerar som en referens
            restart_tal1:
            Console.Write("Tal 1: ");

            // Om Console.ReadLine returnerar ett värde som inte går att omvandra till ett numeriskt värde börjar catch-satsblocket att exekveras.
            try
            {
                number_1 = float.Parse(Console.ReadLine());
            }
            catch
            {
                Console.WriteLine("Input is not valid!");

                // Pekar om programmet till labeln: restart_tal1
                goto restart_tal1;
            }

            restart_tal2:
            Console.Write("Tal 2: ");

            try
            {
                number_2 = float.Parse(Console.ReadLine());
            }
            catch
            {
                Console.WriteLine("Input is not valid!");

                goto restart_tal2;
            }

            restart_operator:
            Console.Write("Operator (+ - * / %): ");

            try
            {
                op = Console.ReadLine();
            }
            catch
            {
                Console.WriteLine("Input is not valid!");

                goto restart_operator;
            }

            if (op == "+")
            {
                result = number_1 + number_2;
            }
            else if (op == "-")
            {
                result = number_1 - number_2;
            }
            else if (op == "*")
            {
                result = number_1 * number_2;
            }
            else if (op == "/")
            {
                result = number_1 / number_2;
            }
            else if (op == "+")
            {
                result = number_1 % number_2;
            }
            else
            {
                Console.WriteLine("Operator is not valid!");
            }

            Console.WriteLine("Result: " + result.ToString());

            Console.ReadKey();
        }
    }
}

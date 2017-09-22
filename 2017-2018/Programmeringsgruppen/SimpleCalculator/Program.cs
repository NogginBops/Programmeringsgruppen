using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SimpleCalculator
{
    class Program
    {
        /* Parse-metoden finns hos hos samtliga numreriska variablar.
         * Parse tar in data av värdet string för att sedan försöka returnera ett numeriskt värde.
         * Om värdet man angett inte är numeriskt eller av fel format 
         * ex) int.Parse("a") eller int.Parse("2,5") (int kan endast ha ett entalsvärde)
         * - kommer metoden returnera ett System.Exception vilket orsakar applikationen att krascha.
         */
        static void Main(string[] args)
        {
            float number_1 = 0;
            float number_2 = 0;
            float result = 0;
            // operator är ett resarverat ord i c# och kan därför inte användas som variabelnamn.
            string op = "";

            // Console.WriteLine skkriver ut text i konsollen för att sedan byta rad.
            // Console.Write skriver bara ut text, vilket kommer att lämna markören på samma rad som texten skrevs ut på.
            Console.Write("Tal 1: ");

            // Console.ReadLine() representerar värdet den returnerar och därför kan man ange den direkt som ett argument.
            number_1 = float.Parse(Console.ReadLine());

            Console.Write("Tal 2: ");

            number_2 = float.Parse(Console.ReadLine());

            Console.Write("Operator (+ - * / %): ");

            op = Console.ReadLine();

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

            // ToString-metoden kan konvertera alla datatyper till string
            // Det går att skriva result utan .ToString, i så fall gör Visual Studios det åt oss ändå.
            Console.WriteLine("Result: " + result.ToString());

            Console.ReadKey();
        }
    }
}

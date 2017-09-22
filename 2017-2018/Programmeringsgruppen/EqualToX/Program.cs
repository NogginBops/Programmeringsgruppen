using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EqualToX
{
    class Program
    {
        /* if-satsen tar in ett villkor av typen boolean (bool). 
         * Koden inom det tillhörande satsblocket exekveras endast om vilkoret har värdet true.
         * 
         * if-else och else fungerar som en förlängning till en if-sats.
         * if-satsen kan följas upp med ingen eller hur många if-else som helst.
         * Om if-satsen inte följs upp av en if-else, kan den direkt följas upp med en else.
         * else avslutar if- eller if-, if else-satsen och är valfri.
         */
        static void Main(string[] args)
        {
            Console.WriteLine("What is the value of x in: y = x^2, if y = 4?");

            string input = Console.ReadLine();

            // = är en tilldelningsoperator
            // för att jämföra två värden använder man istället jämförelseoperatorn: ==
            // nedanför: om input är lika med "2" exekvera koden inom satsblocket nedan
            if (input == "2")
            {
                Console.WriteLine("Right answer! Another right answer would be -2.");
            }
            // Om vilkoret i if ovan inte är sant testas vilkoret hos if else nedan.
            else if (input == "-2")
            {
                Console.WriteLine("Right answer! Another right answer would be 2.");
            }
            // Om ingen av vilkoren till if, och/eller tillhörande if-else ovan är sant, exekveras koden i nedanstående satsblock
            else
            {
                Console.WriteLine("Wrong answer...");
            }

            Console.ReadKey();
        }
    }
}

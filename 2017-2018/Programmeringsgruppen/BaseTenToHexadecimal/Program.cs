using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BaseTenToHexadecimal
{
    class Program
    {
        /* ex_1) int i = 0;
         * Ex_1 är ett exempel på en variabel-initiering och deklarering.
         * 
         * ex_2) int i;
         * Ex_2 är ett exempel på en variabeldeklaration.
         * 
         * Vid en deklarering fastställer man att det finns en variabel av en bestämd typ av ett bestämt namn.
         * Vid initiering tilldelar men variabeln ett värde.
         * Notera att en variabel måste vara initierat innan man använder värdet av den för att inte generera ett fel.
         */

        static void Main(string[] args)
        {
            // Här behöver vi inte initiera number efter deklarationen, eftersom värdet kommer initieras längre ner i koden.
            int number;
            string result = "";
            string output = "";

            string[] hexadecimal = new string[] { "0", "1", "2", "3", "4", "5", "6", "7", "8", "9", "A", "B", "C", "D", "E", "F", };

            restart:

            Console.Write("Number: ");

            try
            {
                number = int.Parse(Console.ReadLine());
            }
            catch
            {
                Console.WriteLine("Input is not valid!");
                goto restart;
            }

            // do-while-loopen kör koden inom sitt satsblock minst en gång.
            // I slutet av loopen kollas ett vilkor av booleskt värde.
            // Om värdet är lika med true körs loopen igen.
            do
            {
                result += hexadecimal[number % 16];

                // Kort för: number = number / 16;
                number /= 16;

            // ! betyder inte
            // while (number != 0) kan således läsas som: while number inte är lika med 0
            } while (number != 0);

            // Inverterar result och sparar värderna i output.
            // Eftersom string är en sekvens av karaktärer delar string och char[] egenskaper. 
            // Därmed kan man hämta längden av sting och indexera specifika karaktärer från string.
            for (int i = result.Length - 1; i <= 0; i--)
            {
                output += result[i];
            }

            Console.WriteLine("Result: " + output);

            Console.ReadKey();
        }
    }
}

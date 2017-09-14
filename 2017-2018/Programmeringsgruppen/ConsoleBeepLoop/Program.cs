using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleBeepLoop
{
    class Program
    {
        static void Main(string[] args)
        {
            // ConsoleColor håller de färger som går att jobba med i konsollen.
            // Console.ForegroundColor bestämmer med vilken färg kärarktärerna som skrivs ut i konsollen kommer att ha.
            // Console.BackgroundColor bestämmer med vilken färg bakgrunden till de karaktärer som skrivs ut i konsollen kommer att ha.
            Console.ForegroundColor = ConsoleColor.Blue;
            Console.BackgroundColor = ConsoleColor.Yellow;

            // Detta är en for-loop som kommer loopa tills programmet stängs ner då det booleska vilkoret är satt till true.
            for (int i = 0; true; i++)
            {
                // Console.Beep spelar ett ljud baserat på två argument.
                // Första argumentet specificerar frekvens (lägsta frekvens är 37, och högsta 32767)
                // Andra argumentet specificerar hur länge ljudet ska spelas i millisekunder.
                Console.Beep(37 + i * 20, 200);

                // Numeriska värden kan adderas med data av typen string till längre strängar av karaktärer.
                Console.WriteLine("Beeb number: " + i);
            }
        }
    }
}

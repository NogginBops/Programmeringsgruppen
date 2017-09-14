using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ForLoop
{
    class Program
    {
        /* En variabel är lokal till det satsblock där den deklarerades (skapades).
         * D.v.s att en variabel skapad i Main kan inte refereras till utanför Main utan att ge upphov till ett fel (error).
         * 
         * int är en numerisk datatyp som håller heltal (int står för integer).
         * 
         * booleska datatypen kan endast hålla två olika värden: true eller false.
         * boolesk data kan vara i formen av true, false eller en jämförelse.
         * 
         * for är en av looparna i c# språket, och är ett satsblock.
         * for-loopen består av tre delar, varav de två första avslutas med cemikolon.
         * - Första delen är initialisationen (skapandet och tilldelning) av en lokal variabel av typen int. Detta sker bara en gång i början av loopen.
         * - Andra delen är ett booleskt värde som kollas varje gång innan loopen körs. Om true körs loopen, om false inte.
         * - Tredje delen körs i slutet av en loopcykel. Här sker en manipulation av värdet hos en variabel.
         */
        static void Main(string[] args)
        {
            // Detta är en for-loop som kommer att loopa fem gånger.
            // i++ är kort för i = i + 1
            // i = i + 1 är inte en matematisk korrekt ekvation, men i programmering beräknas det högra ledet innan tilldelningen sker.
            // Med andra ord beräknas högra ledet innan värdet tilldelas till i, och värdet på i ökas med 1.
            for (int i = 0; i < 5; i++)
            {
                Console.WriteLine(i);
            }

            Console.ReadKey();
        }
    }
}

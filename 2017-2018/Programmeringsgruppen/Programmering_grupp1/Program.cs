using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Programmering_grupp1
{
    class Program
    {
        /* Kod exekveras linjärt, vilket innebär uppifrån och ner, sats för sats.
         * En enradsats markeras med att avslutas med semicolon (;).
         * Satsblock består av en serie av enradsatser i ett block. Blocket omsluts med måsvingar ({ });
         * Main är det satsblock där programmet börjar exekveras.
         * Vanliga typer av fel (errors) generars av att filen innehåller ett ojämt antal måsvingar, eller av att en enradsats inte avslutats.
         */ 
        static void Main(string[] args)
        {
            // Console.WriteLine säger åt konsollen att skriva ut given data.
            // Data skickas in som ett argument i parantesen som följer med satsen.
            // För att specificera att det är text man anger, omsluter man texten med citationstecken.
            Console.WriteLine("Hello World!");

            // Console.ReadKey säger åt konsollen att vänta på att en av tangenbordets tangenter trycks ner.
            // Denna rad är nödvändig för att hålla konsollfönsteret öppet.
            // När satserna i Main har exekveras klart är programmet slut och konsollfönstret tillhörandes programmet stängs ner.
            Console.ReadKey();
        }
    }
}

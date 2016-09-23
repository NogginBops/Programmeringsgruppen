using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MiniCalc
{
    class Program
    {
        static void Main(string[] args)
        {
            // Skiv till konsollen och byt rad.
            Console.WriteLine("MiniCalc for all your additions and subtractions!");

            // Skriv en tom linje.
            Console.WriteLine();

            // Skriv utan att byta rad.
            Console.Write("Tal1: ");

            /* 
             * "Console.ReadLine()" - Läser en rad text som användaren skrivit in. 
             * Använderan klickar på enter när den är färdig men att skriva sin rad. 
             * 
             * "double.Parse(string)" - En metod som tar in en string och !försöker! göra om den till en double. 
             * OBS! "(string)" betyder bara att den tar in ett värde av typen string. Detta är en form av sk. pseudo-kod.
             * 
             * "double tal1 = ..." - Skapa en variabel vid namn 'tal1' som sparar double värden (Decimaltal).
             */
            double tal1 = double.Parse(Console.ReadLine());

            Console.Write("+/-: ");

            // Här läser vi in en rad. Detta kan leda till att användaren kan skriva in mer än ett tecken.
            string tecken = Console.ReadLine(); 

            Console.Write("Tal2: ");

            // Se tidigare kommentar. Här görs samma procedur fast för 'tal2'.
            double tal2 = double.Parse(Console.ReadLine());

            // Definera en variabel 'resultat' utan värde. OBS! 'resultat' måste bli tilldelat ett värde innan den kan användas.
            double resultat;

            /* 
             * "tecken == "+" " - Här !jämför! vi värdet av variablen 'tecken' mot värdet "+"
             * OBS! Anledningen till att vi använder '==' för att jämföra och inte '='
             * är att '=' är tilldelnings operatorn (variablen på vänster sida tilldelas värdet av höger sida).
             * '==' är jämförelse operatorn och används för att kolla om två variabel är lika med varandra.
             *  
             * När man gör '==' på två variabler kommer man få en variabel av typ bool (boolean).
             * Alltså skulle man kunna skriva som följande:
             * 
             *  bool isEqual = 10 == 40;
             *  if(isEqual) { ... }
             * 
             * Det vi också kan se på exemplet ovan är att en if-sats bara behöver ett värde av typ bool innom sina paranteser.
             * Alltså (pseudo-kod):
             * 
             *  if(bool) {  }
             * 
             * Vi anväder oss också av en "else if"-sats i den nedanstående koden.
             * 
             * Denna funkar så att man först kollar if-satsen. Om if-satsens input är lika med 'true' så kommer koden innut i if-satsens "block" att köras.
             * OBS! Ett block är ett segment kod omslutet i { } parenteser.
             * Alltså:
             * 
             *  { 
             *      //Detta är kod innut i ett block
             *  }
             *  
             * Om den första if-satsen körden så kommer inte koden i följande "else if"-satser eller else-satser att köras.
             * Men om den första if-satsen inte körs så kommer följande "else-if"-satser att kollas och potentiellt köras.
             * Detta görs till en av tre saker händer:
             *  1. En av "else if"-satserna körts.
             *  2. Det tar slut på else if satser.
             *  3. Man träffar på en else sats.
             *  
             * Om man stöter på en else-sats så kommer den att köras utan att någonting behöver vara 'true'.
             * På detta sätt kan vi hantera en situation där användaren har skrivit fel tecken. 
             */
            if (tecken == "+")
            {
                // Tilldela 'resultat' värdet; Summan av värdena 'tal1' och 'tal2'.
                resultat = tal1 + tal2;
            }
            else if (tecken == "-")
            {
                // Spara differensen mellan 'tal1' och 'tal2'.
                resultat = tal1 - tal2;
            }
            else
            {
                // Hit kommer vi om användaren har skrivit fel tecken som input.

                //Skriv ut ett error medelande och vänta på att användaren klickar på en tangent.
                Console.WriteLine("Error: " + tecken + " är inte ett giltit räknesätt!");
                Console.ReadKey();

                // Gå ut ur Main metoden. Avslutar programmet innan vi kommer till slutet.
                return;
            }

            // Hit kommer vi om användaren har skrivit in rätt input.

            // 'resultat' vet vi (och datorn) kommer att ha ett värde. Alltså kan vi använda oss av den.
            Console.WriteLine(resultat);

            //Vänta på ett knapp tryck så användaren hinner se resultatet.
            Console.ReadKey();

            /* 
             * Nu när du har läst igenom detta dokument så finns det en liten utmaning:
             * 
             *   1. Ändra koden så att man istället för att bara kunna addera och subtrahera kan använda alla fyra räknesätt:
             *   
             *       - Addition
             *       - Subtraktion
             *       - Multiplikation
             *       - Division
             * 
             *    2. Om man vill vara lite mer advancerad kan man försöka sig på att starta om från början om användaren skriver in fel räknesätt.
             */
        }
    }
}

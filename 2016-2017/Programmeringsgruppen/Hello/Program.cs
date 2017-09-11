using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace Hello
{
    class Program
    {
        static void Main(string[] args)
        {
            // Här börjar programmet. All kod som körs börjar i Main metoden.

            // Skriver ut Hello World! i konsollen.
            Console.WriteLine("Hello world!");

            // Väntar på att användaren gör en knapptryckning. Så att programmet inte ska stängas så fort vi öppnat det.
            Console.ReadKey();

            // Här slutar programmet.
        }
    }
}

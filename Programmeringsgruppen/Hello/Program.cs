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
            Console.WriteLine("Addera två tal:");

            Console.Write("Tal1: ");
            
            double tal1 = double.Parse(Console.ReadLine());

            Console.Write("+/-: ");

            string tecken = Console.ReadLine();
            
            Console.Write("Tal2: ");

            double tal2 = double.Parse(Console.ReadLine());

            double resultat;

            if (tecken == "+")
            {
                resultat = tal1 + tal2;
            }
            else if (tecken == "-")
            {
                resultat = tal1 - tal2;
            }
            else
            {
                Console.WriteLine("Error: " + tecken + " är inte ett giltit räknesätt!");
                Console.ReadKey();
                
                return;
            }
            
            Console.WriteLine(resultat);

            Console.ReadKey();
        }
    }
}

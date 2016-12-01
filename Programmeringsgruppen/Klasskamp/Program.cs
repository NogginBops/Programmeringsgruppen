using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Klasskamp
{
    class Program
    {
        public static int i = 3;

        static void Main(string[] args)
        {
            Console.Title = "BestString";

            BestString str = new BestString("BestPaint");

            str.AddAttribute(0, 4, AttributeType.Foreground, ConsoleColor.Blue);

            str.AddAttribute(4, str.Length, AttributeType.Foreground, ConsoleColor.Red);

            str.AddAttribute(2, 5, AttributeType.Foreground, ConsoleColor.Green);

            str.AddAttribute(0, str.Length, AttributeType.Background, ConsoleColor.DarkMagenta);

            str.Print();

            Console.ReadKey(true);
        }

        void Test()
        {
            
        }
    }
}

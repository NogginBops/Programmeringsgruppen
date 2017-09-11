using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace BestCrypt
{
    class Program
    {
        static void Main(string[] args)
        {
            start:

            Console.Title = "BestCrypt";

            Console.Write("Encrypt/Decrypt (e/d): ");

            string ed;
            while ((ed = Console.ReadLine()) != "e" && ed != "d");

            if (ed == "e")
            {
                Encrypt();
            }
            else
            {
                Decrypt();
            }

            goto start;
        }

        static void Encrypt()
        {
            Console.Write("What file to encrypt?: ");

            string path;
            while (!File.Exists(path = Console.ReadLine())) Console.WriteLine("Not a file, try again!");

            Console.Write("Encryption key?: ");

            string key = Console.ReadLine();

            // Läs in filen ( File. ... )

            // Ändra värderna med hjälp av nyckeln
            
            using (StreamWriter writer = new StreamWriter(File.Create(path + ".best")))
            {
                writer.Write("Something! :D");
            }
        }

        static void Decrypt()
        {
            Console.Write("What file to decrypt?: ");

            string path;
            while (!File.Exists(path = Console.ReadLine()) && Path.GetExtension(path) == "best") Console.WriteLine("Not a valid file, try again!");

            Console.Write("Decryption key?: ");

            string key = Console.ReadLine();

            // Läs in filen ( File. ... )

            // Ändra värderna med hjälp av nyckeln
            
            using (StreamWriter writer = new StreamWriter(File.Create(Path.GetDirectoryName(path) + "/" + Path.GetFileNameWithoutExtension(path))))
            {
                writer.Write("Something else! :P");
            }
        }
    }
}

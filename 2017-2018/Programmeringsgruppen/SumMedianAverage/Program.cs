using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SumMedianAverage
{
    class Program
    {
        /* En array är en sekvens av värden.
         * En array deklararas genom att använda [] efter en given datatyp.
         * 
         * En array skapas på dessa sätt (där a, b, c, n är värden av typen int):
         * 1)  int[] name = new int[a];
         *     Här skapas en array av längden a.
         * 2)  int[] name = new int[] { b, c, [...], n };
         *     Här skapas en array med värderna b, c, [...], n.
         * 3)  int[] name = { b, c, [...], n };
         *     Här skapas en array med värderna b, c, [...], n.
         * 
         * För att referera till ett värde i en array använder man index.
         * Indexet för första värdet i arrayen är 0.
         * Indexet för sista värdet i arrayen är array.Length - 1.
         * 
         * Exempel för att tilldela fjärde värdet i en array: namn[3] = 50;
         */

        static void Main(string[] args)
        {
            int length;

            restart:

            Console.Write("Amount of input values: ");

            try
            {
                length = int.Parse(Console.ReadLine());
            }
            catch
            {
                Console.WriteLine("Input is not valid!");
                goto restart;
            }

            // Här skapas en array av typen float med längden length.
            float[] values = new float[length];

            // Loop som loopar igenom values och tilldelar den värden.
            for (int i = 0; i < values.Length; i++)
            {
                float value;

                newValue:

                Console.Write("Tal " + (i + 1) + ": ");

                try
                {
                    value = float.Parse(Console.ReadLine());
                }
                catch
                {
                    Console.WriteLine("Input is not valid!");
                    goto newValue;
                }

                values[i] = value;
            }

            // Sum definieras längre ner.
            // Metoden tar in en array av typ float och returnerar ett värde av typ float.
            Console.WriteLine("Sum: " + Sum(values));
            Console.WriteLine("Median: " + Median(values));
            Console.WriteLine("Average: " + Average(values));

            Console.ReadKey();
        }

        /* Satsblocket nedan tillhör en metod.
         * 
        *  Metoden är markerad som static eftersom Main är static.
        *  Allt deklarerat utanför ett satsblock som är static och som ska kallas på i satsblocket måste i sin tur vara static.
        *  En metod behöver inte alltid vara static.
        *  
        *  float specificerar vilket typ av värde som metoden returnerar (skickar tillbaka).
        *  Console.ReadLine returnerar exempelvis ett string-värde.
        *  
        *  Sum är namnet på metoden.
        *  
        *  Namnet måste följas upp av parateser. 
        *  Inom parateserna anger man parametrar, de värden som skickas in i metoden.
        *  Console.WriteLine har exempelvis en string-parameter.
        *  
        *  Metoder tillåter programmeraren "återanvända" kod och organisera kod.
        */

        /// <summary>
        /// Summrerar en array.
        /// </summary>
        static float Sum (float[] numbers)
        {
            float sum = 0;

            for (int i = 0; i < numbers.Length; i++)
            {
                sum += numbers[i];
            }

            // return skickar tillbaka ett värde. 
            return sum;
        }

        /// <summary>
        /// Hittar medianen hos en array.
        /// </summary>
        static float Median (float[] numbers)
        {
            Array.Sort(numbers);

            int index = numbers.Length / 2;

            if (numbers.Length % 2 == 0)
            {
                return (numbers[index - 1] + numbers[index]) / 2;
            }
            else
            {
                return numbers[index];
            }
        }

        /// <summary>
        /// Hittar medelvärdet hos en array.
        /// </summary>
        static float Average (float[] numbers)
        {
            return Sum(numbers) / numbers.Length;
        }
    }
}

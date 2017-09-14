using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WhatIsMyName
{
    class Program
    {
        /* Variablar i programmering beter sig inte som variablar i matematiken.
         * En stor skillnad är att värdet på en variabel i programmering (undantag går vi igenom senare) går att ändra.
         * En variabelinitialisation (sats där man skapar en variabel och ger den värde): 
         *      inleds med att ange datatyp (den typ av variabel man vill skapa).
         *      sedan ger man den ett namn som kommer fungera som en referens till det värde variabeln har,
         *      följt av ett likamedtecken (tilldelningsoperator) och ett värde.
         */
        static void Main(string[] args)
        {
            Console.WriteLine("What is your name?");

            // Detta är en variabelinit. av datatypen string med namnet: name, och det tilldelade värdet "" (en sekvens av noll karaktärer).
            // string är en datatyp som håller en sekvens av karaktärer.
            // Varför man måste omsluta data av typen string med citationstecken är för att datorn skiljer på numeriska och karaktärbaserad data.
            // För en dator är inte numeriska 1 lika med karaktären '1'.
            string name = "";

            // Här tilldelas name ett nytt värde av Console.ReadLine;
            // Console.ReadLine retunerar ett värde av typen string, och på så sätt representerar ett värde i satsen.
            // Console.ReadLine väntar på att användaren trycker på enter-tangenten.
            // Allt användaren har skrivit innan enter-tangenten tryckts ner returneras som ett värde av typen string.
            name = Console.ReadLine();

            // Karaktärsbaserad data kan adderas med varandra till längre strängar av karaktärer.
            Console.WriteLine("Your name is: " + name);

            Console.ReadKey();
        }
    }
}

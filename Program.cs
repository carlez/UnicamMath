﻿using System;

namespace UnicamMath
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Questo programma calcola l'ipotenusa e gli angoli interni fornendo la lunghezza di due cateti");

            Console.Write("Inserisci la lunghezza del primo cateto: ");
            string cateto1Testuale = Console.ReadLine();

            Console.Write("Inserisci la lunghezza del secondo cateto: ");
            string cateto2Testuale = Console.ReadLine();

            double cateto1 = double.Parse(cateto1Testuale);
            double cateto2 = double.Parse(cateto2Testuale);

            double ipotenusa = Math.Sqrt(Math.Pow(cateto1,2)+Math.Pow(cateto2,2));
            double angolo1 = 90;
            double angolo2 = 0;
            double angolo3 = 0;

            //TO DO

            Console.WriteLine($"L'ipotenusa misura {ipotenusa}");
            Console.WriteLine($"I tre angoli interni misurano {angolo1} gradi, {angolo2} gradi e {angolo3} gradi.");

            Console.ReadKey();
        }
    }
}

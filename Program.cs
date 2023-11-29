// See https://aka.ms/new-console-template for more information
using System;

namespace nombre_magique
{
    class Program
    {

        static int DemanderNb(int min, int max)
        {
           
            int nb = min-1;

            while (nb < min || nb > max)
            {
                Console.Write($"Rentrez un nombre entre {min} et {max}: ");
                string reponse = Console.ReadLine();

                try
                {
                   nb = int.Parse(reponse);
                     if (nb < min || nb > max)
                    {
                          Console.WriteLine($"Le nombre doit être compris entre {min} et {max}");
                     }
                }
                 catch
                {
                   Console.WriteLine("Erreur de saisie");
                
                 }
            }
            return nb;

        }
        static void Main(string[] args)
        {
            const int nbMin=1;
            const int nbMax=10;
            int nombre = DemanderNb(nbMin, nbMax);
            Console.WriteLine($"votre nombre est {nombre}");

        }
    }
}

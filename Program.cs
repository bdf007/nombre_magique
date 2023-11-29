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
            const int nbMAgique = 7; 
            int nombre = nbMin -1;
            while (nombre != nbMAgique)
            {
                    nombre = DemanderNb(nbMin, nbMax);
                if (nombre < nbMAgique)
                {
                    Console.WriteLine("le nombre magique est plus grand"); 
                    Console.WriteLine();
                }
                else if (nombre > nbMAgique)
                {
                    Console.WriteLine("le nombre magique est plus petit");
                    Console.WriteLine();
                } 
               
            }
            Console.WriteLine("Bravo, vous avez trouvé le nombre magique");
        }
    }
}

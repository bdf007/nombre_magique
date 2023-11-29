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
            Random rnd = new Random();
            const int NBMIN=1;
            const int NBMAX=10;
            int nbMagique =  rnd.Next(NBMIN, NBMAX + 1);
            int nombre = NBMIN -1;

            for(int nbVies = 4; nbVies > 0; nbVies--)
            {
                Console.WriteLine();
                Console.WriteLine($"nombre de vies restantes: {nbVies}");
                nombre = DemanderNb(NBMIN, NBMAX);
                if (nombre < nbMagique)
                {
                    Console.WriteLine("le nombre magique est plus grand");
                }
                else if (nombre > nbMagique)
                {
                    Console.WriteLine("le nombre magique est plus petit");
                }
                else
                {
                    Console.WriteLine("Bravo, vous avez trouvé le nombre magique");
                    break;
                }
            }
            if (nombre != nbMagique)
            {
                Console.WriteLine($"Vous avez perdu, le nombre magique était : {nbMagique}");
            }

            /*int nbVies = 4;


            while ( nbVies > 0)
            {
                Console.WriteLine();
                Console.WriteLine($"nombre de vies restantes: {nbVies}");
                nombre = DemanderNb(NBMIN, NBMAX);
                if (nombre < nbMagique)
                {
                    Console.WriteLine("le nombre magique est plus grand"); 
                }
                else if (nombre > nbMagique)
                {
                    Console.WriteLine("le nombre magique est plus petit");
                } 
                else
                {
                    Console.WriteLine("Bravo, vous avez trouvé le nombre magique");
                    break;
                }
                nbVies--;
               
            }
            if(nbVies == 0)
            {
                Console.WriteLine($"Vous avez perdu, le nombre magique était : {nbMagique}");            
            }*/
        }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;

namespace IEnumerable
{
    class Program
    {

        static void Main(string[] args)

        {

            Console.WriteLine("Entrez la valeur de n :");
            int n = Convert.ToInt32(Console.ReadLine());

            List<int> tableauInt =
                new List<int> {1,5,0,8,28,53,76,10,32,4,6,0};

            IEnumerable<int> parcoursChaquesValeurs = tableauInt.Where(x => x <= n);
            double moyenne = parcoursChaquesValeurs.Average();

            Console.WriteLine("Tableau des valeurs inférieur ou égal à "+n);


            foreach (int x in parcoursChaquesValeurs)
            {
                Console.WriteLine(x);
            }

            Console.WriteLine("La moyenne des éléments inférieur ou égal à "+n+" est : "+average);

        }
    }
}

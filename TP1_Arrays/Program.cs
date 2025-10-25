using System;

namespace TP1_Tableau
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] tab = new int[10];
            int i, somme = 0, max, min;
            double moyenne;

            for (i = 0; i < tab.Length; i++)
            {
                Console.Write($"Entrer l'élément {i + 1}: ");
                tab[i] = int.Parse(Console.ReadLine());
            }

            Console.WriteLine("Contenu du tableau:");
            for (i = 0; i < tab.Length; i++)
                Console.Write(tab[i] + " ");
            Console.WriteLine();

            for (i = 0; i < tab.Length; i++)
                somme += tab[i];
            moyenne = (double)somme / tab.Length;
            Console.WriteLine("Somme = " + somme);
            Console.WriteLine("Moyenne = " + moyenne);

            max = tab[0];
            min = tab[0];
            for (i = 1; i < tab.Length; i++)
            {
                if (tab[i] > max)
                    max = tab[i];
                if (tab[i] < min)
                    min = tab[i];
            }
            Console.WriteLine("Max = " + max);
            Console.WriteLine("Min = " + min);

            Array.Sort(tab);
            Console.WriteLine("Tableau trié:");
            for (i = 0; i < tab.Length; i++)
                Console.Write(tab[i] + " ");
            Console.WriteLine();

            Console.Write("Entrer un nombre à chercher: ");
            int x = int.Parse(Console.ReadLine());
            bool trouve = false;
            for (i = 0; i < tab.Length; i++)
            {
                if (tab[i] == x)
                {
                    trouve = true;
                    break;
                }
            }
            if (trouve)
                Console.WriteLine("Nombre trouvé à la position: " + (i + 1));
            else
                Console.WriteLine("Nombre non trouvé.");
        }
    }
}

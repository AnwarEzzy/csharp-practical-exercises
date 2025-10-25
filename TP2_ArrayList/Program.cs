using System;
using System.Collections;

namespace TP2_ArrayList
{
    class Program
    {
        static void Main(string[] args)
        {
            ArrayList liste = new ArrayList();
            int choix;
            do
            {
                Console.WriteLine("\n1. Ajouter un élément");
                Console.WriteLine("2. Afficher les éléments");
                Console.WriteLine("3. Supprimer un élément");
                Console.WriteLine("4. Rechercher un élément");
                Console.WriteLine("5. Trier les éléments");
                Console.WriteLine("6. Vider la liste");
                Console.WriteLine("7. Quitter");
                Console.Write("Votre choix: ");
                choix = int.Parse(Console.ReadLine());
                switch (choix)
                {
                    case 1:
                        Console.Write("Entrer la valeur à ajouter: ");
                        string valeur = Console.ReadLine();
                        liste.Add(valeur);
                        break;
                    case 2:
                        Console.WriteLine("Contenu de la liste:");
                        foreach (var item in liste)
                            Console.Write(item + " ");
                        Console.WriteLine();
                        break;
                    case 3:
                        Console.Write("Entrer la valeur à supprimer: ");
                        string valSup = Console.ReadLine();
                        if (liste.Contains(valSup))
                        {
                            liste.Remove(valSup);
                            Console.WriteLine("Élément supprimé.");
                        }
                        else
                            Console.WriteLine("Élément non trouvé.");
                        break;
                    case 4:
                        Console.Write("Entrer la valeur à rechercher: ");
                        string valCher = Console.ReadLine();
                        if (liste.Contains(valCher))
                            Console.WriteLine("Élément trouvé à l’indice: " + liste.IndexOf(valCher));
                        else
                            Console.WriteLine("Élément non trouvé.");
                        break;
                    case 5:
                        liste.Sort();
                        Console.WriteLine("Liste triée.");
                        break;
                    case 6:
                        liste.Clear();
                        Console.WriteLine("Liste vidée.");
                        break;
                    case 7:
                        Console.WriteLine("Fin du programme.");
                        break;
                    default:
                        Console.WriteLine("Choix invalide.");
                        break;
                }
            } while (choix != 7);
        }
    }
}

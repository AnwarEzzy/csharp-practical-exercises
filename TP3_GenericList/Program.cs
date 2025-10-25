using System;
using System.Collections.Generic;

class ProgramList
{
    static void Main(string[] args)
    {
        List<string> noms = new List<string>();
        Console.WriteLine("\nCapacity: {0}", noms.Capacity);
        noms.Add("salwa");
        noms.Add("adil");
        noms.Add("samir");
        noms.Add("imane");
        noms.Add("issam");
        Console.WriteLine();
        foreach (string nom in noms)
        {
            Console.WriteLine(nom);
        }
        Console.WriteLine("\nCapacity: {0}", noms.Capacity);
        Console.WriteLine("Count: {0}", noms.Count);
        Console.WriteLine("\nContains(\"samir\"): {0}", noms.Contains("samir"));
        Console.WriteLine("\nInsert(2, \"jihane\")");
        noms.Insert(2, "jihane");
        Console.WriteLine();
        foreach (string nom in noms)
        {
            Console.WriteLine(nom);
        }
        Console.WriteLine("\nnoms[3]: {0}", noms[3]);
        Console.WriteLine("\nRemove(\"adil\")");
        noms.Remove("adil");
        Console.WriteLine();
        foreach (string nom in noms)
        {
            Console.WriteLine(nom);
        }
        noms.TrimExcess();
        Console.WriteLine("\nTrimExcess()");
        Console.WriteLine("Capacity: {0}", noms.Capacity);
        Console.WriteLine("Count: {0}", noms.Count);
        noms.Clear();
        Console.WriteLine("\nClear()");
        Console.WriteLine("Capacity: {0}", noms.Capacity);
        Console.WriteLine("Count: {0}", noms.Count);
        Console.Read();
    }
}

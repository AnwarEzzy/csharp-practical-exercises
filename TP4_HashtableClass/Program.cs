using System;
using System.Collections;
using System.Collections.Generic;

class ProgramHashtable
{
    static void Main(string[] args)
    {
        Hashtable t = new Hashtable();
        t.Add("A1", "ali");
        t.Add("A2", "yassine");
        t.Add("A3", "hamza");
        t.Add("A4", "salma");
        Console.WriteLine(t["A2"]);
        foreach (DictionaryEntry d in t)
        {
            Console.WriteLine(d.Key + "\t" + d.Value);
        }
        try
        {
            t.Add("A2", "sofia");
        }
        catch
        {
            Console.WriteLine("un élément existe déjà avec cette clé");
        }
        t["A3"] = "hind";
        Console.WriteLine("la valeur associée à la clé A3 est:" + t["A3"]);
        t["A6"] = "hicham";
        Console.WriteLine("la valeur associée à la clé A6 est:" + t["A6"]);
        if (t.Contains("A5") == false)
        {
            t.Add("A5", "anas");
        }
        else Console.WriteLine("clé déjà existante");
        if (t.ContainsValue("anas") == true) Console.WriteLine("valeur existante");
        foreach (string s in t.Keys)
        {
            Console.WriteLine(s);
        }
        foreach (string s in t.Values)
        {
            Console.WriteLine(s);
        }
        t.Remove("A1");
        foreach (DictionaryEntry d in t)
        {
            Console.WriteLine(d.Key + "\t" + d.Value);
        }

        Hashtable t2 = new Hashtable();
        Personne p1 = new Personne("jc2131", "alami", "ahmed");
        Personne p2 = new Personne("ac1267", "alaoui", "yassine");
        Personne p3 = new Personne("bd2345", "chaaibi", "salma");
        t2.Add(p1.CIN, p1);
        t2.Add(p2.CIN, p2);
        t2.Add(p3.CIN, p3);
        foreach (DictionaryEntry d in t2)
        {
            Console.WriteLine(d.Value);
        }
        t2.Remove(p1.CIN);
        Console.WriteLine("**********Suppression******");
        foreach (Personne p in t2.Values)
        {
            Console.WriteLine(p);
        }
        Console.WriteLine("donner le nom");
        string nom = Console.ReadLine();
        foreach (Personne p in t2.Values)
        {
            if (p.Nom == nom) Console.WriteLine(p.ToString());
        }
        List<Personne> l = new List<Personne>();
        foreach (Personne p in t2.Values) l.Add(p);
        l.Sort();
        foreach (Personne p in l) Console.WriteLine(p.ToString());
        Console.Read();
    }
}

class Personne : IComparable
{
    public string CIN { get; set; }
    public string Nom { get; set; }
    public string Prenom { get; set; }

    public Personne() { }
    public Personne(string c, string n, string pr)
    {
        CIN = c;
        Nom = n;
        Prenom = pr;
    }
    public override string ToString()
    {
        return CIN + "\t" + Nom + "\t" + Prenom;
    }
    public int CompareTo(object obj)
    {
        if (obj is Personne)
        {
            Personne p = (Personne)obj;
            return this.Nom.CompareTo(p.Nom);
        }
        else throw new ArgumentException("object not a person");
    }
}

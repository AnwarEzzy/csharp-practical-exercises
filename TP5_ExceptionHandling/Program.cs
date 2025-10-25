
using System;

class ErreurAgeException : Exception
{
    public ErreurAgeException() : base("Erreur: Age négatif") { }
}

class PersonneEx
{
    private string nom;
    private string prenom;
    private int age;
    private static int nbPersonnes;

    public PersonneEx()
    {
        nbPersonnes++;
    }

    public PersonneEx(string nom, string prenom, int age)
    {
        if (age <= 0) throw new ErreurAgeException();
        this.nom = nom;
        this.prenom = prenom;
        this.Age = age;
        nbPersonnes++;
    }

    public PersonneEx(PersonneEx p)
    {
        nom = p.Nom;
        prenom = p.Prenom;
        Age = p.Age;
        nbPersonnes++;
    }

    public int Age
    {
        get { return this.age; }
        set
        {
            if (value <= 0) throw new ErreurAgeException();
            else age = value;
        }
    }

    public string Nom
    {
        get { return this.nom; }
        set { this.nom = value; }
    }

    public string Prenom
    {
        get { return this.prenom; }
        set { this.prenom = value; }
    }

    public static int NbPersonnes
    {
        get { return nbPersonnes; }
    }

    public void afficher()
    {
        Console.WriteLine("nom: " + nom + "\tprenom: " + prenom + "\tage: " + Age);
    }
}

class ProgramExceptions
{
    static void Main(string[] args)
    {
        PersonneEx p = new PersonneEx("asri", "yassine", 23);
        p.afficher();
        Console.WriteLine("donner l'age");
        try
        {
            p.Age = int.Parse(Console.ReadLine());
        }
        catch (ErreurAgeException e)
        {
            Console.WriteLine(e.Message);
        }
        catch (FormatException fe)
        {
            Console.WriteLine(fe.Message);
        }
        catch (OverflowException oe)
        {
            Console.WriteLine(oe.Message);
        }
        p.afficher();
        Console.Read();
    }
}

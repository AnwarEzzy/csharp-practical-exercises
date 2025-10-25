using System;

namespace TPPOO
{
    class Salarie
    {
        protected int matricule;
        protected string nom;
        protected string prenom;
        protected double salaire;
        protected double tauxCS;

        public Salarie()
        {
            matricule = 0;
            nom = "";
            prenom = "";
            salaire = 0.0;
            tauxCS = 0.0;
        }

        public Salarie(int matricule, string nom, string prenom, double salaire, double tauxCS)
        {
            this.matricule = matricule;
            this.nom = nom;
            this.prenom = prenom;
            this.salaire = salaire;
            this.tauxCS = tauxCS;
        }

        public Salarie(Salarie other)
        {
            this.matricule = other.matricule;
            this.nom = other.nom;
            this.prenom = other.prenom;
            this.salaire = other.salaire;
            this.tauxCS = other.tauxCS;
        }

        public int Matricule { get => matricule; set => matricule = value; }
        public string Nom { get => nom; set => nom = value; }
        public string Prenom { get => prenom; set => prenom = value; }
        public double Salaire { get => salaire; set => salaire = value; }
        public double TauxCS { get => tauxCS; set => tauxCS = value; }

        public virtual double CalculerSalaireNet()
        {
            return salaire - (salaire * tauxCS);
        }

        public override string ToString()
        {
            return $"{matricule},{nom}";
        }

        public override bool Equals(object obj)
        {
            if (obj is Salarie s) return this.matricule == s.matricule;
            return false;
        }

        public override int GetHashCode()
        {
            return matricule.GetHashCode();
        }
    }

    class Commercial : Salarie
    {
        private double chiffreAffaire;
        private double pourcentageCommission;

        public Commercial() : base()
        {
            chiffreAffaire = 0.0;
            pourcentageCommission = 0.0;
        }

        public Commercial(int matricule, string nom, string prenom, double salaire, double tauxCS, double chiffreAffaire, double pourcentageCommission)
            : base(matricule, nom, prenom, salaire, tauxCS)
        {
            this.chiffreAffaire = chiffreAffaire;
            this.pourcentageCommission = pourcentageCommission;
        }

        public double ChiffreAffaire { get => chiffreAffaire; set => chiffreAffaire = value; }
        public double PourcentageCommission { get => pourcentageCommission; set => pourcentageCommission = value; }

        public override double CalculerSalaireNet()
        {
            double fixeNet = base.CalculerSalaireNet();
            double commission = chiffreAffaire * (pourcentageCommission / 100.0);
            return fixeNet + commission;
        }

        public override string ToString()
        {
            return $"{matricule},{nom},{prenom},{salaire},{tauxCS},{chiffreAffaire},{pourcentageCommission}";
        }

        public override bool Equals(object obj)
        {
            if (obj is Commercial c)
                return this.matricule == c.matricule && this.chiffreAffaire == c.chiffreAffaire;
            return false;
        }

        public override int GetHashCode()
        {
            return HashCode.Combine(matricule, chiffreAffaire);
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            Salarie s1 = new Salarie(1, "Ait", "Youssef", 5000, 0.25);
            Salarie s2 = new Salarie(2, "El", "Karim", 10000, 0.25);

            Console.WriteLine(s1.ToString());
            Console.WriteLine(s2.ToString());
            Console.WriteLine(s1.CalculerSalaireNet());
            Console.WriteLine(s2.CalculerSalaireNet());

            Commercial c1 = new Commercial(3, "Ben", "Omar", 4000, 0.20, 2000, 10);
            Console.WriteLine(c1.ToString());
            Console.WriteLine(c1.CalculerSalaireNet());

            Commercial c2 = new Commercial();
            c2.Matricule = 3;
            c2.Nom = "Ben";
            c2.Prenom = "Omar";
            c2.Salaire = 4000;
            c2.TauxCS = 0.20;
            c2.ChiffreAffaire = 2000;
            c2.PourcentageCommission = 10;

            Console.WriteLine(c1.Equals(c2));
        }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Likovi
{
    internal abstract class Lik
    {
        public string Info { get; protected set; } = "Lik";
        public abstract double Povrsina();
        public abstract double Opseg();
    }

    internal class Krug : Lik
    {
        public override string ToString()
            => "Krug s radijusom " + Radijus + " cm";
        public double Radijus { get; private set; }
        public Krug(double radijus)
        {
            Radijus = radijus;
            Info = "Krug";
        }
        public override double Povrsina()
            => Radijus * Radijus * Math.PI;
        public override double Opseg()
            => 2 * Radijus * Math.PI;
    }

    internal class Pravokutnik : Lik
    {
        public override string ToString()
            => "Pravokutnik duzine " + Duzina + " cm i sirine "
                + Sirina + " cm.";
        public double Duzina { get; private set; }
        public double Sirina { get; private set; }
        public Pravokutnik(double duzina, double sirina)
        {
            Duzina = duzina;
            Sirina = sirina;
            Info = "Pravokutnik";
        }
        public override double Povrsina()
            => Duzina * Sirina;
        public override double Opseg()
            => 2 * (Duzina + Sirina);

    }

    internal class Kvadrat : Pravokutnik
    {
        public override string ToString()
            => "Kvadrat sa stranicom " + Duzina + " cm.";
        public Kvadrat(double a) : base(a, a)
        {
            Info = "Kvadrat";
        }
    }
}

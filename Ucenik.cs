using System;

namespace Ispit.Model
{
    public class Ucenik
    {
        public string Ime { get; set; }
        public string Prezime { get; set; }
        public DateTime DatumRodjenja { get; set; }
        public double Prosjek { get; set; }

        public int Starost()
        {
            return DateTime.Now.Year - DatumRodjenja.Year;
        }

        public string IspisProsjeka()
        {
            if (Prosjek >= 1 && Prosjek < 1.50)
                return "nedovoljan";
            else if (Prosjek >= 1.50 && Prosjek < 2.50)
                return "dovoljan";
            else if (Prosjek >= 2.50 && Prosjek < 3.50)
                return "dobar";
            else if (Prosjek >= 3.50 && Prosjek < 4.50)
                return "vrlo dobar";
            else if (Prosjek >= 4.50 && Prosjek <= 5)
                return "odličan";
            else
                return "nepoznat";
        }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NutriManager.Modely
{
    public class Surovina
    {
        public Guid Id { get; set; }
        public string Nazev { get; set; }
        public string Kategorie { get; set; }
        public double Kalorie { get; set; }
        public double Bilkoviny { get; set; }
        public double Sacharidy { get; set; }
        public double Tuky { get; set; }
        public double Vlaknina { get; set; }
        public List<string> Alergeny { get; set; }

        public Surovina()
        {
            this.Id = Guid.NewGuid();
            this.Nazev = "";
            this.Kategorie = "";
            this.Alergeny = new List<string>();
        }

        public Surovina(string nazev, string kategorie, double kalorie, double bilkoviny, double sacharidy, double tuky, double vlaknina, List<string> alergeny)
        {
            this.Id = Guid.NewGuid();
            this.Nazev = nazev;
            this.Kategorie = kategorie;
            this.Kalorie = kalorie;
            this.Bilkoviny = bilkoviny;
            this.Sacharidy = sacharidy;
            this.Tuky = tuky;
            this.Vlaknina = vlaknina;
            this.Alergeny = alergeny;
        }

        public string AlergenyText
        {
            get
            {
                if (Alergeny.Count == 0)
                {
                    return "Žádné";
                }

                string vysledek = "";
                for (int i = 0; i < Alergeny.Count; i++)
                {
                    vysledek += Alergeny[i];
                    if (i < Alergeny.Count - 1)
                    {
                        vysledek += ", ";
                    }
                }
                return vysledek;
            }
        }

        public override string ToString()
        {
            return Nazev + " (" + Kalorie + " kcal/100g)";
        }
    }
}
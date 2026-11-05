using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NutriManager.Modely
{
    public class Surovina
    {
        public Guid Id { get; set; } = Guid.NewGuid();
        public string Nazev { get; set; } = string.Empty;
        public string Kategorie { get; set; } = string.Empty;

        public double Kalorie { get; set; }
        public double Bilkoviny { get; set; }
        public double Sacharidy { get; set; }
        public double Tuky { get; set; }
        public double Vlaknina { get; set; }

        public List<string> Alergeny { get; set; } = new List<string>();

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

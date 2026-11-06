using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NutriManager.Modely
{
    public class PolozkaReceptu
    {
        public Guid SurovinaId { get; set; }
        public string NazevSuroviny { get; set; }
        public double HmotnostVGramech { get; set; }

        public PolozkaReceptu()
        {
            this.NazevSuroviny = "";
        }

        public PolozkaReceptu(Guid surovinaId, string nazevSuroviny, double hmotnostVGramech)
        {
            this.SurovinaId = surovinaId;
            this.NazevSuroviny = nazevSuroviny;
            this.HmotnostVGramech = hmotnostVGramech;
        }
    }

    public class Recept
    {
        public Guid Id { get; set; }
        public string Nazev { get; set; }
        public string Postup { get; set; }
        public int PocetPorci { get; set; }
        public List<PolozkaReceptu> Polozky { get; set; }

        public Recept()
        {
            this.Id = Guid.NewGuid();
            this.Nazev = "";
            this.Postup = "";
            this.PocetPorci = 1;
            this.Polozky = new List<PolozkaReceptu>();
        }

        public Recept(string nazev, string postup, int pocetPorci)
        {
            this.Id = Guid.NewGuid();
            this.Nazev = nazev;
            this.Postup = postup;
            this.PocetPorci = pocetPorci;
            this.Polozky = new List<PolozkaReceptu>();
        }
    }
}

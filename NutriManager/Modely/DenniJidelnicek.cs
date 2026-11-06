using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NutriManager.Modely
{
    public class DenniJidelnicek
    {
        public DateTime Datum { get; set; }
        public double CiloveKalorie { get; set; }
        public double CiloveBilkoviny { get; set; }
        public double CiloveSacharidy { get; set; }
        public double CiloveTuky { get; set; }
        public List<PolozkaReceptu> Snidane { get; set; }
        public List<PolozkaReceptu> Obed { get; set; }
        public List<PolozkaReceptu> Vecere { get; set; }
        public List<PolozkaReceptu> Svaciny { get; set; }

        public DenniJidelnicek()
        {
            this.Datum = DateTime.Today;
            this.CiloveKalorie = 2000;
            this.CiloveBilkoviny = 120;
            this.CiloveSacharidy = 250;
            this.CiloveTuky = 65;
            this.Snidane = new List<PolozkaReceptu>();
            this.Obed = new List<PolozkaReceptu>();
            this.Vecere = new List<PolozkaReceptu>();
            this.Svaciny = new List<PolozkaReceptu>();
        }

        public DenniJidelnicek(DateTime datum, double ciloveKalorie, double ciloveBilkoviny, double ciloveSacharidy, double ciloveTuky)
        {
            this.Datum = datum;
            this.CiloveKalorie = ciloveKalorie;
            this.CiloveBilkoviny = ciloveBilkoviny;
            this.CiloveSacharidy = ciloveSacharidy;
            this.CiloveTuky = ciloveTuky;
            this.Snidane = new List<PolozkaReceptu>();
            this.Obed = new List<PolozkaReceptu>();
            this.Vecere = new List<PolozkaReceptu>();
            this.Svaciny = new List<PolozkaReceptu>();
        }
    }
}

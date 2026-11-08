using NutriManager.Modely;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.Json;
using System.Threading.Tasks;
using System.IO;

namespace NutriManager.Sluzby
{
    public class SpravceDat
    {
        private string cestaKSouboru = "suroviny.json";

        public List<Surovina> NactiSuroviny()
        {
            if (!File.Exists(cestaKSouboru))
            {
                List<Surovina> vychoziData = ZiskejVychoziSuroviny();
                UlozSuroviny(vychoziData);
                return vychoziData;
            }

            string json = "";
            using (StreamReader sr = new StreamReader(cestaKSouboru))
            {
                json = sr.ReadToEnd();
            }
            // Přeloží JSON text ze souboru na skutečné objekty List<Surovina> (deserializace)
            List<Surovina> nacteno = JsonSerializer.Deserialize<List<Surovina>>(json);
            if (nacteno == null)
            {
                return new List<Surovina>();
            }
            return nacteno;
        }

        public void UlozSuroviny(List<Surovina> suroviny)
        {
            // Nastavení pro odřádkování a odsazení JSON souboru
            JsonSerializerOptions nastaveni = new JsonSerializerOptions { WriteIndented = true };
            // Převede objekty List<Surovina> na JSON text pro zápis do souboru (serializace)
            string json = JsonSerializer.Serialize(suroviny, nastaveni);

            using (StreamWriter sw = new StreamWriter(cestaKSouboru))
            {
                sw.Write(json);
            }
        }

        private List<Surovina> ZiskejVychoziSuroviny()
        {
            List<Surovina> seznam = new List<Surovina>();

            seznam.Add(new Surovina("Kuřecí prsa (syrová)", "Maso", 110, 23.1, 0, 1.2, 0, new List<string>()));
            seznam.Add(new Surovina("Hovězí zadní", "Maso", 136, 21.6, 0, 5.5, 0, new List<string>()));
            seznam.Add(new Surovina("Vepřová panenka", "Maso", 110, 21.1, 0, 2.6, 0, new List<string>()));
            seznam.Add(new Surovina("Losos obecný", "Maso", 208, 20.4, 0, 13.4, 0, new List<string> { "4 - Ryby" }));
            seznam.Add(new Surovina("Vejce slepičí", "Ostatní", 143, 12.6, 0.7, 9.5, 0, new List<string> { "3 - Vejce" }));
            seznam.Add(new Surovina("Mléko polotučné 1,5%", "Mléčné výrobky", 47, 3.4, 4.8, 1.5, 0, new List<string> { "7 - Mléko" }));
            seznam.Add(new Surovina("Tvaroh polotučný", "Mléčné výrobky", 104, 12.5, 3.8, 4.0, 0, new List<string> { "7 - Mléko" }));
            seznam.Add(new Surovina("Sýr Eidam 30%", "Mléčné výrobky", 263, 27.0, 1.5, 16.0, 0, new List<string> { "7 - Mléko" }));
            seznam.Add(new Surovina("Jogurt bílý (3,5% tuku)", "Mléčné výrobky", 66, 4.1, 4.2, 3.5, 0, new List<string> { "7 - Mléko" }));
            seznam.Add(new Surovina("Máslo", "Tuky", 748, 0.7, 0.6, 82.5, 0, new List<string> { "7 - Mléko" }));
            seznam.Add(new Surovina("Olivový olej", "Tuky", 884, 0, 0, 100.0, 0, new List<string>()));
            seznam.Add(new Surovina("Rýže jasmínová (syrová)", "Přílohy", 355, 7.1, 79.0, 0.6, 1.4, new List<string>()));
            seznam.Add(new Surovina("Těstoviny pšeničné (syrové)", "Přílohy", 359, 12.0, 72.0, 1.5, 3.0, new List<string> { "1 - Lepek" }));
            seznam.Add(new Surovina("Brambory (syrové)", "Přílohy", 77, 2.0, 17.0, 0.1, 2.2, new List<string>()));
            seznam.Add(new Surovina("Ovesné vločky", "Pečivo", 374, 13.5, 61.0, 6.7, 9.0, new List<string> { "1 - Lepek" }));
            seznam.Add(new Surovina("Chléb konzumní kmínový", "Pečivo", 244, 7.8, 48.0, 1.2, 4.2, new List<string> { "1 - Lepek" }));
            seznam.Add(new Surovina("Rohlík bílý", "Pečivo", 297, 9.2, 57.5, 3.1, 2.8, new List<string> { "1 - Lepek" }));
            seznam.Add(new Surovina("Jablko", "Ovoce", 52, 0.3, 13.8, 0.2, 2.4, new List<string>()));
            seznam.Add(new Surovina("Banán", "Ovoce", 89, 1.1, 22.8, 0.3, 2.6, new List<string>()));
            seznam.Add(new Surovina("Rajče", "Zelenina", 18, 0.9, 3.9, 0.2, 1.2, new List<string>()));
            seznam.Add(new Surovina("Okurka salátová", "Zelenina", 15, 0.7, 3.6, 0.1, 0.5, new List<string>()));
            seznam.Add(new Surovina("Paprika červená", "Zelenina", 31, 1.0, 6.0, 0.3, 2.1, new List<string>()));

            return seznam;
        }
    }
}
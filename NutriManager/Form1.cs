using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Windows.Forms;
using NutriManager.Modely;
using NutriManager.Sluzby;

namespace NutriManager
{
    public partial class Form1 : Form
    {
        private SpravceDat spravceDat = new SpravceDat();
        private List<Surovina> seznamSurovin = new List<Surovina>();

        public Form1()
        {
            InitializeComponent();
            InicializujAplikaci();
        }

        private void InicializujAplikaci()
        {
            string[] kategorie = { "Maso", "Peèivo", "Zelenina", "Ovoce", "Mléèné výrobky", "Tuky", "Pøílohy", "Ostatní" };
            foreach (string kat in kategorie)
            {
                cmbKategorie.Items.Add(kat);
            }
            cmbKategorie.SelectedIndex = 0;

            seznamSurovin = spravceDat.NactiSuroviny();
            tabulkaSurovin.SelectionChanged += TabulkaSurovin_SelectionChanged;
            ObnovTabulku();
        }

        private void ObnovTabulku()
        {
            tabulkaSurovin.DataSource = null;
            tabulkaSurovin.DataSource = seznamSurovin.ToArray();

            if (tabulkaSurovin.Columns["Id"] != null)
            {
                tabulkaSurovin.Columns["Id"].Visible = false;
            }
        }

        private void TabulkaSurovin_SelectionChanged(object? sender, EventArgs e)
        {
            if (tabulkaSurovin.CurrentRow != null)
            {
                Surovina vybrana = (Surovina)tabulkaSurovin.CurrentRow.DataBoundItem;
                txtNazev.Text = vybrana.Nazev;
                cmbKategorie.SelectedItem = vybrana.Kategorie;
                txtKalorie.Text = vybrana.Kalorie.ToString();
                txtBilkoviny.Text = vybrana.Bilkoviny.ToString();
                txtSacharidy.Text = vybrana.Sacharidy.ToString();
                txtTuky.Text = vybrana.Tuky.ToString();
                txtVlaknina.Text = vybrana.Vlaknina.ToString();

                if (vybrana.Alergeny.Count == 0)
                {
                    txtAlergeny.Text = "";
                }
                else
                {
                    txtAlergeny.Text = vybrana.AlergenyText;
                }
            }
        }

        private void tlacitkoPridat_Click(object sender, EventArgs e)
        {
            if (!ZvalidujVstupy(out Surovina novaSurovina, true, null))
            {
                return;
            }

            seznamSurovin.Add(novaSurovina);
            spravceDat.UlozSuroviny(seznamSurovin);
            ObnovTabulku();
            MessageBox.Show("Surovina byla úspìšnì pøidána.", "Hotovo", MessageBoxButtons.OK, MessageBoxIcon.Information);
            VycistiFormular();
        }

        private void tlacitkoUpravit_Click(object sender, EventArgs e)
        {
            if (tabulkaSurovin.CurrentRow == null)
            {
                MessageBox.Show("Nejprve vyberte surovinu v tabulce.", "Upozornìní", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            Surovina vybrana = (Surovina)tabulkaSurovin.CurrentRow.DataBoundItem;

            if (!ZvalidujVstupy(out Surovina upravenaData, false, vybrana.Id))
            {
                return;
            }

            vybrana.Nazev = upravenaData.Nazev;
            vybrana.Kategorie = upravenaData.Kategorie;
            vybrana.Kalorie = upravenaData.Kalorie;
            vybrana.Bilkoviny = upravenaData.Bilkoviny;
            vybrana.Sacharidy = upravenaData.Sacharidy;
            vybrana.Tuky = upravenaData.Tuky;
            vybrana.Vlaknina = upravenaData.Vlaknina;
            vybrana.Alergeny = upravenaData.Alergeny;

            spravceDat.UlozSuroviny(seznamSurovin);
            ObnovTabulku();
            MessageBox.Show("Zmìny byly úspìšnì uloženy.", "Hotovo", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void tlacitkoSmazat_Click(object sender, EventArgs e)
        {
            if (tabulkaSurovin.CurrentRow == null)
            {
                MessageBox.Show("Nejprve vyberte surovinu v tabulce.", "Upozornìní", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            Surovina vybrana = (Surovina)tabulkaSurovin.CurrentRow.DataBoundItem;

            DialogResult potvrzeni = MessageBox.Show("Opravdu chcete smazat surovinu '" + vybrana.Nazev + "'?",
                "Potvrzení smazání", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

            if (potvrzeni == DialogResult.Yes)
            {
                seznamSurovin.Remove(vybrana);
                spravceDat.UlozSuroviny(seznamSurovin);
                ObnovTabulku();
                VycistiFormular();
            }
        }

        private void tlacitkoVycistit_Click(object sender, EventArgs e)
        {
            VycistiFormular();
        }

        private void VycistiFormular()
        {
            txtNazev.Clear();
            txtKalorie.Clear();
            txtBilkoviny.Clear();
            txtSacharidy.Clear();
            txtTuky.Clear();
            txtVlaknina.Clear();
            txtAlergeny.Clear();
            cmbKategorie.SelectedIndex = 0;
        }

        private bool ZvalidujVstupy(out Surovina vysledek, bool jeNova, Guid? aktualniId)
        {
            vysledek = new Surovina();
            string nazev = txtNazev.Text.Trim();

            if (nazev == "")
            {
                MessageBox.Show("Název suroviny nesmí být prázdný!", "Chyba validace", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }

            for (int i = 0; i < seznamSurovin.Count; i++)
            {
                Surovina s = seznamSurovin[i];
                if (s.Nazev.ToLower() == nazev.ToLower() && (jeNova || s.Id != aktualniId))
                {
                    MessageBox.Show("Surovina s tímto názvem již v databázi existuje!", "Chyba validace", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return false;
                }
            }

            if (!ZkusPrevestKladneCislo(txtKalorie.Text, "Kalorie", 900, out double kalorie) ||
                !ZkusPrevestKladneCislo(txtBilkoviny.Text, "Bílkoviny", 100, out double bilkoviny) ||
                !ZkusPrevestKladneCislo(txtSacharidy.Text, "Sacharidy", 100, out double sacharidy) ||
                !ZkusPrevestKladneCislo(txtTuky.Text, "Tuky", 100, out double tuky) ||
                !ZkusPrevestKladneCislo(txtVlaknina.Text, "Vláknina", 100, out double vlaknina))
            {
                return false;
            }

            if (bilkoviny + sacharidy + tuky + vlaknina > 100.0)
            {
                MessageBox.Show("Souèet bílkovin, sacharidù, tukù a vlákniny nemùže pøesáhnout 100 g (hodnoty jsou na 100 g suroviny)!",
                    "Logická chyba", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }

            List<string> seznamAlergenu = new List<string>();
            string[] casti = txtAlergeny.Text.Split(',');
            for (int i = 0; i < casti.Length; i++)
            {
                string ocisteno = casti[i].Trim();
                if (ocisteno != "")
                {
                    seznamAlergenu.Add(ocisteno);
                }
            }

            string vybranaKategorie = cmbKategorie.SelectedItem.ToString();
            vysledek = new Surovina(nazev, vybranaKategorie, kalorie, bilkoviny, sacharidy, tuky, vlaknina, seznamAlergenu);

            return true;
        }

        private bool ZkusPrevestKladneCislo(string vstup, string nazevPole, double maxHodnota, out double hodnota)
        {
            string upravenyVstup = vstup.Replace('.', ',');
            if (!double.TryParse(upravenyVstup, out hodnota) || hodnota < 0 || hodnota > maxHodnota)
            {
                MessageBox.Show("Pole '" + nazevPole + "' musí obsahovat platné èíslo v rozmezí 0 až " + maxHodnota + ".",
                    "Chyba validace", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }
            return true;
        }
    }
}
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using zadanie2.Modele;
using System.IO;
using System.Diagnostics;

//Obsługa plików Json
using Newtonsoft.Json;


namespace zadanie2
{
    public partial class Form1 : Form
    {

        Postac Postac;

        public Form1()
        {
            InitializeComponent();

            //Wylistuj rasy w menu
            RasaCombo.DataSource = Enum.GetValues(typeof(Rasa));

            Postac = new Postac();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            //zapis postaci
            string serializacja = JsonConvert.SerializeObject(Postac);

            SaveFileDialog zapisz = new SaveFileDialog();

            zapisz.Filter = "Json files (*.json)|*.json|Text files (*.txt)|*.txt";
            zapisz.FileName = "";
            zapisz.RestoreDirectory = true;

            if (zapisz.ShowDialog() == DialogResult.OK)
            {
                File.WriteAllText(zapisz.FileName, serializacja);
            }

        }

        private void WczytajButton_Click(object sender, EventArgs e)
        {
            //wczytywanie postaci
            string ZczytanyTekst;

            OpenFileDialog wczytaj = new OpenFileDialog();

            wczytaj.Filter = "Json files (*.json)|*.json|Text files (*.txt)|*.txt";
            wczytaj.FileName = "";
            wczytaj.RestoreDirectory = true;

            if(wczytaj.ShowDialog() == DialogResult.OK)
            {
                ZczytanyTekst = File.ReadAllText(wczytaj.FileName);
            }
            else
            {
                throw new Exception("błąd obsługi plików");
            }

            Postac Postac =
                System.Text.Json.JsonSerializer.Deserialize<Postac>(ZczytanyTekst);



            NazwaPostaciText.Text = Postac.NazwaPostaci;
            NazwaPostaciText.BackColor = Color.Green;

            PoziomNumeric.Value = Postac.Poziom;

            PunktyWigoruNumeric.Value = Postac.PunktyWigoru;
            StaminaNumeric.Value = Postac.Stamina;
            ManaNumeric.Value = Postac.Mana;

            KowalstwoNumeric.Value = Postac.Kowalstwo;
            CpancerzNumeric.Value = Postac.CiezkiPancerz;
            BlokNumeric.Value = Postac.Blok;
            BdwurecznaNumeric.Value = Postac.BronDwureczna;
            BjednorecznaNumeric.Value = Postac.BronJednoreczna;
            LucznictwoNumeric.Value = Postac.Lucznictwo;

            LpancerzNumeric.Value = Postac.LekkiPancerz;
            SkradanieNumeric.Value = Postac.SkradanieSie;
            OzamkowNumeric.Value = Postac.OtwieranieZamkow;
            KradziezNumeric.Value = Postac.KradziezKieszonkowa;
            RetorykaNumeric.Value = Postac.Retoryka;
            AlchemiaNumeric.Value = Postac.Alchemia;

            IluzjaNumeric.Value = Postac.Iluzja;
            PrzywolywanieNumeric.Value = Postac.Przywolywanie;
            ZniszczenieNumeric.Value = Postac.Zniszczenie;
            PrzywrocenieNumeric.Value = Postac.Przywrocenie;
            PrzemianaNumeric.Value = Postac.Przemiana;
            ZaklinanieNumeric.Value = Postac.Zaklinanie;

        }

        private void ResetButton_Click(object sender, EventArgs e)
        {
            //reset statystyk

            NazwaPostaciText.Text = "";
            NazwaPostaciText.BackColor = Color.IndianRed;

            PoziomNumeric.Value = 0;

            PunktyWigoruNumeric.Value = 0;
            StaminaNumeric.Value = 0;
            ManaNumeric.Value = 0;

            KowalstwoNumeric.Value = 0;
            CpancerzNumeric.Value = 0;
            BlokNumeric.Value = 0;
            BdwurecznaNumeric.Value = 0;
            BjednorecznaNumeric.Value = 0;
            LucznictwoNumeric.Value = 0;

            LpancerzNumeric.Value = 0;
            SkradanieNumeric.Value = 0;
            OzamkowNumeric.Value = 0;
            KradziezNumeric.Value = 0;
            RetorykaNumeric.Value = 0;
            AlchemiaNumeric.Value = 0;

            IluzjaNumeric.Value = 0;
            PrzywolywanieNumeric.Value = 0;
            ZniszczenieNumeric.Value = 0;
            PrzywrocenieNumeric.Value = 0;
            PrzemianaNumeric.Value = 0;
            ZaklinanieNumeric.Value = 0;

        }

        //Przypisanie statystyk do klasy

        //Pierwszy wiersz
        private void KowalstwoNumeric_ValueChanged(object sender, EventArgs e)
        {
            Postac.Kowalstwo = (int)KowalstwoNumeric.Value;
        }

        private void CpancerzNumeric_ValueChanged(object sender, EventArgs e)
        {
            Postac.CiezkiPancerz = (int)CpancerzNumeric.Value;
        }

        private void BlokNumeric_ValueChanged(object sender, EventArgs e)
        {
            Postac.Blok = (int)BlokNumeric.Value;
        }

        private void BdwurecznaNumeric_ValueChanged(object sender, EventArgs e)
        {
            Postac.BronDwureczna = (int)BdwurecznaNumeric.Value;
        }

        private void BjednorecznaNumeric_ValueChanged(object sender, EventArgs e)
        {
            Postac.BronJednoreczna = (int)BjednorecznaNumeric.Value;
        }

        private void LucznictwoNumeric_ValueChanged(object sender, EventArgs e)
        {
            Postac.Lucznictwo = (int)LucznictwoNumeric.Value;
        }

        //Drugi wiersz z UI
        private void LpancerzNumeric_ValueChanged(object sender, EventArgs e)
        {
            Postac.LekkiPancerz = (int)LpancerzNumeric.Value;
        }

        private void SkradanieNumeric_ValueChanged(object sender, EventArgs e)
        {
            Postac.SkradanieSie = (int)SkradanieNumeric.Value;
        }

        private void OzamkowNumeric_ValueChanged(object sender, EventArgs e)
        {
            Postac.OtwieranieZamkow = (int)OzamkowNumeric.Value;
        }

        private void KradziezNumeric_ValueChanged(object sender, EventArgs e)
        {
            Postac.KradziezKieszonkowa = (int)KradziezNumeric.Value;
        }

        private void RetorykaNumeric_ValueChanged(object sender, EventArgs e)
        {
            Postac.Retoryka = (int)RetorykaNumeric.Value;
        }

        private void AlchemiaNumeric_ValueChanged(object sender, EventArgs e)
        {
            Postac.Alchemia = (int)AlchemiaNumeric.Value;
        }

        //Trzeci wiersz z UI
        private void IluzjaNumeric_ValueChanged(object sender, EventArgs e)
        {
            Postac.Iluzja = (int)IluzjaNumeric.Value;
        }

        private void PrzywolywanieNumeric_ValueChanged(object sender, EventArgs e)
        {
            Postac.Przywolywanie = (int)LucznictwoNumeric.Value;
        }

        private void ZniszczenieNumeric_ValueChanged(object sender, EventArgs e)
        {
            Postac.Zniszczenie = (int)ZniszczenieNumeric.Value;
        }

        private void PrzywrocenieNumeric_ValueChanged(object sender, EventArgs e)
        {
            Postac.Przywrocenie = (int)PrzywrocenieNumeric.Value;
        }

        private void PrzemianaNumeric_ValueChanged(object sender, EventArgs e)
        {
            Postac.Przemiana = (int)PrzemianaNumeric.Value;
        }

        private void ZaklinanieNumeric_ValueChanged(object sender, EventArgs e)
        {
            Postac.Zaklinanie = (int)ZaklinanieNumeric.Value;
        }

        //Dane pod umiejetnościami z UI

        private void button1_Click_1(object sender, EventArgs e)
        {
            Postac.NazwaPostaci = NazwaPostaciText.Text;
            NazwaPostaciText.BackColor = Color.Green;
        }

        private void PoziomNumeric_ValueChanged(object sender, EventArgs e)
        {
            Postac.Poziom = (int)PoziomNumeric.Value;
        }

        private void RasaCombo_ValueMemberChanged(object sender, EventArgs e)
        {
            Postac.Rasa = RasaCombo.Text;
        }

        private void PunktyWigoruNumeric_ValueChanged(object sender, EventArgs e)
        {
            Postac.PunktyWigoru = (int)PunktyWigoruNumeric.Value;
        }

        private void StaminaNumeric_ValueChanged(object sender, EventArgs e)
        {
            Postac.Stamina = (int)StaminaNumeric.Value;
        }

        private void ManaNumeric_ValueChanged(object sender, EventArgs e)
        {
            Postac.Mana = (int)ManaNumeric.Value;
        }

    }
}

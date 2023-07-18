using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace zadanie2.Modele
{
    public class Postac
    {
        public int Poziom { get; set; }

        public string NazwaPostaci { get; set; }

        public string Rasa { get; set; }

        public int PunktyWigoru { get; set; }
        public int Stamina { get; set; }
        public int Mana { get; set; }


        //Umiejętności

        //Magiczne
        public int Iluzja { get; set; }
        public int Przemiana { get; set; }
        public int Przywolywanie { get; set; }
        public int Przywrocenie { get; set; }
        public int Zaklinanie { get; set; }
        public int Zniszczenie { get; set; }

        //Złodziejskie
        public int Alchemia { get; set; }
        public int KradziezKieszonkowa { get; set; }
        public int LekkiPancerz { get; set; }
        public int OtwieranieZamkow { get; set; }
        public int Retoryka { get; set; }
        public int SkradanieSie { get; set; }

        //Wojownicze
        public int Blok { get; set; }
        public int BronJednoreczna { get; set; }
        public int BronDwureczna { get; set; }
        public int CiezkiPancerz { get; set; }
        public int Kowalstwo { get; set; }
        public int Lucznictwo { get; set; }

    }
}

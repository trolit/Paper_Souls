using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace paper_souls
{
    class Wzmacniacz : Bohater
    {
        public int poziom_wzmocnienia;

        public Wzmacniacz(int zywotnosc, string imie, int poziom, string rasa, string tytul, int mana, int sila, int inteligencja, int zrecznosc, int poziom_wzmocnienia)
        :base(zywotnosc, imie, poziom, rasa, tytul, mana, sila, inteligencja, zrecznosc)
        {
            this.poziom_wzmocnienia = poziom_wzmocnienia;
        }
    }
}

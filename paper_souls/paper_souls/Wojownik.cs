using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace paper_souls
{
    class Wojownik : Bohater
    {
        public int kondycja;

        public Wojownik(int zywotnosc, string imie, int poziom, string rasa, string tytul, int mana, int sila, int inteligencja, int zrecznosc, int kondycja)
        : base(zywotnosc, imie, poziom, rasa, tytul, mana, sila, inteligencja, zrecznosc)
        {
            this.kondycja = kondycja;
        }
    }
}

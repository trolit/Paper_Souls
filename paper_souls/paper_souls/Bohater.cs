using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace paper_souls
{
    class Bohater : Postac
    {
        protected string tytul;
        public int mana;
        public int sila;
        public int inteligencja;
        public int zrecznosc;

        public Bohater(int zywotnosc, string imie, int poziom, string rasa, string tytul, int mana, int sila, int inteligencja, int zrecznosc)
        : base(zywotnosc, imie, poziom, rasa)
        {
            this.tytul = tytul;
            this.mana = mana;
            this.sila = sila;
            this.inteligencja = inteligencja;
            this.zrecznosc = zrecznosc;
        }

        public void Odpocznij()
        {
            this.zywotnosc = this.zywotnosc + 6;
            this.mana = this.mana + 15;
        }
    }
}

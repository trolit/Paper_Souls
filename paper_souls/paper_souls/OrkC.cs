using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace paper_souls
{
    class OrkC : Przeciwnik, IRandomize
    {
        protected int sila;

        public OrkC(int zywotnosc, string imie, int poziom, string rasa, int modyfikator_trudnosci, int sila)
        : base(zywotnosc, imie, poziom, rasa, modyfikator_trudnosci)
        {
            this.sila = sila;
        }

        public int Dzgniecie()
        {
            return random();
        }

        public int random()
        {
            Random random = new Random();
            int atak = random.Next(8, 21);
            return atak;
        }

        public int Losuj_uderzenie()
        {
            Random los = new Random();
            int dec = los.Next(1, 2);
            return dec;
        }
    }
}

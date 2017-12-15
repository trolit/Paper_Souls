using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace paper_souls
{
    class Szczur : Przeciwnik,  IRandomize
    {
        protected int sila;

        public Szczur(int zywotnosc, string imie, int poziom, string rasa, int modyfikator_trudnosci, int sila)
        : base(zywotnosc, imie, poziom, rasa, modyfikator_trudnosci)
        {
            this.sila = sila;
        }

        public int Ugryzienie()
        {
            return random();
        }

        public int random()
        {
            Random random = new Random();
            int atak = random.Next(1, 10);
            return atak;
        }
    }
}

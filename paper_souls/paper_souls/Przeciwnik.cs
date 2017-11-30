using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace paper_souls
{
    class Przeciwnik : Postac
    {
        public int modyfikator_trudnosci;

        public Przeciwnik(int zywotnosc, string imie, int poziom, string rasa, int modyfikator_trudnosci)
        : base(zywotnosc, imie, poziom, rasa)
        {
            this.modyfikator_trudnosci = modyfikator_trudnosci;
        }
    }
}

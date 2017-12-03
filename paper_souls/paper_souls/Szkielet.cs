using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace paper_souls
{
    class Szkielet : Przeciwnik, IRandomize
    {
        int rekonstrukcja = 1;

        public Szkielet(int zywotnosc, string imie, int poziom, string rasa, int modyfikator_trudnosci)
        :base(zywotnosc, imie, poziom, rasa, modyfikator_trudnosci)
        {
        }

        public int Uderzenie_Mieczem()
        {
            return random();
        }

        public void Rekonstrukcja()
        {
            this.zywotnosc = this.zywotnosc + 40;
            rekonstrukcja = 0;
        }

        public int random()
        {
            Random random = new Random();
            int atak = random.Next(3, 24);
            return atak;
        }
    }
}

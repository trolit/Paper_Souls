using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace paper_souls
{
    class Templariusz : Bohater, IRandomize
    {
        public bool zaatakowany;

        public Templariusz(int mana, int zywotnosc, string imie, int poziom, string rasa, string tytul, int inteligencja, int sila, int zrecznosc)
        :base(zywotnosc, imie, poziom, rasa, tytul, mana, inteligencja, sila, zrecznosc)
        {

        }

        public int Riposta()
        {
            if (zaatakowany == true)
            {
                return random();
            }

            return 1;
        }

        public int random()
        {
            Random random = new Random();
            int atak = random.Next(6, 10);
            return atak;
        }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace paper_souls
{
    class Templariusz : Bohater, IRandomize
    {
        public bool zaatakowany = false;
        public bool slabosc = false;

        public Templariusz(int mana, int zywotnosc, string imie, int poziom, string rasa, string tytul, int inteligencja, int sila, int zrecznosc)
        :base(zywotnosc, imie, poziom, rasa, tytul, mana, inteligencja, sila, zrecznosc)
        {

        }

        public int Uderz_Mieczem()
        {
            if(slabosc == false)
            {
                return random();
            }
            else if(slabosc == true)
            {
                Console.WriteLine("Uderzasz w słaby punkt zadając dodatkowe obrażenia!");
                return random() + 11;
            }
            return 1;
        }

        public int Riposta(int obrazenia)
        {
            if (zaatakowany == true)
            {
                return obrazenia / 2;
            }
            return 0;
        }

        public int Sciecie(int zycie)
        {
            if(zycie <= 30)
            {
                return 30; 
            }
            else
            {
                Console.WriteLine("Z determinacją próbujesz wykończyć przeciwnika jednym ciosem lecz Ci się to nie udaje!");
            }

            return 1;
        }

        public void Wyczuj_slabosc()
        {
            Console.WriteLine("Odszukujesz słaby punkt w przeciwniku!");
            slabosc = true;
        }

        public int Rzut_Toporem()
        {
            this.mana = this.mana - 20;
            return 15;
        }

        public int random()
        {
            Random random = new Random();
            int atak = random.Next(15, 20);
            return atak;
        }

    }
}

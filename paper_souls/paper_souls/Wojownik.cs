using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace paper_souls
{
    class Wojownik : Bohater, IRandomize
    {
        public int kondycja;

        public Wojownik(int zywotnosc, string imie, int poziom, string rasa, string tytul, int mana, int sila, int inteligencja, int zrecznosc, int kondycja)
        : base(zywotnosc, imie, poziom, rasa, tytul, mana, sila, inteligencja, zrecznosc)
        {
            this.kondycja = kondycja;
        }

        public int Uderzenie_oburacz()
        {
            this.kondycja = this.kondycja - 27;
            return random_uderzenie();
        }

        public void Wyciszenie()
        {
            this.kondycja = this.kondycja + 40;
        }

        public int Zioniecie_Ogniem()
        {
            this.mana = this.mana - 10;
            return random();
        }

        public int Szarza()
        {
            this.kondycja = this.kondycja - 35;
            return random_szarza();
        }
        public int random() // zioniecie ogniem
        {
            Random random = new Random();
            int atak = random.Next(10, 20);
            return atak;
        }
        public int random_szarza()
        {
            Random random = new Random();
            int atak = random.Next(8, 40);
            return atak;
        }
        public int random_uderzenie()
        {
            Random random = new Random();
            int atak = random.Next(10, 35);
            return atak;
        }
    }
}

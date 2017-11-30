using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace paper_souls
{
    class Paladyn : Bohater, IRandomize
    {
        bool wzmocnienie = false;

        public Paladyn(int mana, int zywotnosc, string imie, int poziom, string rasa, string tytul, int inteligencja, int sila, int zrecznosc)
        : base(zywotnosc, imie, poziom, rasa, tytul, mana, inteligencja, sila, zrecznosc)
        {
            this.mana = mana;
            this.inteligencja = inteligencja;
            this.sila = sila;
            this.zrecznosc = zrecznosc;
        }

        public int Uderz_Mlotem()
        {
            if (wzmocnienie == false)
            {
                return random();
            }
            else
            {
                wzmocnienie = false;
                return random() + 8;
            }
        }

        public void Ulecz_sie(int mana, int zywotnosc)
        {
            this.mana = this.mana - 30;
            this.zywotnosc = this.zywotnosc + return_health();
        }

        public void Modlitwa()
        {
            wzmocnienie = true;
            this.zywotnosc = this.zywotnosc + 5;
        }

        public int random()
        {
            Random random = new Random();
            int atak = random.Next(6, 10);
            return atak;
        }

        public int return_health()
        {
            Random random = new Random();
            int health = random.Next(30, 45);
            return health;
        }
    }
}

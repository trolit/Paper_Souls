using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace paper_souls
{
    class Druid : Bohater, IRandomize
    {
        public bool krwawienie = false;
        public int counter = 2;
        public bool czy_wilk = false;

        public Druid(int zywotnosc, string imie, int poziom, string rasa, string tytul, int mana, int sila, int inteligencja, int zrecznosc)
        :base(zywotnosc, imie, poziom, rasa, tytul, mana, inteligencja, sila, zrecznosc)
        {

        }

        public int Pazury()
        {
            if (krwawienie == false)
            {
                Random szansa_krwawienia = new Random();
                int chance = szansa_krwawienia.Next(1, 10);
                if(chance == 5 || chance == 2)
                {
                    Console.WriteLine("Wywołujesz krwawienie u przeciwnika na 2 tury!");
                    krwawienie = true;
                }
            }

            return random();
        }

        public void Ogromne_leczenie()
        {
            this.mana = this.mana - 100;
            this.zywotnosc = this.zywotnosc + 90;
        }

        public void Przywolaj_wilka()
        {
            this.mana = this.mana - 100;
            czy_wilk = true;
        }

        public void Krwawienie(int zywotnosc)
        {
            Random random = new Random();
            int chance = random.Next(5, 9);

            if (krwawienie == true)
            {
                if(counter == 2)
                {
                    counter = 1;
                    this.zywotnosc -= chance;
                    Console.WriteLine("Przeciwnik otrzymuje " + chance + " obrażeń od krwawienia!");
                }
                else if(counter == 1)
                {
                    counter = 0;
                    this.zywotnosc -= chance;
                    Console.WriteLine("Przeciwnik otrzymuje " + chance + " obrażeń od krwawienia!");
                }
                else if(counter == 0)
                {
                    krwawienie = false;
                }
            }
        }

        public int random() 
        {
            Random random = new Random();
            int atak = random.Next(7, 12);
            return atak;
        }
    }
}

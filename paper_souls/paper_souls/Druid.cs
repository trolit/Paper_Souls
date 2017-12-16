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
        public int counter = 0;
        public bool czy_wilk = false;

        public Druid(int zywotnosc, string imie, int poziom, string rasa, string tytul, int mana, int sila, int inteligencja, int zrecznosc)
        :base(zywotnosc, imie, poziom, rasa, tytul, mana, inteligencja, sila, zrecznosc)
        {

        }

        public int Pazury()
        {
            //if (krwawienie == false)
            //{
            //    Random szansa_krwawienia = new Random();
            //    int chance = szansa_krwawienia.Next(1, 10);
            //    if(chance == 5 || chance == 2 || chance > 1)
            //    {
            //        Console.WriteLine("Wywołujesz krwawienie u przeciwnika na 2 tury!");
            //        krwawienie = true;
            //    }
            //}

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
            if (krwawienie == true)
            {
                Random random = new Random();
                int chance = random.Next(5, 9);

                if (counter == 1)
                {
                    this.zywotnosc -= chance;
                    Console.WriteLine("Przeciwnik otrzymuje " + chance + " obrażeń od krwawienia!");
                }
                else if(counter == 2)
                {
                Random zlos = new Random();
                int szansa = zlos.Next(5, 9);

                    this.zywotnosc -= szansa;
                    Console.WriteLine("Przeciwnik otrzymuje " + szansa + " obrażeń od krwawienia!");
                }
                else if(counter == 3)
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

        public int los_glaz()
        {
                Random random = new Random();
                int atak = random.Next(10, 30);
                this.mana = this.mana - 35;
                return atak;
        }
    }
}

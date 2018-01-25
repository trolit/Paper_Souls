using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace paper_souls
{
    class Snajper : Bohater
    {
        public int stan_amunicji = 30;
        public bool zaciety = false;
        public bool znikniety = false;

        public Snajper(int mana, int zywotnosc, string imie, int poziom, string rasa, string tytul, int inteligencja, int sila, int zrecznosc)
        :base(zywotnosc, imie, poziom, rasa, tytul, mana, inteligencja, sila, zrecznosc)
        {}

        public void Znikniecie()
        {
            znikniety = true;
        }

        public int Strzal()
        {
            if(zaciety == false)
            {
                int losowanie = random_choice();

                if(losowanie == 2 || losowanie == 6)
                {
                    zaciety = true;
                    Console.WriteLine("Twój Dragunov się zaciął!");
                    return 0;
                }

                return random() - 10;
            }
            else if(zaciety == true)
            {
                Console.WriteLine("Poświęcasz turę aby załadować broń.");
                stan_amunicji -= 1;
                zaciety = false;
                return 0;
            }
            return 1;
        }

        public int Strzal_Glowa()
        {
            stan_amunicji -= 2;
            return random() + 10;
        }

        public void Opatrywanie_ran()
        {
            this.zywotnosc = this.zywotnosc + 45;
        }

        public int random()
        {
            Random random = new Random();
            int atak = random.Next(25, 40);
            return atak;
        }

        // szansa na zaciecie broni
        public int random_choice()
        {
            Random random = new Random();
            int los = random.Next(1, 10);
            return los;
        }


    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace paper_souls
{
    class Wzmacniacz : Bohater, IRandomize
    {
        public int poziom_wzmocnienia = 0;
        public int stan_mikstur = 0;
        public bool unik = false;
        public bool transferowana_energia = false;

        public Wzmacniacz(int zywotnosc, string imie, int poziom, string rasa, string tytul, int mana, int sila, int inteligencja, int zrecznosc, int poziom_wzmocnienia)
        :base(zywotnosc, imie, poziom, rasa, tytul, mana, sila, inteligencja, zrecznosc)
        {
            this.poziom_wzmocnienia = poziom_wzmocnienia;
        }

        public int Uderz_Toporem()
        {
            if (transferowana_energia == false)
            {
                return random();
            }
            else if(transferowana_energia == true)
            {
                transferowana_energia = false;
                return random() + 20;
            }
            return 1;
        }

        public void Wzmocnienie()
        {
            if (this.poziom_wzmocnienia < 4)
            {
                this.poziom_wzmocnienia = this.poziom_wzmocnienia + 1;
            }
            this.zywotnosc = this.zywotnosc + 5;
            this.mana = this.mana + 5;
        }

        public void Unik_Ataku()
        {
            Random random = new Random();
            int szansa_uniku = random.Next(1, 10);
            if(szansa_uniku == 2 || szansa_uniku == 5 || szansa_uniku == 7 || szansa_uniku == 9 || szansa_uniku == 1)
            {
                Console.WriteLine("Udaje Ci się uniknąć następnego ataku!");
                unik = true;
            }
            else
            {
                Console.WriteLine("Próba uniknięcia następnego ataku nie powiodła sie!");
            }
            
        }

        public void Transfer_Magii()
        {
            this.mana = this.mana - 40;
            transferowana_energia = true;
        }

        public void Wypij_miksture()
        {
            if(this.stan_mikstur > 0)
            {
                stan_mikstur -= 1;
                Console.WriteLine("Wypijasz miksturę zdrowia odzyskując nieco zdrowia!");
                this.zywotnosc = this.zywotnosc + 25;
            }
            else
            {
                Console.WriteLine("Poświęcasz turę żeby poszukać po kieszeniach mikstury zdrowia....");
                Console.WriteLine("Po chwili przypominasz sobie, że żadnej mikstury nie masz...");
            }
        }

        public void Tworz_miksture()
        {
            this.stan_mikstur = this.stan_mikstur + 1;
        }

        public int random()
        {
            Random random = new Random();
            int atak;
            if (poziom_wzmocnienia == 0)
            {
                atak = random.Next(9, 14);
                poziom_wzmocnienia = 0;
                return atak;
            }
            else if (poziom_wzmocnienia == 1)
            {
                atak = random.Next(15, 28);
                poziom_wzmocnienia = 0;
                return atak;
            }
            else if (poziom_wzmocnienia == 2)
            {
                atak = random.Next(30, 45);
                poziom_wzmocnienia = 0;
                return atak;
            }
            else if (poziom_wzmocnienia == 3)
            {
                atak = random.Next(45, 65);
                poziom_wzmocnienia = 0;
                return atak;
            }
            return 1;
        }
    }
}

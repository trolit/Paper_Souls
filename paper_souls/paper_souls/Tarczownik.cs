using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace paper_souls
{
    class Tarczownik : Przeciwnik
    {
        public bool przeladowanie = false;

        public Tarczownik(int zywotnosc, string imie, int poziom, string rasa, int modyfikator_trudnosci)
        :base(zywotnosc, imie, poziom, rasa, modyfikator_trudnosci)
        {

        }

        public void Decyzja()
        {
            Random losuj_decyzje = new Random();
            int decyzja = losuj_decyzje.Next(1, 5);

            if(decyzja == 1)
            {
                Zamach_Bronia();
            }
            else if(decyzja == 2 && przeladowanie == false)
            {
                Strzal_Z_Kuszy();
            }
            else if(decyzja == 3)
            {
                Rzut_nozem();
            }
            else if(decyzja == 4 && przeladowanie == true)
            {
                Przeladowanie();
            }
            else
            {
                Uzdrowienie_Rycerskie();
            }
        }

        public int Zamach_Bronia()
        {
            Random losowo = new Random();
            int atak = losowo.Next(8, 18);
            Console.WriteLine("Tarczownik wykonuje zamach toporem zadając Ci " + atak + " obrażeń!");
            return atak;
        }

        public int Strzal_Z_Kuszy()
        {
            Random losowo = new Random();
            int atak = losowo.Next(6, 12);
            przeladowanie = true;
            Console.WriteLine("Tarczownik strzela z kuszy zadając Ci " + atak + " obrażeń!");
            return atak;
        }

        public int Rzut_nozem()
        {
            Random losowo = new Random();
            int atak = losowo.Next(3, 8);
            Console.WriteLine("Tarczownik rzuca nożem zadając Ci " + atak + " obrażeń!");
            return atak;
        }

        public void Przeladowanie()
        {
            Console.WriteLine("Tarczownik poświęca turę aby przeładować kuszę!");
            przeladowanie = false;
        }

        public void Uzdrowienie_Rycerskie()
        {
            Console.WriteLine("Tarczownik korzysta z uzdrowienia rycerskiego przywracając sobie 20HP!");
            this.zywotnosc = this.zywotnosc + 20;
        }
    }
}

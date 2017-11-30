using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace paper_souls
{
    class OrkA : Przeciwnik
    {
        protected int sila;
        public bool przeladowanie = false;

        public OrkA(int zywotnosc, string imie, int poziom, string rasa, int modyfikator_trudnosci, int sila)
        : base(zywotnosc, imie, poziom, rasa, modyfikator_trudnosci)
        {
            this.sila = sila;
        }

        public int Strzal_Kusza()
        {
            if (przeladowanie == false)
            {
                przeladowanie = true;
                return 15;
            }
            else if (przeladowanie == true)
            {
                Przeladowanie();
            }
            return 1;
        }

        public void Przeladowanie()
        {
            Console.WriteLine("Ork poświęca turę aby przeładować kuszę!");
            przeladowanie = false;
        }
    }
}

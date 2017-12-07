using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace paper_souls
{
    class Wilk : Przeciwnik, IRandomize
    {
        public bool krwawienie = false;
        public int checker = 3;

        public Wilk(int zywotnosc, string imie, int poziom, string rasa, int modyfikator_trudnosci)
        :base(zywotnosc, imie, poziom, rasa, modyfikator_trudnosci)
        {

        }

        public int Zagryzienie()
        {
            if (krwawienie == false)
            {
                Random bleeding = new Random();
                int los = bleeding.Next(5, 20);
                if (los == 14 && los == 18)
                {
                    Console.WriteLine("Ugryzienie wilka powoduje, że krwawisz przez 3 tury!");
                    krwawienie = true;
                }
            }

            return random();
        }

        public int random() 
        {
            Random random = new Random();
            int atak = random.Next(8, 14);
            return atak;
        }

        public void Krwawienie(int zywotnosc)
        {
            Random ile_krwawi = new Random();
            int krwawienie_ilosc = ile_krwawi.Next(3, 6);

            if (checker == 3)
            {
                checker = 2;
                this.zywotnosc -= krwawienie_ilosc;
                Console.WriteLine("Otrzymujesz " + krwawienie_ilosc + " obrażeń od krwawienia!");
            }
            else if (checker == 2)
            {
                checker = 1;
                this.zywotnosc -= krwawienie_ilosc;
                Console.WriteLine("Otrzymujesz " + krwawienie_ilosc + " obrażeń od krwawienia!");
            }
            else if (checker == 1)
            {
                checker = 0;
                this.zywotnosc -= krwawienie_ilosc;
                Console.WriteLine("Otrzymujesz " + krwawienie_ilosc + " obrażeń od krwawienia!");
            }
            else if (checker == 0)
            {
                krwawienie = false;
            }
        }
    }
}

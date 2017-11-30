using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace paper_souls
{
    class Mag : Bohater
    {
        public string spec;        // magia wody, magia ognia itd...
        public int stan_mikstur = 3;
        public bool zamrozenie = false;

        public Mag(int zywotnosc, string imie, int poziom, string rasa, string tytul, int mana, int sila, int inteligencja, int zrecznosc, string spec)
        : base(zywotnosc, imie, poziom, rasa, tytul, mana, inteligencja, sila, zrecznosc)
        {
            this.spec = spec;
        }

        public int Kula_ognia()
        {
            this.mana = this.mana - 25;
            return 20;
        }
        public int Mrozenie()
        {
            this.mana = this.mana - 37;
            zamrozenie = true;
            return 15;
        }
        public int Piorun()
        {
            this.mana = this.mana - 39;
            return 27;
        }
        public void Potezne_leczenie()
        {
            this.mana = this.mana - 80;
            this.zywotnosc = this.zywotnosc + 75;
        }
        public void Wypij_mane()
        {
            if (Mikstura_many() > 0)
            {
                Console.WriteLine("Szukasz po kieszeniach fiolki z maną i... udaje Ci się jakąś znaleźć!");
                Console.WriteLine("Błyskawicznie wyjmujesz korek i wypijasz całą zawartość.");
                this.mana = this.mana + 80;
            }
            else
            {
                Console.WriteLine("Szukasz w pośpiechu po kieszeniach czy jakaś mikstura Ci jeszcze została....");
                Console.WriteLine("Niestety znajdujesz tylko puste butelki tracąc przy tym turę.");
            }
        }
        #region Metoda mikstura many
        public int Mikstura_many()
        {
            stan_mikstur = stan_mikstur - 1;
            return stan_mikstur;
        }
        #endregion

    }
}

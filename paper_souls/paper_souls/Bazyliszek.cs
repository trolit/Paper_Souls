using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace paper_souls
{
    class Bazyliszek : Postac, IRandomize
    {
        public int stan_many;
        public bool skamieniowany = false;

        public Bazyliszek(int zywotnosc, string imie, int poziom, string rasa, int stan_many)
        :base(zywotnosc, imie, poziom, rasa)
        {
            this.stan_many = stan_many;
        }

        public int Ukaszenie()
        {
            this.stan_many += 1;
            return random();
        }

        public void Skamieniowanie()
        {
            this.stan_many = this.stan_many - 10;
            skamieniowany = true;
        }

        public int random()
        {
            Random random = new Random();
            int atak = random.Next(8, 16);
            return atak;
        }
    }
}

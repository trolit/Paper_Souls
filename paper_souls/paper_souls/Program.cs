using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace paper_souls
{
    interface I_RPGmethods
    {

    }

    interface IRandomize
    {
        int random();
    }

    class Postac
    {
        public int zywotnosc;
        public string imie;
        public int poziom;
        public string rasa;
        public int wybierz_bohatera;
        public int wybierz_bohatera_2;

        public Postac() { }

        public Postac(int zywotnosc, string imie, int poziom, string rasa)
        {
            this.zywotnosc = zywotnosc;
            this.imie = imie;
            this.poziom = poziom;
            this.rasa = rasa;
        }

        public int Wybor_Bohatera()
        {
            Console.WriteLine("Witaj!");
            Console.WriteLine("Wybierz swojego bohatera i pokonaj przeciwników, którzy staną na twojej drodze!");
            int x;
            for (x = 0; x < 2;)
            {
                Console.WriteLine("1. Paladyn");
                Console.WriteLine("2. Wojownik");
                Console.WriteLine("3. Mag");
                Console.WriteLine("4. Kleryk");
                Console.WriteLine("5. Wzmacniacz");
                Console.WriteLine("6. Druid\n");
                Console.Write("Wybieram: ");
                try
                {
                    wybierz_bohatera = Convert.ToInt32(Console.ReadLine());
                }
                catch
                {
                    Console.WriteLine("\nPodczas działania programu wystąpił błąd!");
                    Console.WriteLine("Podano błędne dane na wejściu wybierz_bohatera\n");
                    return 0;
                }

                if (wybierz_bohatera == 1)
                {
                    Console.WriteLine("___________________________________________\n");
                    Console.WriteLine("Horx 'Szczodry' - Paladyn(Człowiek)");
                    Console.WriteLine("\nGłówne cechy: \n");
                    Console.WriteLine("+ zdolność zwiększenia obrażen dzięki modlitwie");
                    Console.WriteLine("+ wytrzymała zbroja płytowa z tytanu");
                    Console.WriteLine("+ stosunkowo tania zdolność leczenia");
                    Console.WriteLine("\nKarta postaci: \n");
                    Console.WriteLine("Poziom: 3");
                    Console.WriteLine("Siła: 7");
                    Console.WriteLine("Zręczność: 2");
                    Console.WriteLine("Inteligencja: 6");
                    Console.WriteLine("Żywotność(HP): 142");
                    Console.WriteLine("Mana(MP): 100");
                    Console.WriteLine("___________________________________________");
                }
                else if (wybierz_bohatera == 3)
                {
                    Console.WriteLine("___________________________________________\n");
                    Console.WriteLine("Harval 'Grzesznik' - Mag(Żaba)");
                    Console.WriteLine("\nGłówne cechy: \n");
                    Console.WriteLine("+ dużo czarów bitewnych");
                    Console.WriteLine("+ większa ilość many");
                    Console.WriteLine("+ potężny czar uzdrowienia");
                    Console.WriteLine("\nKarta postaci: \n");
                    Console.WriteLine("Poziom: 2");
                    Console.WriteLine("Siła: 3");
                    Console.WriteLine("Zręczność: 3");
                    Console.WriteLine("Inteligencja: 9");
                    Console.WriteLine("Żywotność(HP): 110");
                    Console.WriteLine("Mana(MP): 125");
                    Console.WriteLine("___________________________________________");
                }

                Console.WriteLine("\nCzy jesteś pewien, że właśnie tego bohatera chcesz wybrać?");
                Console.WriteLine("Potwierdź swój wybór wpisując jeszcze raz tę samą wartość");
                Console.WriteLine("Lub wpisz 0, żeby cofnąć się do menu wyboru postaci.");
                try
                {
                    wybierz_bohatera_2 = Convert.ToInt32(Console.ReadLine());
                }
                catch
                {
                    Console.WriteLine("\nPodczas działania programu wystąpił błąd!");
                    Console.WriteLine("Podano błędne dane na wejściu wybierz_bohatera_2\n");
                    return 0;
                }
                if (wybierz_bohatera == wybierz_bohatera_2)
                {
                    return wybierz_bohatera_2;
                }
            }
            return 1;
        }
    }

    class Przeciwnik : Postac
    {
        public int modyfikator_trudnosci;

        public Przeciwnik(int zywotnosc, string imie, int poziom, string rasa, int modyfikator_trudnosci)
        : base(zywotnosc, imie, poziom, rasa)
        {
            this.modyfikator_trudnosci = modyfikator_trudnosci;
        }
    }

    class Szczur : Przeciwnik, I_RPGmethods, IRandomize
    {
        protected int sila;

        public Szczur(int zywotnosc, string imie, int poziom, string rasa, int modyfikator_trudnosci, int sila)
        : base(zywotnosc, imie, poziom, rasa, modyfikator_trudnosci)
        {
            this.sila = sila;
        }

        public int Ugryzienie()
        {
            return random();
        }

        public int random()
        {
            Random random = new Random();
            int atak = random.Next(1, 10);
            return atak;
        }
    }

    class OrkA : Przeciwnik
    {
        protected int sila;
        bool przeladowanie = false;

        public OrkA(int zywotnosc, string imie, int poziom, string rasa, int modyfikator_trudnosci, int sila)
        : base(zywotnosc, imie, poziom, rasa, modyfikator_trudnosci)
        {
            this.sila = sila;
        }

        private int Strzal_Kusza()
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

        private void Przeladowanie()
        {
            Console.WriteLine("Ork poświęca turę aby przeładować kuszę!");
            przeladowanie = false;
        }
    }
    class Bohater : Postac
    {
        protected string tytul;
        public int mana;
        public int sila;
        public int inteligencja;
        public int zrecznosc;

        public Bohater(int zywotnosc, string imie, int poziom, string rasa, string tytul, int mana, int sila, int inteligencja, int zrecznosc)
        : base(zywotnosc, imie, poziom, rasa)
        {
            this.tytul = tytul;
            this.mana = mana;
            this.sila = sila;
            this.inteligencja = inteligencja;
            this.zrecznosc = zrecznosc;
        }

        public void Odpocznij()
        {
            this.zywotnosc = this.zywotnosc + 6;
            this.mana = this.mana + 15;
        }
    }

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
            this.zywotnosc = this.zywotnosc + 30;
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
    }

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
    class Program
    {
        static void Main(string[] args)
        {
            #region Tworzenie postaci do gry
            Postac wybor_bohatera = new Postac();
            Paladyn paladyn1 = new Paladyn(100, 142, "Horx", 3, "Czlowiek", "Szczodry", 6, 7, 2);
            Mag mag1 = new Mag(110, "Harval", 2, "Żaba", "Grzesznik", 125, 3, 9, 3, "Magia wody");
            OrkA ork1 = new OrkA(125, "Ork - Kusznik", 2, "orkowate", 2, 10);
            Szczur szczur1 = new Szczur(100, "Szczur", 2, "szczurowate", 2, 3);
            #endregion

            int wybor_postaci = wybor_bohatera.Wybor_Bohatera();

            #region Przygoda Paladyna
            if (wybor_postaci == 1)
            {
                Console.WriteLine("///////////////////////////////////////////////////////////");
                Console.WriteLine("Napotkales przeciwnika -> " + szczur1.imie);
                Console.WriteLine("Co wiesz o przeciwniku?\nPoziom: " + szczur1.poziom + "\nRasa: " + szczur1.rasa + "\nTrudnosc: " + szczur1.modyfikator_trudnosci);
                Console.WriteLine("\nwalczysz(wpisz 1) czy uciekasz(wpisz 0)?");
                int decyzja1 = Convert.ToInt32(Console.ReadLine());

                if (decyzja1 == 1)
                {
                    Console.WriteLine("Szczur zaczyna!");
                    int obr_szczura = szczur1.Ugryzienie();
                    paladyn1.zywotnosc = paladyn1.zywotnosc - obr_szczura;
                    Console.WriteLine("Szczur ugryzł Cię zadając " + obr_szczura + " obrażeń!");
                    Console.WriteLine("Twoja kolej, co chcesz zrobić?");
                    Console.WriteLine("1. uderz młotem");
                    Console.WriteLine("2. ulecz się(-30mana, +30hp) \n-> Stan many na chwilę obecną: " + paladyn1.mana);
                    Console.WriteLine("3. modlitwa(+obrażenia na następną turę, +5hp)");
                    Console.WriteLine("4. odpoczynek(+15mana, +6hp)");
                    Console.WriteLine("Stan many: " + paladyn1.mana);
                    Console.WriteLine("Stan życia: " + paladyn1.zywotnosc);

                    int decyzja2 = Convert.ToInt32(Console.ReadLine());
                    if (decyzja2 == 1)
                    {
                        int liczba_obrazen = paladyn1.Uderz_Mlotem();
                        szczur1.zywotnosc = szczur1.zywotnosc - liczba_obrazen;
                        Console.WriteLine("Zadales " + liczba_obrazen + " obrażeń!");
                        Console.WriteLine("Stan życia szczura: " + szczur1.zywotnosc);
                    }
                    else if (decyzja2 == 2)
                    {
                        paladyn1.Ulecz_sie(paladyn1.mana, paladyn1.zywotnosc);
                        Console.WriteLine("------------------------------------------------------------");
                        Console.WriteLine("Uleczyles sie! Twój obecny stan życia: " + paladyn1.zywotnosc);
                    }
                    else if (decyzja2 == 3)
                    {
                        paladyn1.Modlitwa();
                        Console.WriteLine("Poświęcasz swoją turę na modlitwę!");
                    }
                    else if (decyzja2 == 4)
                    {
                        paladyn1.Odpocznij();
                        Console.WriteLine("Poświęcasz swoją turę odzyskując zdrowie i manę!");
                    }

                    int i;
                    for (i = 0; i < 100;)
                    {
                        Console.WriteLine("Kolej szczura!");
                        int obrazenia = szczur1.Ugryzienie();
                        paladyn1.zywotnosc = paladyn1.zywotnosc - obrazenia;
                        Console.WriteLine("Szczur ugryzł Cię zadając " + obrazenia + " obrażeń!");
                        if (paladyn1.zywotnosc < 0)
                        {
                            Console.WriteLine("Zginąłeś!");
                            break;
                        }
                        Console.WriteLine("Twoja kolej, co chcesz zrobić?");
                        Console.WriteLine("1. uderz młotem");
                        Console.WriteLine("2. ulecz się(-40mana, +20hp) \n-> Stan many: " + paladyn1.mana);
                        Console.WriteLine("3. modlitwa(+obrażenia na następną turę, +5hp)");
                        Console.WriteLine("4. odpoczynek(+15mana, +6hp)");
                        Console.WriteLine("Stan many: " + paladyn1.mana);
                        Console.WriteLine("Stan życia: " + paladyn1.zywotnosc);

                        decyzja2 = Convert.ToInt32(Console.ReadLine());
                        if (decyzja2 == 1)
                        {
                            int liczba_obrazen = paladyn1.Uderz_Mlotem();
                            szczur1.zywotnosc = szczur1.zywotnosc - paladyn1.Uderz_Mlotem();
                            Console.WriteLine("Zadales " + liczba_obrazen + " obrażeń!");
                            Console.WriteLine("Stan życia szczura: " + szczur1.zywotnosc);

                            if (szczur1.zywotnosc < 0)
                            {
                                Console.WriteLine("Pokonałeś przeciwnika! Zdobyłeś 50 doświadczenia!");
                                break;
                            }

                        }
                        else if (decyzja2 == 2 && paladyn1.mana >= 30)
                        {
                            paladyn1.Ulecz_sie(paladyn1.mana, paladyn1.zywotnosc);
                            Console.WriteLine("------------------------------------------------------------");
                            Console.WriteLine("Uleczyles sie! Twój obecny stan życia: " + paladyn1.zywotnosc);
                        }
                        else if (decyzja2 == 3)
                        {
                            paladyn1.Modlitwa();
                            Console.WriteLine("Poświęcasz swoją turę na modlitwę!");
                        }
                        else if (decyzja2 == 4)
                        {
                            paladyn1.Odpocznij();
                            Console.WriteLine("Poświęcasz swoją turę odzyskując zdrowie i manę!");
                        }
                    }
                }
                else
                {
                    Console.WriteLine("\nUciekłeś!");
                }
            }
            #endregion
            else if (wybor_postaci == 3)
            {
                Console.WriteLine("///////////////////////////////////////////////////////////");
                Console.WriteLine("Napotkales przeciwnika -> " + ork1.imie);
                Console.WriteLine("Co wiesz o przeciwniku?\nPoziom: " + ork1.poziom + "\nRasa: " + ork1.rasa + "\nTrudnosc: " + ork1.modyfikator_trudnosci);
                Console.WriteLine("\nwalczysz(wpisz 1) czy uciekasz(wpisz 0)?");
                int decyzja_maga = Convert.ToInt32(Console.ReadLine());

                Console.WriteLine("Ork przygotowuje kuszę, Ty zaczynasz!");
                Console.WriteLine("Co chcesz zrobić?");
                Console.WriteLine("1. strzel kulą ognia(20obrażeń, -25 mana)");
                Console.WriteLine("2. zamróź przeciwnika(15obrażeń, -37 mana)");
                Console.WriteLine("3. strzel piorunem(27obrażeń, -39mana)");
                Console.WriteLine("4. odpoczynek(+15mana, +6hp)");
                Console.WriteLine("5. wypij miksturę many(+80mana)");
                Console.WriteLine("6. dokonaj inkantancji zaklęcia potężnego leczenia(-80mana, +75zdrowie)");
                Console.WriteLine("Stan many:" + mag1.mana);
                Console.WriteLine("Stan życia:" + mag1.zywotnosc);
                decyzja_maga = Convert.ToInt32(Console.ReadLine());

                int obrazenia;
                if (decyzja_maga == 1 && mag1.mana >= 25)
                {
                    obrazenia = mag1.Kula_ognia();
                    ork1.zywotnosc = ork1.zywotnosc - obrazenia;
                    Console.WriteLine("Stan życia orczego kusznika: " + ork1.zywotnosc + " HP");
                }
                else if (decyzja_maga == 2 && mag1.mana >= 37)
                {
                    obrazenia = mag1.Mrozenie();
                    ork1.zywotnosc = ork1.zywotnosc - obrazenia;
                    Console.WriteLine("Zamroziłeś przeciwnika powodując, że nie może on wykonać swojej tury!");
                    Console.WriteLine("Stan życia orczego kusznika: " + ork1.zywotnosc + " HP");
                }
                else if (decyzja_maga == 3 && mag1.mana >= 39)
                {
                    obrazenia = mag1.Piorun();
                    ork1.zywotnosc = ork1.zywotnosc - obrazenia;
                    Console.WriteLine("Stan życia orczego kusznika: " + ork1.zywotnosc + " HP");
                }
                else if (decyzja_maga == 4)
                {
                    mag1.Odpocznij();
                    Console.WriteLine("Poświęciłeś swoją turę żeby odpocząć odzyskując trochę zdrowia i many!");
                }
                else if (decyzja_maga == 5)
                {
                    mag1.Wypij_mane();
                }
            }
            Console.ReadKey();
        }
    }
}

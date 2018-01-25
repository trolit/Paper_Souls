using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace paper_souls
{
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
            Console.WriteLine("------------------------->Witaj w grze Paper Souls!<--------------------------");
            Console.Write("Pewnie końcówka 'Souls', trochę już zdradza o co chodzi w tej grze, jeśli jednak");
            Console.Write("nie masz nadal zielonego pojęcia(nie martw się), już wyjaśniamy. Jest to gra typu ");
            Console.Write("walka z przeciwnikami ale turowa, i ... tekstowa :0. Od Ciebie zależeć będzie życie ");
            Console.Write("bohatera, ponieważ to Ty go poprowadzisz do boju. Na drodze spotkasz różnorakich wrogów. ");
            Console.Write(" Aby pokonać swojego przeciwnika będziesz musiał wykazać się planowaniem kilku kroków do przodu. ");
            Console.Write("Życie, mana (a w przypadku innych klas - inne atrybuty) wymuszą na Tobie ");
            Console.Write("dobór odpowiedniej akcji do odpowiedniej sytuacji - jeśli się pomylisz - Twój ");
            Console.Write("bohater zginie! Pamiętaj, że przeciwników może być więcej, zatem ostrożnie zużywaj surowce! ");
            Console.Write("nie pozostaje Ci nic, tylko wybrać klasę i sprostać wyzwaniom jakie na Ciebie czekają! ");

            Console.WriteLine("\n\nWybierz swojego bohatera i pokonaj przeciwników, którzy staną na twojej drodze!");
            int x;
            for (x = 0; x < 2;)
            {
                Console.WriteLine("1. Paladyn");
                Console.WriteLine("2. Wojownik");
                Console.WriteLine("3. Mag");
                Console.WriteLine("4. Wzmacniacz");
                Console.WriteLine("5. Templariusz");
                Console.WriteLine("6. Druid");
                Console.WriteLine("7. Snajper");
                Console.WriteLine("8. Kusznik");
                Console.WriteLine("9. Włócznik okrągłegu stołu");
                Console.Write("Wybieram: ");
                try
                {
                    wybierz_bohatera = Convert.ToInt32(Console.ReadLine());
                }
                catch
                {
                    Console.WriteLine("\nPodczas działania programu wystąpił błąd!");
                    Console.WriteLine("treść błędu: Podano błędne dane na wejściu wybierz_bohatera\n");
                    return 0;
                }

                if (wybierz_bohatera == 1)
                {
                    Console.WriteLine("_______________________________________________________" +
                        "____\n");
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
                    Console.WriteLine("Żywotność(HP): 160");
                    Console.WriteLine("Mana(MP): 100");
                    Console.WriteLine("___________________________________________________________");
                }
                else if (wybierz_bohatera == 2)
                {
                    Console.WriteLine("___________________________________________________________\n");
                    Console.WriteLine("Drakom 'Tarczownik' - Wojownik(Smok)");
                    Console.WriteLine("\nGłówne cechy: \n");
                    Console.WriteLine("+ duża wytrzymałość organizmu");
                    Console.WriteLine("+ duża odporność na ciosy");
                    Console.WriteLine("+ zdolność zionięcia ogniem");
                    Console.WriteLine("+ umiejętność szarży z doskokiem(podwójny atak)");
                    Console.WriteLine("+ ze względu na ciężką broń, Drakom traci energię");
                    Console.WriteLine("\nKarta postaci: \n");
                    Console.WriteLine("Poziom: 4");
                    Console.WriteLine("Siła: 12");
                    Console.WriteLine("Zręczność: 1");
                    Console.WriteLine("Inteligencja: 2");
                    Console.WriteLine("Żywotność(HP): 200");
                    Console.WriteLine("Mana(MP): 20");
                    Console.WriteLine("Kondycja(CP): 115");
                    Console.WriteLine("___________________________________________________________");
                }
                else if (wybierz_bohatera == 3)
                {
                    Console.WriteLine("___________________________________________________________\n");
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
                    Console.WriteLine("___________________________________________________________");
                }
                else if (wybierz_bohatera == 4)
                {
                    Console.WriteLine("___________________________________________________________\n");
                    Console.WriteLine("Paseur 'Straszny' - Wzmacniacz(Rekin)");
                    Console.WriteLine("\nGłówne cechy: \n");
                    Console.WriteLine("+ potrafi wzmacniać topór zwiększając obrażenia");
                    Console.WriteLine("+ może uniknąć następnego ataku przeciwnika");
                    Console.WriteLine("+ potrafi stworzyć małą miksturę leczenia");
                    Console.WriteLine("\nKarta postaci: \n");
                    Console.WriteLine("Poziom: 4");
                    Console.WriteLine("Siła: 3");
                    Console.WriteLine("Zręczność: 6");
                    Console.WriteLine("Inteligencja: 6");
                    Console.WriteLine("Żywotność(HP): 165");
                    Console.WriteLine("Mana(MP): 90");
                    Console.WriteLine("Max.poziom wzmocnienia: 3");
                    Console.WriteLine("___________________________________________________________");
                }
                else if (wybierz_bohatera == 5)
                {
                    Console.WriteLine("___________________________________________________________\n");
                    Console.WriteLine("Marc 'Bezlitosny' - Templariusz(Człowiek)");
                    Console.WriteLine("\nGłówne cechy: \n");
                    Console.WriteLine("+ potrafi wyczuć słaby punkt wroga");
                    Console.WriteLine("+ potrafi szybko wykończyć wroga(poniżej pewnego progu życia)");
                    Console.WriteLine("+ posiada zdolność riposty wielką tarczą pokrytą kolcami(odbija połowę obrażeń)");
                    Console.WriteLine("\nKarta postaci: \n");
                    Console.WriteLine("Poziom: 3");
                    Console.WriteLine("Siła: 10");
                    Console.WriteLine("Zręczność: 1");
                    Console.WriteLine("Inteligencja: 2");
                    Console.WriteLine("Żywotność(HP): 129");
                    Console.WriteLine("Mana(MP): 94");
                    Console.WriteLine("___________________________________________________________");
                }
                else if (wybierz_bohatera == 6)
                {
                    Console.WriteLine("___________________________________________________________\n");
                    Console.WriteLine("Malfurion 'Sędzia' - Druid(Człowiek)");
                    Console.WriteLine("\nGłówne cechy: \n");
                    Console.WriteLine("+ pazury pozwalają mu wywołać krwawienie u przeciwnika");
                    Console.WriteLine("+ dysponuje zaklęciami ziemi");
                    Console.WriteLine("+ może przywołać wilka aby mu pomógł");
                    Console.WriteLine("\nKarta postaci: \n");
                    Console.WriteLine("Poziom: 5");
                    Console.WriteLine("Siła: 6");
                    Console.WriteLine("Zręczność: 3");
                    Console.WriteLine("Inteligencja: 6");
                    Console.WriteLine("Żywotność(HP): 250");
                    Console.WriteLine("Mana(MP): 110");
                    Console.WriteLine("___________________________________________________________");
                }
                else if (wybierz_bohatera == 7)
                {
                    Console.WriteLine("___________________________________________________________\n");
                    Console.WriteLine("Zajcev 'Sokole Oko' - Snajper(Duch)");
                    Console.WriteLine("\nGłówne cechy: \n");
                    Console.WriteLine("+ potrafi zniknąć z oczu przeciwnika");
                    Console.WriteLine("+ potrafi celnie oddać strzał w głowę");
                    Console.WriteLine("+ zna podstawowe zasady opatrywania ran");
                    Console.WriteLine("+ jego broń, Dragunov jest na amunicję");
                    Console.WriteLine("\nKarta postaci: \n");
                    Console.WriteLine("Poziom: 6");
                    Console.WriteLine("Siła: 6");
                    Console.WriteLine("Zręczność: 5");
                    Console.WriteLine("Inteligencja: 7");
                    Console.WriteLine("Żywotność(HP): 100");
                    Console.WriteLine("Amunicja(AP): 20");
                    Console.WriteLine("___________________________________________________________");
                }
                else if (wybierz_bohatera == 8)
                {
                    Console.WriteLine("___________________________________________________________\n");
                    Console.WriteLine("Bartolomeo 'Ćwierćfuntówka' - Kusznik(Umarły)");
                    Console.WriteLine("\nGłówne cechy: \n");
                    Console.WriteLine("+ korzysta z kuszy oblężniczej");
                    Console.WriteLine("+ potrafi naciągnąć na kuszę jednocześnie 2 bełty");
                    Console.WriteLine("+ nie zna magii");
                    Console.WriteLine("+ nie potrafi się leczyć");
                    Console.WriteLine("+ dysponuje bełtami z trucizną");
                    Console.WriteLine("\nKarta postaci: \n");
                    Console.WriteLine("Poziom: 6");
                    Console.WriteLine("Siła: 10");
                    Console.WriteLine("Zręczność: 3");
                    Console.WriteLine("Inteligencja: 5");
                    Console.WriteLine("Żywotność(HP): 500");
                    Console.WriteLine("___________________________________________________________");
                }
                else if (wybierz_bohatera == 9)
                {
                    Console.WriteLine("___________________________________________________________\n");
                    Console.WriteLine("Artur 'Sprawiedliwy' - Włócznik(Człowiek)");
                    Console.WriteLine("\nGłówne cechy: \n");
                    Console.WriteLine("+ potrafi szarżować na przeciwnika");
                    Console.WriteLine("+ ma do pomocy gwardię łuczników");
                    Console.WriteLine("+ jego broń nasycona jest magią(atak kosztuje manę i kondycję)");
                    Console.WriteLine("+ umie wyciszyć umysł odzyskując zdrowie, kondycję i manę");
                    Console.WriteLine("+ dręczy go wampiryzm");
                    Console.WriteLine("\nKarta postaci: \n");
                    Console.WriteLine("Poziom: 6");
                    Console.WriteLine("Siła: 7");
                    Console.WriteLine("Zręczność: 7");
                    Console.WriteLine("Inteligencja: 6");
                    Console.WriteLine("Żywotność(HP): 135");
                    Console.WriteLine("Poziom many(MP): 115");
                    Console.WriteLine("Poziom kondycji(CP): 115");
                    Console.WriteLine("___________________________________________________________");
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
                    Console.WriteLine("treść błędu: Podano błędne dane na wejściu wybierz_bohatera_2\n");
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
}

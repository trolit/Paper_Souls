using System;

namespace paper_souls
{
    interface I_RPGmethods
    {

    }

    interface IRandomize
    {
        int random();
    }

    class Program
    {
        static void Main(string[] args)
        {
            #region Tworzenie postaci do gry
            Postac wybor_bohatera = new Postac();
            Paladyn paladyn1 = new Paladyn(100, 160, "Horx", 3, "Czlowiek", "Szczodry", 6, 7, 2);
            Mag mag1 = new Mag(110, "Harval", 2, "Żaba", "Grzesznik", 125, 3, 9, 3, "Magia wody");
            OrkA ork1 = new OrkA(125, "Ork - Kusznik", 2, "orkowate", 2, 10);
            Szczur szczur1 = new Szczur(100, "Szczur", 2, "szczurowate", 2, 3);
            Bazyliszek bazyliszek1 = new Bazyliszek(150, "Bazyliszek", 3, "Gady", 10);
            Wojownik wojownik1 = new Wojownik(200, "Drakom", 4, "Smok", "Tarczownik", 20, 12, 2, 1, 115);
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
                    Console.WriteLine("Szczur jest szybszy i zaczyna!");
                    int obr_szczura = szczur1.Ugryzienie();
                    paladyn1.zywotnosc = paladyn1.zywotnosc - obr_szczura;
                    Console.WriteLine("Szczur ugryzł Cię zadając " + obr_szczura + " obrażeń!");
                    Console.WriteLine("Twoja kolej, co chcesz zrobić?");
                    Console.WriteLine("1. uderz młotem(6-10obrażeń)");
                    Console.WriteLine("2. ulecz się(-30mana, +30-45hp)");
                    Console.WriteLine("3. modlitwa(++obrażenia na następną turę, +5hp)");
                    Console.WriteLine("4. odpoczynek(+15mana, +6hp)");
                    Console.WriteLine("-> Stan many: " + paladyn1.mana);
                    Console.WriteLine("-> Stan życia: " + paladyn1.zywotnosc);

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
                        Console.WriteLine("2. ulecz się(-30mana, +30-45hp)");
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
            #region Przygoda Wojownika
            else if(wybor_postaci == 2)
            {
                Console.WriteLine("///////////////////////////////////////////////////////////");
                Console.WriteLine("Napotkales przeciwnika -> " + bazyliszek1.imie);
                Console.WriteLine("Co wiesz o przeciwniku?\nPoziom: " + bazyliszek1.poziom + "\nRasa: " + bazyliszek1.rasa);
                Console.WriteLine("\nwalczysz(wpisz 1) czy uciekasz(wpisz 0)?");
                int decyzja_woj = Convert.ToInt32(Console.ReadLine());

                if(decyzja_woj == 1)
                {
                    Console.WriteLine("Bazyliszek jest od Ciebie szybszy! Zaczyna pierwszy!");
                    int licz_obrazenia = bazyliszek1.Ukaszenie();
                    Console.WriteLine("Bazyliszek zadaje " + licz_obrazenia + " obrażeń!");
                    wojownik1.zywotnosc = wojownik1.zywotnosc - licz_obrazenia;
                    Console.WriteLine("Twoja kolej, co chcesz zrobić?");
                    Console.WriteLine("1. uderz oburącz(10-35obrażeń, -27kondycja)");
                    Console.WriteLine("2. wyciszenie(+40kondycja)");
                    Console.WriteLine("3. zionięcie ogniem(10-20obrażeń, -10mana)");
                    Console.WriteLine("4. szarża(8-40obrażeń, -35kondycja)");
                    Console.WriteLine("5. odpoczynek(+6hp, +15mana)");
                    Console.WriteLine("-> Stan many: " + wojownik1.mana);
                    Console.WriteLine("-> Stan życia: " + wojownik1.zywotnosc);
                    Console.WriteLine("-> Stan kondycji: " + wojownik1.kondycja);
                    Console.WriteLine("-> Stan życia wroga: " + bazyliszek1.zywotnosc);
                    int decyzja_teraz = Convert.ToInt32(Console.ReadLine());

                    if (decyzja_teraz == 1 && wojownik1.kondycja >= 27)
                    {
                        licz_obrazenia = wojownik1.Uderzenie_oburacz();
                        bazyliszek1.zywotnosc = bazyliszek1.zywotnosc - licz_obrazenia;
                        Console.WriteLine("Zadałeś " + licz_obrazenia + " obrażeń!");
                    }
                    else if (decyzja_teraz == 2)
                    {
                        wojownik1.Wyciszenie();
                    }
                    else if (decyzja_teraz == 3 && wojownik1.mana >= 10)
                    {
                        wojownik1.Zioniecie_Ogniem();
                    }
                    else if(decyzja_teraz == 4 && wojownik1.kondycja >= 35)
                    {
                        licz_obrazenia = wojownik1.Szarza();
                        bazyliszek1.zywotnosc = bazyliszek1.zywotnosc - licz_obrazenia;
                        Console.WriteLine("Zadałeś " + licz_obrazenia + " obrażeń!");
                    }
                    else if(decyzja_teraz == 5)
                    {
                        wojownik1.Odpocznij();
                    }
                    else
                    {
                        Console.WriteLine("Nie udało się wykonać tego ruchu! Tracisz turę!");
                    }

                    int x;
                    for(x = 0; x < 2;)
                    {
                        if(wojownik1.szarzowanie == true)
                        {
                            wojownik1.szarzowanie = false;
                        }
                        else if(wojownik1.szarzowanie == false)
                        {
                            if (bazyliszek1.skamieniowany == false && bazyliszek1.stan_many >= 10)
                            {
                                bazyliszek1.Skamieniowanie();
                            }
                            else
                            {
                                licz_obrazenia = bazyliszek1.Ukaszenie();
                                wojownik1.zywotnosc = wojownik1.zywotnosc - licz_obrazenia;
                                Console.WriteLine("Bazyliszek zadaje " + licz_obrazenia + " obrażeń!");
                            }
                        }
                        if(wojownik1.zywotnosc <= 0)
                        {
                            Console.WriteLine("Zginąłeś!");
                            break;
                        }

                        if (bazyliszek1.skamieniowany == true)
                        {
                            bazyliszek1.skamieniowany = false;
                            Console.WriteLine("Zostałeś skamieniowany tuż przed wykonaniem ataku!");
                        }
                        else if (bazyliszek1.skamieniowany == false)
                        {
                            Console.WriteLine("Twoja kolej, co chcesz zrobić?");
                            Console.WriteLine("1. uderz oburącz(10-35obrażeń, -27kondycja)");
                            Console.WriteLine("2. wyciszenie(+40kondycja)");
                            Console.WriteLine("3. zionięcie ogniem(10-20obrażeń, -10mana)");
                            Console.WriteLine("4. szarża(8-40obrażeń, -35kondycja)");
                            Console.WriteLine("5. odpoczynek(+6hp, +15mana)");
                            Console.WriteLine("-> Stan many: " + wojownik1.mana);
                            Console.WriteLine("-> Stan życia: " + wojownik1.zywotnosc);
                            Console.WriteLine("-> Stan kondycji: " + wojownik1.kondycja);
                            Console.WriteLine("-> Stan życia wroga: " + bazyliszek1.zywotnosc);
                            decyzja_teraz = Convert.ToInt32(Console.ReadLine());

                            if (decyzja_teraz == 1 && wojownik1.kondycja >= 27)
                            {
                                licz_obrazenia = wojownik1.Uderzenie_oburacz();
                                bazyliszek1.zywotnosc = bazyliszek1.zywotnosc - licz_obrazenia;
                                Console.WriteLine("Zadałeś " + licz_obrazenia + " obrażeń!");
                            }
                            else if (decyzja_teraz == 2)
                            {
                                wojownik1.Wyciszenie();
                            }
                            else if (decyzja_teraz == 3 && wojownik1.mana >= 10)
                            {
                                wojownik1.Zioniecie_Ogniem();
                            }
                            else if (decyzja_teraz == 4 && wojownik1.kondycja >= 35)
                            {
                                licz_obrazenia = wojownik1.Szarza();
                                bazyliszek1.zywotnosc = bazyliszek1.zywotnosc - licz_obrazenia;
                                Console.WriteLine("Zadałeś " + licz_obrazenia + " obrażeń!");
                            }
                            else if (decyzja_teraz == 5)
                            {
                                wojownik1.Odpocznij();
                            }
                            else
                            {
                                Console.WriteLine("Nie udało się wykonać tego ruchu! Tracisz turę!");
                            }
                        }
                        if(bazyliszek1.zywotnosc <= 0)
                        {
                            Console.WriteLine("Bazyliszek pokonany!");
                            break;
                        }
                    }
                }
                else
                {
                    Console.WriteLine("Uciekłeś!");
                }
            }
            #endregion
            #region Przygoda Maga
            else if (wybor_postaci == 3)
            {
                Console.WriteLine("///////////////////////////////////////////////////////////");
                Console.WriteLine("Napotkales przeciwnika -> " + ork1.imie);
                Console.WriteLine("Co wiesz o przeciwniku?\nPoziom: " + ork1.poziom + "\nRasa: " + ork1.rasa + "\nTrudnosc: " + ork1.modyfikator_trudnosci);
                Console.WriteLine("\nwalczysz(wpisz 1) czy uciekasz(wpisz 0)?");
                int decyzja_maga = Convert.ToInt32(Console.ReadLine());

                Console.WriteLine("Ork przygotowuje kuszę, Ty zaczynasz!");
                Console.WriteLine("Co chcesz zrobić?");
                Console.WriteLine("1. strzel kulą ognia(20obrażeń, -25mana)");
                Console.WriteLine("2. zamróź przeciwnika(15obrażeń, -37mana)");
                Console.WriteLine("3. strzel piorunem(27obrażeń, -39mana)");
                Console.WriteLine("4. odpoczynek(+15mana, +6hp)");
                Console.WriteLine("5. wypij miksturę many(+80mana)");
                Console.WriteLine("6. ulecz się(-80mana, +75zdrowie)");
                Console.WriteLine("-->Stan many:" + mag1.mana);
                Console.WriteLine("-->Stan życia:" + mag1.zywotnosc);
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
                else if (decyzja_maga == 6)
                {
                    mag1.Potezne_leczenie();
                }

                int x;
                for(x = 0; x < 2; )
                {
                    if (mag1.zamrozenie == true)
                    {
                        Console.WriteLine("Ork jest zamrożony, ani drgnie!");
                        mag1.zamrozenie = false;
                    }
                    else if (mag1.zamrozenie == false)
                    {
                        if (ork1.przeladowanie == false)
                        {
                            int liczba_obr = ork1.Strzal_Kusza();
                            Console.WriteLine("Ork strzela z kuszy zadając Ci " + liczba_obr + " obrażeń.");
                            mag1.zywotnosc = mag1.zywotnosc - liczba_obr;
                        }
                        else if(ork1.przeladowanie == true)
                        {
                            ork1.Przeladowanie();
                        }
                    }
                    if(mag1.zywotnosc <= 0)
                    {
                        Console.WriteLine("Zginąłeś!");
                    }
                    Console.WriteLine("Co chcesz zrobić?");
                    Console.WriteLine("1. strzel kulą ognia(20obrażeń, -25mana)");
                    Console.WriteLine("2. zamróź przeciwnika(15obrażeń, -37mana)");
                    Console.WriteLine("3. strzel piorunem(27obrażeń, -39mana)");
                    Console.WriteLine("4. odpoczynek(+15mana, +6hp)");
                    Console.WriteLine("5. wypij miksturę many(+80mana)");
                    Console.WriteLine("6. ulecz się(-80mana, +75zdrowie)");
                    Console.WriteLine("-->Stan many:" + mag1.mana);
                    Console.WriteLine("-->Stan życia:" + mag1.zywotnosc);
                    decyzja_maga = Convert.ToInt32(Console.ReadLine());

                    int damage;
                    if (decyzja_maga == 1 && mag1.mana >= 25)
                    {
                        damage = mag1.Kula_ognia();
                        ork1.zywotnosc = ork1.zywotnosc - damage;
                        Console.WriteLine("Stan życia orczego kusznika: " + ork1.zywotnosc + " HP");
                    }
                    else if (decyzja_maga == 2 && mag1.mana >= 37)
                    {
                        damage = mag1.Mrozenie();
                        ork1.zywotnosc = ork1.zywotnosc - damage;
                        Console.WriteLine("Zamroziłeś przeciwnika powodując, że nie może on wykonać swojej tury!");
                        Console.WriteLine("Stan życia orczego kusznika: " + ork1.zywotnosc + " HP");
                    }
                    else if (decyzja_maga == 3 && mag1.mana >= 39)
                    {
                        damage = mag1.Piorun();
                        ork1.zywotnosc = ork1.zywotnosc - damage;
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
                    else if (decyzja_maga == 6)
                    {
                        mag1.Potezne_leczenie();
                    }
                    if(ork1.zywotnosc <= 0)
                    {
                        Console.WriteLine("Pokonałeś orka kusznika!");
                        break;
                    }
                }
            }
            #endregion
            Console.ReadKey();
        }
    }
}

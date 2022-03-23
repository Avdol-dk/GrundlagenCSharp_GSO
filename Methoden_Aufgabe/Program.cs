using System;

namespace Methoden_Aufgabe
{
    class Program
    {
        static void Main(string[] args)
        {
            bool EingabeEingabe = false;
            do
            {
                int zahl = 0;

                int anz_zeichen = 0;
                Console.WriteLine("geben Sie einen Text ein");

                bool Texterror = false;
                string textsave = "a";

                do
                {
                    string Text = Console.ReadLine();




                    if (Text == "")
                    {
                        Console.WriteLine("Die Eingabe war inkorrekt");
                        Texterror = true;


                    }
                    else
                    {
                        Console.WriteLine("korrekte eingabe!");
                        Texterror = false;
                        textsave = Text;

                    }


                } while (Texterror == true);


                Console.WriteLine("geben sie an, wie oft es durchlaufen werden soll");

                bool durchlauferror = false;
                int durchlaufsave = 0;

                do
                {
                    string durchlauf = Console.ReadLine();



                    if (int.TryParse(durchlauf, out zahl))
                    {
                        Console.WriteLine("Es wird {0} mal durchlaufen.", durchlauf);
                        durchlauferror = false;
                        durchlaufsave = int.Parse(durchlauf);

                    }
                    else
                    {
                        Console.WriteLine("geben sie etwas richtiges  für den Durchlauf ein!");
                        durchlauferror = true;

                    }


                } while (durchlauferror == true);
                Console.WriteLine("sie haben alle werte eingegeben, führen sie fort indem sie eine beliebige Taste drücken.");
                Console.ReadKey();

                Console.Clear();

                anz_zeichen = ausgabeTextMalX(textsave, durchlaufsave);

                Console.Write("\nAnzahl der Buchstaben: {0}", anz_zeichen);






                static int ausgabeTextMalX(string i, int x)
                {


                    for (int dl = 0; dl < x; dl++)
                    {
                        Console.WriteLine(i);
                    }
                    int anz_zeichen = i.Length * x;

                    return anz_zeichen;

                }
                Console.WriteLine("wollen sie das Progamm wiederholen? 1 ist ja und 2 nein");
                
                bool EingabeError = false;
                string Eingabe;

                do
                {
                    Eingabe = Console.ReadLine();
                    switch(Eingabe)
                    {
                        case "1":
                            
                                EingabeEingabe = true;
                            break;
                            
                        default:
                            
                                Console.Clear();
                            break;
                    }
                } while (EingabeError == false);
            } while (EingabeEingabe == true);

        }

    }
}

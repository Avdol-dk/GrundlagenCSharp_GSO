using System;

namespace Methoden_Aufgabe
{
    class Program
    {
        static void Main(string[] args)
        {

            {
                // bearbeitet von Deniz Dersim Kest und Samir Yusuf Muric

                bool Progammwiederholen = true;
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
                        else if(Text == "easteregg")
                        {
                            System.Diagnostics.Process.Start("chrome.exe", "https://www.youtube.com/watch?v=rhvF2_JkDhQ");
                            Texterror = true;
                            Console.WriteLine("HAHA, bitte neue Eingabe");
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
                    Console.WriteLine("\nAnzahl der Buchstaben: {0}", anz_zeichen);
                    
                } while (Progammwiederholen == true);


            }
        }
        static int ausgabeTextMalX(string i, int x)
        {
            for (int dl = 0; dl < x; dl++)
            {
                Console.WriteLine(i);
            }
            int anz_zeichen = i.Length * x;
            Console.ReadKey();
            Console.Clear();
            return anz_zeichen;
            
        }
        
    }
}

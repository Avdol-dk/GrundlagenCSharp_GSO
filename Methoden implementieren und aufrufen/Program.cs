using System;

namespace Methoden_implementieren_und_aufrufen
{
    class Program
    {
        static void Main(string[] args)
        {

            short[] Zimmernummer = { 45, 23, 3, 32 };
            string[] Vorname = { "John", "Paul", "George", "Ringo" };
            string[] Nachname = { "Lennon", "McCartney", "Harrison", "Starr" };
            short[] Übernachtungen = { 1, 4, 12, 3 };
            double[] Rechnungsbetrag = { 82.46, 329.84, 989.52, 247.38 };
            bool zimmercheck = false;
            int i = 0;
            string eingabe_string;
            short eingabe_short = 0;
            bool errorcheck = false;
            do
            {

                Console.WriteLine("geben sie einen Wert für Eingabe ein");
                eingabe_string = Console.ReadLine();
                


                bool flag = short.TryParse(eingabe_string, out eingabe_short);
                do
                {



                    if (flag == true)
                    {




                        zimmercheck = Zimmernummer[i] == eingabe_short;
                        if (zimmercheck == true)
                        {
                            Console.WriteLine("hat geklappt");
                            CheckInProgamm(Zimmernummer[i], Vorname[i], Nachname[i], Übernachtungen[i], Rechnungsbetrag[i]);
                        }
                        else if (i < Zimmernummer.Length - 1)
                        {
                            Console.WriteLine("i++");
                            ++i;

                        }
                        else if (i >= Zimmernummer.Length - 1)
                        {
                            Console.WriteLine("i ist zu viel");
                            Console.WriteLine("Geben sie einen neuen Wert für ihre Eingabe ein ");
                            errorcheck = true;

                        }
                    }

                } while (zimmercheck == false);

            } while (errorcheck == true);
        }



        static (short, string, string, short,double) CheckInProgamm(short Zimmernummer, string Vorname, string Nachname, short Übernachtungen, double Rechnungsbetrag)
        {














            return (1, "1","1",1,1);
        }


    }
}

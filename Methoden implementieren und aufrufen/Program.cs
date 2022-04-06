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
            string eingabe_string;
            short eingabe_short = 0;



            Console.WriteLine("geben sie einen Wert für Eingabe ein");
            eingabe_string = Console.ReadLine();



            bool flag = short.TryParse(eingabe_string, out eingabe_short);



           

            if (flag == true)
            {
                //Eingabe Short 
                var daten = CheckInProgamm(eingabe_short, Zimmernummer, Vorname, Nachname, Übernachtungen, Rechnungsbetrag);

                if(daten.Item1)
                {

                }
            }
            else
            {
                //Eingabe String
                var daten = CheckInProgamm(eingabe_string, Zimmernummer, Vorname, Nachname, Übernachtungen, Rechnungsbetrag);


            }
            
            
            
            


        }  
        



        static (bool,short, string, string, short, double) CheckInProgamm(string diff,short[] Zimmernummer, string[] Vorname, string[] Nachname, short[] Übernachtungen, double[] Rechnungsbetrag)
        {
           

            bool checkzahl = false;
            

            int i = 0;
            
          for(int d = 0; d < Nachname.Length;d++)
            {
                if(diff == Nachname[d])
                {
                    i = d;
                    checkzahl = true;
                }

            }

            return (checkzahl,Zimmernummer[i], Vorname[i], Nachname[i], Übernachtungen[i], Rechnungsbetrag[i]);
        }

        static (bool, short, string, string, short, double) CheckInProgamm(short diff, short[] Zimmernummer, string[] Vorname, string[] Nachname, short[] Übernachtungen, double[] Rechnungsbetrag)
        {


            bool checkzahl = false;

            int counter = 0;
            int i = 0;

            do
            {
                checkzahl = diff == Zimmernummer[i];
                if (checkzahl == false & i < Zimmernummer.Length - 1)
                {
                    ++i;

                    Console.WriteLine("0");
                    checkzahl = false;




                }
                else if (diff == Zimmernummer[i])
                {
                    Console.WriteLine("1");

                    checkzahl = true;
                }
                else
                {
                    break;
                }


            } while (checkzahl == false);
            Console.WriteLine(checkzahl);











            return (false, Zimmernummer[i], Vorname[i], Nachname[i], Übernachtungen[i], Rechnungsbetrag[i]);
        }
    }
}

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
            bool zimmercheck = false; bool checkcheck = false;
            string eingabe_string;
            short eingabe_short = 0;
            string eingabe_error = "0";
            bool errorode = false;
            
            Console.WriteLine("Wollen sie einen neuen Gast einschreiben? Für ja geben sie j ein, und für nein jede beliebige taste außer j");
            
            var a= Console.ReadLine();
            if (a == "j")
            {
                int i = Vorname.Length;
                Vorname[i] = Console.ReadLine();
                Console.WriteLine(Vorname[i]);
            }
            

            Console.WriteLine("geben sie einen Wert für Eingabe ein");
            do
            {
                eingabe_string = Console.ReadLine();
                bool flag = short.TryParse(eingabe_string, out eingabe_short);
                if (flag == true)
                {
                    //Eingabe Short 
                    var daten = CheckInProgamm(eingabe_short, Zimmernummer, Vorname, Nachname, Übernachtungen, Rechnungsbetrag);
                    while (daten.Item1 == true)
                    {
                        Console.WriteLine("{0},{1} besetzt Zimmer {2} für {3} Tage und bezahlt dafür {4} Euro", daten.Item4, daten.Item3, daten.Item2, daten.Item5, daten.Item6);
                        break;
                    }
                    while (daten.Item1 == false)
                    {
                        Console.WriteLine("Geben sie einen neuen gültigen Wert ein");
                        errorode = true;
                        break;
                    }
                }
                else
                { //Eingabe String 
                    var daten = CheckInProgamm(eingabe_string, Zimmernummer, Vorname, Nachname, Übernachtungen, Rechnungsbetrag);

                    while (daten.Item1 == true)
                    {
                        Console.WriteLine("{0},{1} besetzt Zimmer {2} für {3} Tage und bezahlt dafür {4} Euro", daten.Item4, daten.Item3, daten.Item2, daten.Item5, daten.Item6);
                        break;
                    }
                    while (daten.Item1 == false)
                    {
                        Console.WriteLine("Geben sie einen neuen gültigen Wert ein");
                        errorode = true;
                        break;
                    }


                }
            } while (checkcheck == false);
          
        }  
        



        static (bool,short,string, string, short, double) CheckInProgamm(string diff,short[] Zimmernummer, string[] Vorname, string[] Nachname, short[] Übernachtungen, double[] Rechnungsbetrag)
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

            for (int d = 0; d < Zimmernummer.Length; d++)
            {
                if (diff == Zimmernummer[d])
                {
                    i = d;
                    checkzahl = true;
                }
            }
            
            return (checkzahl, Zimmernummer[i], Vorname[i], Nachname[i], Übernachtungen[i], Rechnungsbetrag[i]);
        }
    }
}

using System;

namespace Methoden_implementieren_und_aufrufen
{
    class Program
    {
        static void Main(string[] args)
        {
            //bearbeitet von Deniz Dersim Kest und Samir Yusuf Muric
            global::System.Console.WriteLine("Willkommen, das Progamm dient als elektronische Gästeliste. Wenn sie exit eingeben, verlassen sie das Progamm");

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
            bool infocode = false, subinfo = false, doinfo = false;

           
           
            
            Console.WriteLine("Wollen sie einen neuen Gast einschreiben? Für ja geben sie j ein, und für nein jede beliebige taste außer j");
            
            var a= Console.ReadLine();
            do
            {
                infocode = false;
                Console.WriteLine("Falls sie doch kein Gast eingeben wollen, geben sie sub ein.");
                if (a == "j")
                {
                    
                    Console.Clear();
                    int VN = Vorname.Length;

                        Console.WriteLine("Geben sie den Vorname ein");
                        Array.Resize(ref Vorname, VN + 1);
                        
                     do 
                     {
                        doinfo = false;
                        Vorname[VN] = Console.ReadLine();
                            if (Vorname[VN] == "exit")
                            {
                                Console.WriteLine("Das Progamm wird geschlossen...");
                                Environment.Exit(0);
                            }
                            else if(Vorname[VN] == "sub")
                            {
                                doinfo = true;
                            } 
                            else if(doinfo != short.TryParse(Vorname[VN], out eingabe_short))
                            {
                                Console.WriteLine("geben sie einen Gültigen Vornamen ein");
                                doinfo = true;
                            }                                       
                     } while (doinfo == true);
                    if (VN > Nachname.Length - 1)
                    {
                        Console.WriteLine("Geben sie den Nachnamen ein");
                        Array.Resize(ref Nachname, VN + 1);
                    }
                    Nachname[VN] = Console.ReadLine();
                    if (VN > Zimmernummer.Length - 1)
                    {
                        Console.WriteLine("geben sie die Zimmernummer ein");
                        Array.Resize(ref Zimmernummer, VN + 1);
                    }
                    Zimmernummer[VN] = Convert.ToInt16(Console.ReadLine());
                    if (VN > Übernachtungen.Length - 1)
                    {
                        Console.WriteLine("geben sie die Anzahl der Übernachtungen ein");
                        Array.Resize(ref Übernachtungen, VN + 1);
                    }
                    Übernachtungen[VN] = Convert.ToInt16(Console.ReadLine());
                    if (VN > Rechnungsbetrag.Length - 1)
                    {
                        Array.Resize(ref Rechnungsbetrag, VN + 1);
                    }
                    Rechnungsbetrag[VN] = 82.46 * Übernachtungen[VN];
                    Console.WriteLine("{0},{1} besetzt Zimmer {2} für {3} Tage und bezahlt dafür {4} Euro", Vorname[VN], Nachname[VN], Zimmernummer[VN], Übernachtungen[VN], Rechnungsbetrag[VN]);

                    Console.WriteLine("Wollen sie noch einen Gast hinzufügen?Für ja geben sie j ein, und für nein jede beliebige taste außer j");
                    var dak = Console.ReadLine();
                    if (dak == "j")
                    {
                        infocode = true;                  
                    }
                    Console.Clear();
                }
            } while (infocode == true);


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
                        Console.WriteLine("{0},{1} besetzt Zimmer {2} für {3} Tage und bezahlt dafür {4:F2} Euro", daten.Item4, daten.Item3, daten.Item2, daten.Item5, daten.Item6);
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
            //Beispiel identische nachnamen
            //count: Anzahl der identischen Nachnamen bestimmen
            //index_identisch: Indexe der identischen Nachnamen
            //[2,4]
            //Elemente_identische: Array mit allen Emelementen die auf den diff passen
            //Elemente_zn_identische[] = {Zimmernumemr[2],Zimmernumemr[4]};
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

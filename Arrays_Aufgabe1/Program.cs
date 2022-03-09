using System;

namespace Arrays_Aufgabe1
{
    class Program
    {
        static void Main(string[] args)
        {
            int Note = 0, AnzahlSchüler = 0;
            double Notenschnitt = 0;
            string name = "FortniteBurger69" ;

            Console.WriteLine("Wie viele Schüler sind in ihrer Klasse?");
            AnzahlSchüler = Convert.ToInt32(Console.ReadLine());

            string[] namen = new string[AnzahlSchüler];

            int[] noten = new int[AnzahlSchüler];
            int anzahl = 1;

            for (int AnzahlS = 0; AnzahlS < AnzahlSchüler; AnzahlS++)
            {

                
                    Console.WriteLine("Schüler Name {0}",anzahl);
                    anzahl++;
                    name = Console.ReadLine();

                    namen[AnzahlS] = name;

                    Console.WriteLine("{0} Note:",name);
                    Note = Convert.ToInt32(Console.ReadLine());

                    noten[AnzahlS] = Note;
                    Notenschnitt = Notenschnitt + Note;
                    Console.Clear();
                
            }
            for (int Ausgabe = 0; Ausgabe < AnzahlSchüler; Ausgabe++)
            {
                Console.WriteLine(namen[Ausgabe] + "\tNote:" + noten[Ausgabe]);
               
            }
            

            Console.WriteLine("Der Notenschnitt beträgt:{0:F2}",Notenschnitt / AnzahlSchüler);
        }
    }
}

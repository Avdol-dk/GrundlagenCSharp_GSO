using System;

namespace Methoden_Aufgabe
{
    class Program
    {
        static void Main(string[] args)
        {
            int anz_zeichen = 0;
            int durchlauf = 0;

            Console.WriteLine("geben Sie einen Text ein");

            string Text = Console.ReadLine();
            Console.WriteLine("geben sie an, wie oft es durchlaufen werden soll");
            durchlauf = Convert.ToInt32(Console.ReadLine());
            
            Console.Clear();

            anz_zeichen = ausgabeTextMalX(Text,durchlauf);

            Console.Write("\nAnzahl der Buchstaben: {0}", anz_zeichen);
            

            
            

        }

      
        static int ausgabeTextMalX(string i, int x)
        {


            for(int dl = 0; dl < x;dl++)
            {
                Console.WriteLine(i);
            }
            int anz_zeichen = i.Length * x;

            return anz_zeichen;
         
        }

    }

}

using System;
using System.Threading;

namespace Aufgaben
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("SAS Schleifen (Make Gaming)");

            Console.WriteLine("Aufgabe 1-10, welche wollen sie öffnen?");
            string aufgaben = Console.ReadLine();
            switch (aufgaben)
            {
                case "1":
                    Aufgaben.Program.Aufgabe_1();
                    break;

                case "2":
                    Aufgaben.Program.Aufgabe_2();
                    break;

                case "3":
                    Aufgaben.Program.Aufgabe_3();
                    break;

                case "4":
                    Aufgaben.Program.Aufgabe_4();
                    break;

                case "5":
                    Aufgaben.Program.Aufgabe_5();
                    break;

                case "6":
                    Aufgaben.Program.Aufgabe_6();
                    break;

                case "7":
                    Aufgaben.Program.Aufgabe_7();
                    break;

                case "8":
                    Aufgaben.Program.Aufgabe_8();
                    break;

                case "9":
                    Aufgaben.Program.Aufgabe_9();
                    break;

                case "10":
                    Aufgaben.Program.Aufgabe_10();
                    break;

            }
        }

        static void Aufgabe_1()
        {


            for (int i = 50; i >= 0; i--)
            {

                Console.WriteLine(i);
                Thread.Sleep(1000);

            }




        }

        static void Aufgabe_2()
        {

            for (int i = 0; i <= 50; i++)
            {

                Console.WriteLine("Ich muss immer meine Hausaufgaben machen. ({0})", i);

            }



        }

        static void Aufgabe_3()
        {

            for (int i = 1; i <= 10; i++)
            {

                Console.WriteLine("Das Quadrat von {0} ist {1}.", i, i * i);

            }

        }

        static void Aufgabe_4()
        {

            for (int i = 100; i >= 10; i = i - 10)
            {

                Console.Write(i);

            }

        }

        static void Aufgabe_5()
        {
            int i = 0, n = i * -1;

            Console.WriteLine("Geben sie bitte eine Zahl ein.");

            for (i = Convert.ToInt32(Console.ReadLine()); n <= i; n = n + 2)
            {

                Console.Write(n);

            }

        }

        static void Aufgabe_6()
        {
            int auswahl = 0;
            do
            {
                Console.WriteLine("Wählen sie etwas aus diesem (gaming) Auswahlmenü \n(1) Auswahlmöglichkeit \n(2) Sehr gaminghafte Auswahlmöglichkeit \n(3) Google \n(4) [Hier könnte ihre Werbung stehen] \n(0) exit");
                auswahl = Convert.ToInt32(Console.ReadLine());
                switch (auswahl)
                {


                    case 1:
                        System.Diagnostics.Process.Start("explorer.exe", "https://www.google.com");
                        break;
                    case 2:
                        System.Diagnostics.Process.Start("explorer.exe", "https://www.google.com/url?sa=i&url=https%3A%2F%2Fwww.getshirts.de%2Findex.php%3Fpage%3Dartikel%26id%3D364447&psig=AOvVaw0ygkISoEXQM4OkCWbClber&ust=1643865003322000&source=images&cd=vfe&ved=0CAsQjRxqFwoTCOin6sWg4PUCFQAAAAAdAAAAABAD");
                        break;
                    case 3:
                        Console.WriteLine("Sie haben die Auswahl erfolgreich beendet(True Gamer)");
                        break;
                }

            }
            while (auswahl != 0);
        }

        static void Aufgabe_7()
        {
            int n = 0, i = 0, z = 0;

            Console.WriteLine("Geben sie eine Zahl ein.");

            for (n = Convert.ToInt32(Console.ReadLine()); n >= i; i++)
            {
                z = z + i;
            }
            Console.WriteLine("Die Summe der Zahlen von 0 bis {0} ist {1}.", n, z);
        }

        static void Aufgabe_8()
        {
            int pin = 0, counter = 0;
            do
            {

                Console.WriteLine("Bitte geben sie ihr PIN ein.");
                pin = Convert.ToInt32(Console.ReadLine());
                counter++;

            }
            while (pin != 1234);

            Console.WriteLine("Sie haben {0} Versuche benötigt um die PIN richtig einzugeben, wyld", counter);
        }

        static void Aufgabe_9()
        {
            int jahre = 0;
            double k = 0, p = 0, s = 0;

            Console.WriteLine("Bitte geben sie das Kapital auf ihrem Konto ein");
            k = Convert.ToDouble(Console.ReadLine());

            Console.WriteLine("Geben sie bitte den Zinssatz in Prozent ein");
            p = Convert.ToDouble(Console.ReadLine());
            p = p / 100;

            for (s = 0 + k; s <= k * 2;)
            {
                s = s + (s * p);
                jahre++;

            }
            Console.WriteLine("Es dauert {0} Jahre bis sich das zurzeit bestehende Kapital auf ihrem Konto verdoppelt hat", jahre);

        }

        static void Aufgabe_10()
        {
            Console.WriteLine("Geben sie die Höhe des Baumes an");
            int n = Convert.ToInt32(Console.ReadLine());

            for (int i = 0; i < n; i++)
            {
                int ansleer = n - i;
                for (int q = 1; q <= ansleer; q++)
                {

                    Console.Write(" ");

                }
                for (int q = 1; q <= 1 + (i * 2); q++)
                {
                    Console.Write("*");
                }

            }



        }


    }

}



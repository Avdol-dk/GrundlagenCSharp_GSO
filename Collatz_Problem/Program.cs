using System;

namespace Collatz_Problem_Methoden_Übung
{
    class Program
    {
        static void Main(string[] args)
        {
            //Ich versuche hier das Collatz Problem als Methode zu visualisieren.

            Console.WriteLine("Um das Progamm zu verstehen,\nEs wird bei einer geraden Zahl durch 2 Dividiert also X % 2.\nUnd bei einer ungeraden Zahl mal 3 genommen und +1 addiert. Also 3x+1");
            Console.WriteLine("\nDrücken sie eine beliebige Taste um Fortzufahren");
            Console.ReadKey();
            Console.Clear();
            Console.WriteLine("Geben sie nun ihren Integer ein, mit dem sie anfangen wollen");
            int Collatz_Eingabe = Convert.ToInt32(Console.ReadLine());
      
            Collatz_Eingabe = CollatzRechnung(Collatz_Eingabe);
            
            
            




        }
        static int CollatzRechnung(int x)
        {
            Console.Clear();
            
            int counter = 0;
            do
            {
                if (x != 1)
                {



                    if (x % 2 == 0)
                    {
                        x = x / 2;
                        Console.WriteLine(x);
                        Console.ReadKey();
                    }
                    else if (x % 2 != 0)
                    {
                        x = (x * 3) + 1;
                        Console.WriteLine(x);
                        Console.ReadKey();

                    }

                }

                else if (x == 1)
                {

                    x = (x * 3) + 1;

                    counter++;
                    


                }
                

            } while (counter != 3);
          
            do
            {


                if (x % 2 == 0)
                {
                    x = x / 2;
                    Console.WriteLine(x);
                    Console.ReadKey();
                }
                else if (x % 2 != 0)
                {
                    x = (x * 3) + 1;
                    Console.WriteLine(x);



                }
                else if (x == 1)
                {

                    x = (x * 3) + 1;


                    Console.WriteLine("Und schon wieder...");
                    Console.ReadKey();


                }
            } while (counter == 9999);


            return x;
        }
    }
}

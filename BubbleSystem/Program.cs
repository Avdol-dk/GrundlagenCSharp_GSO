using System;

namespace BubbleSystem
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] daten = { 45, 10, 15, 4 };
            Console.WriteLine(daten[0]);
            Console.WriteLine(daten[1]);
            Console.WriteLine(daten[2]);
            Console.WriteLine(daten[3]);
            Console.WriteLine();
            //get beamed by Monkey Squad

            int index = 0;
            for (int i = daten.Length-1; index < i; index++)
            {
               
               
               if (daten[index] > daten[index + 1])
                {

                    int buffer;

                    buffer = daten[index + 1];
                    daten[index + 1] = daten[index];
                    daten[index] = buffer;

 


                }
               

            }

            

            Console.WriteLine(daten[0]);
            Console.WriteLine(daten[1]);
            Console.WriteLine(daten[2]);
            Console.WriteLine(daten[3]);
            Console.WriteLine();
            Console.WriteLine(index);


        }
    }
}

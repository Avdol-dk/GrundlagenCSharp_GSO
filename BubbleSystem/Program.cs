using System;

namespace BubbleSystem
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] daten = { 45, 10, 15, 4, 2, 78, 1, 0, 69 };
            foreach (int i in daten)
            {
                Console.WriteLine(i);

            }
            Console.WriteLine();

            //get beamed by Monkey Squad
            int counter = 0;
            do
            {
                int index = 0;
                for (int i = daten.Length - 1; index < i; index++)
                {


                    if (daten[index] > daten[index + 1])
                    {

                        int buffer;

                        buffer = daten[index + 1];
                        daten[index + 1] = daten[index];
                        daten[index] = buffer;




                    }


                }

                counter++;

                foreach (int i in daten)
                {
                    Console.WriteLine(i);

                }
                
                Console.ReadKey();
                Console.Clear();


            } while (counter != daten.Length-1);
        }
    }   
}

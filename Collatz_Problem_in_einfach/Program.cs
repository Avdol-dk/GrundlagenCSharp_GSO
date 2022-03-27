using System;

namespace Collatz_Problem_in_einfach
{
    class Program
    {
        static void Main(string[] args)
        {
            int Collatz_Eingabe = Convert.ToInt32(Console.ReadLine());
            Collatz_Eingabe = CollatzReihe(Collatz_Eingabe);
        }
        static int CollatzReihe(int x)
        {
            Console.Clear();
            while (x != 1)
            {
                Console.WriteLine(x);
                x = Collatz(x);
            }
            return x;
        }
        static int Collatz(int x)
        {
            if (x == 1)
            {
                return 3 * x + 1;
                Console.WriteLine(x);
            }
            return x / 2;
        }
    }
}

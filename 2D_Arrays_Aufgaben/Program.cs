using System;

namespace _2D_Arrays_Aufgaben
{
    class Program
    {
        static void Main(string[] args)
        {
            int[,] ZweiDimensionalerArray = new int[9, 5];
            int anzahlX = ZweiDimensionalerArray.GetLength(0);  


            for(int index_y=0; index_y<ZweiDimensionalerArray.GetLength(1);index_y++)
            {

                for (int index_x = 0; index_x < ZweiDimensionalerArray.GetLength(0); index_x++)
                {
                    Console.WriteLine($"Sie befinden sich in Zeile {index_y+1} und Spalte {index_x+1}");
                    Console.WriteLine($"Geben Sie einen Wert ein!: ");
                    ZweiDimensionalerArray[index_x, index_y] = Convert.ToInt32(Console.ReadLine());


                }




            }

            for (int index_y = 0; index_y < ZweiDimensionalerArray.GetLength(1); index_y++)
            {

                for (int index_x = 0; index_x < ZweiDimensionalerArray.GetLength(0); index_x++)
                {
                    Console.WriteLine("1\t2\t3\t4\t5\t6\t7\t8\t9");



                }




            }





        }
    }
}

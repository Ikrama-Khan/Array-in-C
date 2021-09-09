using System;

namespace Array_in_C
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] number = { 1, 3, 5, 7, 9, 11 };

            //Console.WriteLine(number[0]);
            //Console.WriteLine(number[1]);
            //Console.WriteLine(number[2]);
            //Console.WriteLine(number[3]);
            //Console.WriteLine(number[4]);
            //Console.WriteLine(number[5]);


            for (int a = 0; a <= 5 ; a++)
            {
                Console.WriteLine(number[a]);
            }


            Console.ReadKey();
        }
    }
}

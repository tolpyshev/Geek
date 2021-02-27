using System;

namespace T1
{
    class Program
    {
        static void Main(string[] args)
        {

            string greeting = "Hello, world!";
            for (int i = 0; i < greeting.Length; i++)
            {
                Console.WriteLine(greeting[i]); // построчный вывод каждого символа строки
            }













            int[,] dmass = { { 1, 2, 3 }, { 4, 5, 6 } };

            for (int i = 0; i < dmass.GetLength(0); i++)
            {
                for (int j = 0; j < dmass.GetLength(1); j++)
                {
                    Console.WriteLine($"{dmass[i, j]}");
                }
            }
        }
    }
}

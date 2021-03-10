using System;

namespace Lesson2Task3
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Пожалуйста, введите число: ");
            int NumToCheck = Convert.ToInt32(Console.ReadLine());
            int EndNum = NumToCheck % 2;
            if (EndNum == 0)
                {
                Console.WriteLine("Введённое число является чётным");
                }
            else
                {
                Console.WriteLine("Введёное число не является четным");
                }
            Console.ReadLine();




        }   
    }
}

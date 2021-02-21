using System;

namespace T7
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Введите номер года: ");
            int year = Convert.ToInt32(Console.ReadLine());


            if (year % 400 == 0) // Проверка кратности 400. Каждый 400-й год високосный
                {
                Console.WriteLine("Год високосный!");
                }
            else if (year % 100 == 0) //Проверка кратности 100. Если Год не кратен 400, но кратен 100 , то он невисокосный.
                {
                Console.WriteLine("Год невисокосный.");
                }
            else if (year % 4 == 0) //Если год не кратен ни 400,  ни 100, Но кратен 4, то он високосный.
                {
                Console.WriteLine("Год високосный!");
                }
            else { Console.WriteLine("Год невисокосный"); }  //Все остальные невисокосные.
        }       
    }
}

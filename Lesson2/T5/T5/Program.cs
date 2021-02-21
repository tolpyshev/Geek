using System;

namespace T5
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter number of month");
            int M = int.Parse(Console.ReadLine()); //Ввод номера месяца
            DateTime D = new DateTime(2021, M, 01); //Ввод даты с указанием месяца, указанного выше.
            Console.WriteLine("На дворе месяц " + D.ToString("MMMM"));
            

            Console.Write("Введите минимальную температуру: ");
            double minTemp = Convert.ToDouble(Console.ReadLine()); //Вводим минимальную температуру с преобразованием строкового представления в число с запятой
            Console.WriteLine("Введите максимальную температуру: ");
            double maxTemp = Convert.ToDouble(Console.ReadLine()); //Вводим максимальную температуру с преобразованием строкового представления в число с запятой
            double avTemp = ((minTemp + maxTemp) / 2);
            Console.WriteLine("Средняя температура " + avTemp);

            if (M == 12 || M < 3 && avTemp > 0)   //Проверяем является ли введённый месяц зимним.
            {
                Console.WriteLine("Зима Мокрый");
            }
            else if (M > 2 && M < 12 && avTemp < 0) //Проверяем является ли месяц незимним и температуру
            {
                Console.WriteLine("На дворе не зима, но холодно!");
            }
            else if (M > 2 && M < 12 && avTemp > 0) //Проверяем является ли месяц незимним и температуру.
            {
                Console.WriteLine("На дворе не зима"); 
            }
            else
                {
                    Console.WriteLine("Зима Немокрый");
                }
            }








        }
}

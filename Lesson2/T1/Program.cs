using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lesson2
{
    class Program1
    {
        
        static void Main(string[] args)
        {
            {
                
                Console.Write("Введите минимальную температуру: ");
                double minTemp = Convert.ToDouble(Console.ReadLine()); //Вводим минимальную температуру с преобразованием строкового представления в число с запятой
                Console.WriteLine("Введите максимальную температуру: ");
                double maxTemp = Convert.ToDouble(Console.ReadLine()); //Вводим максимальную температуру с преобразованием строкового представления в число с запятой
                double avTemp = ((minTemp + maxTemp) / 2);
                Console.WriteLine($"Средняя температура по больнице: {avTemp}");
                
              
            }




        }
    }
}

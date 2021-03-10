using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lesson2
{
    class Program
    {
        
        static void Main(string[] args)
        {
            Console.WriteLine("Enter number of month"); 
                int M = int.Parse(Console.ReadLine()); //Ввод номера месяца
                DateTime D = new DateTime(2021, M, 01); //Ввод даты с указанием месяца, указанного выше.
                Console.WriteLine(D.ToString("MMMM")); //Вывод названия месяца
                Console.ReadLine(); // Пауза
        }
    }
    }
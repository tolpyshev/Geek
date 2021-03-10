using System;
using System.IO;

namespace T3
{
    class Program
    {
        static void Main(string[] args)
        {
            string outTime = "time.txt"; //файл для приёма времени
            string time = DateTime.Now.ToString("t");  //переменная в которую пишется время
            File.AppendAllText(outTime, time + "\n"); //вывод переменной в файл с добавлением новой строки

        }
    }
}

using System;

namespace T1
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] Fullname = new string[3];    //Объявление массива с ФИО

            for (int i = 0; i < 3; i++)           //Цикл ,который соберет ФИО три раза, передаст их в метод,а тот вернёт в массив.
            {
                Console.WriteLine("Ввеодите фамилию");
                string getlastName = (Console.ReadLine());
                Console.WriteLine("Ввеодите имя");
                string getfirstName = (Console.ReadLine());
                Console.WriteLine("Ввеодите отчество");
                string getpatronymic = Console.ReadLine();
                Fullname[i] = GetFullName(getlastName, getfirstName, getpatronymic);
            }

            Console.WriteLine("Полученные ФИО");    

            for (int i = 0; i < Fullname.Length; i++)   //Цикл, который выведет поочерёдно три ФИО , что были введены ранее.
            {
                Console.WriteLine(Fullname[i]);
            }
        }

        static string GetFullName(string lastName, string firstName, string patronymic)  //Метод, который требовался в задаче 1 урока 4.
            {
               return lastName + " " + firstName + " " + patronymic;
            }

     

    }




}


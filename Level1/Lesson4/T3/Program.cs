using System;

namespace T3
{
    class Program
    {

        public enum Seasons
        {
            Winter,
            Spring,
            Summer,
            Autumn,
            Unknown
        }

        static Seasons getMonthEnum(int get)
        {
            if (get > 0 && get < 3 || get == 12)
            {
                return Seasons.Winter;
            }
            else if (get > 2 && get < 6)
            {
                return Seasons.Spring;
            }
            else if (get > 5 && get < 9)
            {
                return Seasons.Summer;
            }
            else if (get > 8 && get < 12)
            {
                return Seasons.Autumn;
            }
            return Seasons.Unknown;
        }

        static string getTrans(Seasons Name)
        {
            string Result;
            if (Name == Seasons.Winter)
            {
                Result = "Зима";
            }
            else if (Name == Seasons.Spring)
            {
                Result = "Весна";
            }
            else if (Name == Seasons.Summer)
            {
                Result = "Лето";
            }
            else if (Name == Seasons.Autumn)
            {
                Result = "Осень";
            }
            else Result = "Неизвестный месяц";

            return Result;

        }



        static void Main(string[] args)
        {
            int month = Convert.ToInt32(Console.ReadLine());
            if (month < 1 || month > 12)
            {
                Console.WriteLine("Wrong month Num");
            }
            else Console.WriteLine(getTrans(getMonthEnum(month)));
            



            
            
            
                        





        }
    }
}

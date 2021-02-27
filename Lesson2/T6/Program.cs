using System;

namespace T6
{
    class Program
    {
        [Flags]
        public enum DaysOfWeek {
            Пн = 0b_0000001,
            Вт = 0b_0000010,
            Ср = 0b_0000100,
            Чт = 0b_0001000,
            Пт = 0b_0010000,
            Сб = 0b_0100000,
            Вс = 0b_1000000,
        }

        static void Main(string[] args)
        {
            
            DaysOfWeek Office1 = DaysOfWeek.Пн | DaysOfWeek.Вт | DaysOfWeek.Ср | DaysOfWeek.Чт | DaysOfWeek.Пт;
            DaysOfWeek  Office2 = (DaysOfWeek)0b_1111111;

            Console.WriteLine($"Расписание белых людей : {Office1}");
            Console.WriteLine($"Расписание всех остальных : {Office2}");

            



        }
    }
}

using System;

namespace L2T4
{
    class Program
    {
        static void Main(string[] args)
        {
            string line = "---------------------------------------------";
            string shopname = ("ООО \u0022Майбах Москоу Групп\u0022");
            string check = "Кассовый чек ";
            string op = "Приход ";
            DateTime date = new DateTime(2021, 02, 23);
            int checknum = 0019;
            int smena = 0060;
            long inn = 7722852550;
            string address = "111033, город Москва, Таможенный проезд, дом 6 стр 3";
            string place = "Автосалон Авилон";
            string goods = "Автомобили";
            int count = 2;
            int price = 55000000;
            int NDS = (price/100)*20;
            int itog = price * count;
            int recieved = 115000000;
            int change = recieved - itog;
            string kassir = "Козкина Е.С.";
            string fns = "www.nalog.ru";
            long RegNumKKT = 0009277640665123;
            long FN = 624876128736123;
            string thx = "СПАСИБО ЗА ПОКУПКУ";

            Console.WriteLine(line);
            Console.WriteLine(shopname);
            Console.WriteLine(line);
            Console.WriteLine(check);
            Console.WriteLine(op);
            Console.WriteLine(line);
            Console.WriteLine(date);
            Console.WriteLine($"Чек " + checknum + " Смена " + smena);
            Console.WriteLine(shopname);
            Console.WriteLine("ИНН " + inn);
            Console.WriteLine(address);
            Console.WriteLine("Место расчётов: " + place);
            Console.WriteLine(line);
            Console.WriteLine(goods);
            Console.WriteLine(count + " x " + price);
            Console.WriteLine("НДС 20% " + NDS);
            Console.WriteLine(line);
            Console.WriteLine("Итог " + itog);
            Console.WriteLine("Получено " + recieved);
            Console.WriteLine("Сдача " + change);
            Console.WriteLine(line);
            Console.WriteLine("Кассир: " + kassir);
            Console.WriteLine("Сайт ФНС " + fns);
            Console.WriteLine("РН ККТ " + RegNumKKT);
            Console.WriteLine("ФН " + FN);
            Console.WriteLine(line);
            Console.WriteLine(thx);
            Console.WriteLine(line);
            Console.ReadLine();

















        }
    }
}

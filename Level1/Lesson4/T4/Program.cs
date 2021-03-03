using System;

namespace T4
{
    class Program
    {
        static int Fibo(int num)
        {

            if (num < 2)
            {
                return num;
            }
            return Fibo(num - 1) + Fibo(num - 2);



        }


        static void Main(string[] args)
        {
            int Num = Convert.ToInt32(Console.ReadLine());

            int FiboNum = Fibo(Num);
           
            Console.WriteLine(FiboNum);


        }
    }
}


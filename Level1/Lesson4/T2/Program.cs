using System;

namespace T2
{
    class Program
    {
        static void Main(string[] args)
        {
            string S = Sum(Console.ReadLine());
            Console.WriteLine(S);

            
        }
        static string Sum(string s)
        {
            string[] stringMass = s.Split(' ');
            int[] intMass = new int[stringMass.Length];
            int sum = 0;
            for (int i = 0; i < stringMass.Length; i++)
            {
                intMass[i] = Convert.ToInt32(stringMass[i]);
                sum = intMass[i] + sum;
                
            }
            string res = Convert.ToString(sum);
            return res;
        }
        

    }




}
using System;
using System.IO;


namespace T1
{
    class Program
    {
        static void Main(string[] args)
        {
            string OutFile = "Челобитная.txt";
            File.WriteAllText(OutFile, "Очень добрый день Артём, разрешите сдать третий уроки, по семейным обстоятельствам, независящим от меня, не успевал его сдать. Ну пожааалуйста. ");
        }
    }
}

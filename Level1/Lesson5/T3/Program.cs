using System;
using System.Runtime.Serialization.Formatters.Binary;
using System.IO;


namespace T3
{
    class Program
    {
        static void Main(string[] args)
        {
            string s = Console.ReadLine();
            BinaryFormatter formatter = new BinaryFormatter();
            formatter.Serialize(new FileStream("numbers.bin", FileMode.OpenOrCreate), s);

        }
    }
}

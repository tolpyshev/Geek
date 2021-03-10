using System;
using System.IO;




namespace L6T1
{
    class Program
    {



        static void Main(string[] args)
        {
            Console.WriteLine("\n\n\nУрок 6 задание 1\n-------------------------------------------------------------------");
            ShowDirFiles();
            ShowDirFilesRec(@"C:\tmp");

            Console.WriteLine("\n\nУрок 6 задание 3\n-------------------------------------------------------------------");

            string[,] mass4x4 = { { "1", "2", "3", "4" }, { "1", "2", "3", "4" }, { "1", "х", "3", "4" }, { "1", "2", "3", "4" } };

            Console.WriteLine($"Сумма всех чисел массива: {ArraySum(mass4x4)}");

            Console.WriteLine("\n\n\nУрок 6 задание 4\n-------------------------------------------------------------------");


            Sotrudnik[] dreamteam = new Sotrudnik[5];
            dreamteam[0] = new Sotrudnik("Пирожков Артур Батькович", "Директор мира", "director@mail.ru", "3322", 100500, 99);
            dreamteam[1] = new Sotrudnik("Вершков Андрей Николаевич", "Айтишник в душе", "vershkov@mail.ru", "8100", 200000, 45);
            dreamteam[2] = new Sotrudnik("Плющ Денис Геннадьевич", "Заместитель несуществующей должности", "plyush@mail.ru", "56712", 199000, 41);
            dreamteam[3] = new Sotrudnik("Судорога Кирилл Александрович", "Инженер", "kuznetsov@mail.ru", "55114", 45000, 27);
            dreamteam[4] = new Sotrudnik("40 лет вайти", "Руководитель отдела руководителей", "ruk@mail.ru", "55555", 99999 , 31);

            for (int i = 0; i < dreamteam.Length; i++)
            {
                dreamteam[i].PrintEmpInfo();
            }





        }

        private static void ShowDirFiles()
        {
            string searchdir = @"C:\tmp";
            if (!Directory.Exists(searchdir))
            {
                Console.WriteLine("Директория не найдена");
                return;
            }
            string[] scan = Directory.GetFileSystemEntries(searchdir, "*", SearchOption.AllDirectories);

            for (int i = 0; i < scan.Length; i++)
            {
                Console.WriteLine(scan[i]);
            }

        }

        static void ShowDirFilesRec(string path)
        {

            if (!Directory.Exists(path))
            {
                Console.WriteLine("Директория не найдена");
                return;
            }

            string[] scandir = Directory.GetFileSystemEntries(path, "*", SearchOption.TopDirectoryOnly );
            

            for (int i = 0; i < scandir.Length; i++)
            {
                Console.WriteLine(scandir[i]);
            }

            string[] subdir = Directory.GetDirectories(path);
            for (int i = 0; i < subdir.Length; i++)
            {
                ShowDirFilesRec(subdir[i]);
            }

            ///////////////////////////////////////////////////////////////////////////////////////////////
        }

        static int ArraySum(string[,] mass)
        {
            try
            {
                if (mass.GetLength(0) != 4 || mass.GetLength(1) != 4)
                {
                    throw new ArraySizeException();
                }
                
            }
            catch (ArraySizeException)
            {
                      Console.WriteLine("Несоответствующий размер массива");          
            }


            try
            {

            }
            catch (Exception)
            {

                throw;
            }
            int sum = 0;
            for (int i = 0; i < mass.GetLength(0); i++)
            {
                for (int j = 0; j < mass.GetLength(1); j++)
                {
                    try
                    {
                        if (int.TryParse(mass[i, j], out int num))
                        {
                            sum += num;
                        }
                        else throw new MyArrayDataException();
                    }
                    catch (MyArrayDataException)
                    {
                        Console.WriteLine($"В ячейке {i+1},{j+1} содержится не цифра");
                        
                    }
                }

            }
            return sum;
            }


        class ArraySizeException : Exception
        {
        }

        class MyArrayDataException : Exception
        {                
        }

        class Sotrudnik
        {
            public string FIO { get; set; }
            public string Position { get; set; }
            public string Email { get; set; }
            public string Telephone{ get; set; }
            public int Sallary { get; set; }
            public int Age{ get; set; }

            public void PrintEmpInfo()
            {
                Console.WriteLine($"ФИО:\t\t{FIO}\nДолжность\t{Position}\nПочта\t\t{Email}\nТелефон\t\t{Telephone}\nУровень Дохода\t{Sallary}\nВозраст\t\t{Age}\n");
            }


            public Sotrudnik(string fio, string pos, string email, string phone, int sall, int age)
            {
                FIO = fio;
                Position = pos;
                Email = email;
                Telephone = phone;
                Sallary = sall;
                Age = age;
            }

          



        }








    }
}

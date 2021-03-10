using System;
using System.IO;




namespace L6T1
{
    class Program
    {



        static void Main(string[] args)
        {
            ShowDirFiles();                     // Задание 1.   Без рекурсии
            ShowDirFilesRec(@"с:\tmp");         // Задание 1.   С рекурсией

            string[,] mass4x4 = { { "1", "2", "3", "4" }, { "1", "2", "3", "4" }, { "1", "х", "3", "4" }, { "1", "2", "3", "4" } };  // Задание 3. Заполненный массив 4х4

            Console.WriteLine(ArraySum(mass4x4));  // Задание 3. Вывод в консоль суммы чисел массива

            Sotrudnik[] dreamteam = new Sotrudnik[5];       //Задание 4. Создание массива сотруник.
            dreamteam[0] = new Sotrudnik("Пирожков Артур Батькович", "Директор мира", "director@mail.ru", "3322", 100500, 99);                      //Задание 4. Заполнение массива сотрудников
            dreamteam[1] = new Sotrudnik("Вершков Андрей Николаевич", "Айтишник в душе", "vershkov@mail.ru", "8100", 200000, 45);                   //Задание 4. Заполнение массива сотрудников
            dreamteam[2] = new Sotrudnik("Плющ Денис Геннадьевич", "Заместитель несуществующей должности", "plyush@mail.ru", "56712", 199000, 41);  //Задание 4. Заполнение массива сотрудников
            dreamteam[3] = new Sotrudnik("Судорога Кирилл Александрович", "Инженер", "kuznetsov@mail.ru", "55114", 45000, 27);                      //Задание 4. Заполнение массива сотрудников
            dreamteam[4] = new Sotrudnik("40 лет вайти", "Руководитель отдела руководителей", "ruk@mail.ru", "55555", 99999, 31);                  //Задание 4. Заполнение массива сотрудников

            for (int i = 0; i < dreamteam.Length; i++)      //Задание 4. Перебор массива сотрудников с вывозом функции, которая выводит полученную информацию на экран.
            {
                dreamteam[i].PrintEmpInfo();
            }





        }

        private static void ShowDirFiles()                                                                 // Задание 1.   Метод, что выводит папки и содержимое.
        {
            string searchdir = @"с:\tmp";                                                                  // Задание 1.   Задание пути для работы метода.
            if (!Directory.Exists(searchdir))                                                               // Задание 1.   Проверка существует ли папка по указанному пути.
            {
                Console.WriteLine("Директория не найдена");
                return;
            }
            string[] scan = Directory.GetFileSystemEntries(searchdir, "*", SearchOption.AllDirectories);    // Задание 1.   Создание массива из найденных папок и файлов.

            for (int i = 0; i < scan.Length; i++)                                                           // Задание 1.   Вывод в консоль все элементов полученного массива.
            {
                Console.WriteLine(scan[i]);
            }

        }

        static void ShowDirFilesRec(string path)                                                            // Задание 1.   Рекурсивный метод, что выводит папки и содержимое.
        {

            if (!Directory.Exists(path))                                                                    // Задание 1.   Проверка: существует ли указанный путь.
            {
                Console.WriteLine("Директория не найдена");
                return;
            }

            string[] scandir = Directory.GetFileSystemEntries(path, "*", SearchOption.TopDirectoryOnly);   // Задание 1.   Создание массива из найденных папок и файлов


            for (int i = 0; i < scandir.Length; i++)                                                        // Задание 1.   Вывод в консоль всех элементов полученного массива.
            {
                Console.WriteLine(scandir[i]);
            }

            string[] subdir = Directory.GetDirectories(path);                                               // Задание 1.   Создание массива из найденных директорий по указанному пути
            for (int i = 0; i < subdir.Length; i++)                                                         // Задание 1.   Вывод в консоль всех папок полученного массива и поиск в них папок и файлов рекурсивным способом
            {
                ShowDirFilesRec(subdir[i]);
            }

            ///////////////////////////////////////////////////////////////////////////////////////////////
        }

        static int ArraySum(string[,] mass)                                                 // Задание 3.   Функция, принимающая на вход массив 4х4
        {
            try                                                                             // Задание 3.   Проверка размерности массива согласно задаче.
            {
                if (mass.GetLength(0) != 4 || mass.GetLength(1) != 4)
                {
                    throw new ArraySizeException();                                         // Задание 3.   Если массив не 4х4 , сработает исключение и сообщение в консоль, что массив неверного размера.
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
            for (int i = 0; i < mass.GetLength(0); i++)                     // Задание 3.   Перебор массива 
            {
                for (int j = 0; j < mass.GetLength(1); j++)
                {
                    try
                    {
                        if (int.TryParse(mass[i, j], out int num))          // Задание 3   Преобразование найденных чисел в массиве в int.
                        {
                            sum += num;                                     // Задание 3.   Суммирование полученных данных.
                        }
                        else throw new MyArrayDataException();              // Задание 3.   Исключение, если TryParse не удалось преобразовать какие-то элементы массива
                    }
                    catch (MyArrayDataException)
                    {
                        Console.WriteLine($"В ячейке {i + 1},{j + 1} содержится не цифра"); // Задание 3. Вывод в консоль элементов массива не являющихся числом.

                    }
                }

            }
            return sum;                                                         // Задание 3.   Вывод полученной суммы массива.
        }


        class ArraySizeException : Exception                                    // Задание 3. Исключение по размеру массива
        {
        }

        class MyArrayDataException : Exception                                      // Задание 3. Исключение по данным в массиве
        {
        }

        class Sotrudnik                                                         // Задание 4. Создание класса сотрудник по задаче. С св-вами класса.
        {
            public string FIO { get; set; }
            public string Position { get; set; }
            public string Email { get; set; }
            public string Telephone { get; set; }
            public int Sallary { get; set; }
            public int Age { get; set; }

            public void PrintEmpInfo()                      // Задание 4. Функция вывода в консоль свойств класса сотрудник
            {
                Console.WriteLine($"ФИО:\t\t{FIO}\nДолжность\t{Position}\nПочта\t\t{Email}\nТелефон\t\t{Telephone}\nУровень Дохода\t{Sallary}\nВозраст\t\t{Age}\n");
            }


            public Sotrudnik(string fio, string pos, string email, string phone, int sall, int age)                 // Задание 4. Метод сотрудник принимающий на вход данные.
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

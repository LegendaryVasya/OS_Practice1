﻿using System;
using System.IO;

namespace OS_Practice1
{
    class Files
    {
        public static void Start()
        {
            //2.Работа с файлами
            string path = @"D:\MyTest.txt";
            if (!File.Exists(path))
            {
                Console.WriteLine("Введите строку для заполнения файла:");
                string user_s = Console.ReadLine();
                // Создание файл для записи.
                using (StreamWriter sw = File.CreateText(path))
                {
                    Console.WriteLine("Файл создан.");
                    sw.WriteLine(user_s);

                }
            }

            // Открытия файл для чтения.
            using (StreamReader sr = File.OpenText(path))
            {
                string s;
                while ((s = sr.ReadLine()) != null)
                {

                    Console.WriteLine("Чтение файла:");
                    Console.WriteLine(s);
                }

            }
            File.Delete(path);
            Console.WriteLine("Файл удален.");
        }
    }
}
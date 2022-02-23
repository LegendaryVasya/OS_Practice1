using System;
using System.IO;
using System.IO.Compression;


namespace OS_Practice1
{
    internal static class ZIP
    {
        internal static void Start()
        {


            Console.WriteLine("Быберите директорию(Пример: C или D):");
            string dir = Console.ReadLine();
            Console.WriteLine("Название папку:");
            string folder = Console.ReadLine();
            string folder_path = $"{dir}://{folder}"; // исходная папка
            
            Console.WriteLine("Название файл:");
            string file = Console.ReadLine();
            string file_path = $"{dir}://{folder}/{file}.txt";
           
            string zipFile = $"{dir}://{folder}.zip"; // сжатый файл
            string targetFolder = $"D://unpack_{folder}/"; // папка, куда распаковывается файл


            

            Console.WriteLine("\nВы хотите создать или использовать существующую папку с файлом?(1.Да/2.Нет):\n");
            while (true)
            {
                string choice = Console.ReadLine();

                switch (choice)
                {
                    case "1":
                        var myFold = Directory.CreateDirectory(folder_path);
                        var myFile = File.Create(file_path);
                        myFile.Close();
                        ZipFile.CreateFromDirectory(folder_path, zipFile);
                        Console.WriteLine($"Папка {folder_path} архивирована в файл {zipFile}");
                        ZipFile.ExtractToDirectory(zipFile, targetFolder);
                        Console.WriteLine($"Файл {zipFile} распакован в папку {targetFolder}");
                        break;
                    case "2":
                        ZipFile.CreateFromDirectory(folder_path, zipFile);
                        Console.WriteLine($"Папка {folder_path} архивирована в файл {zipFile}");
                        ZipFile.ExtractToDirectory(zipFile, targetFolder);
                        Console.WriteLine($"Файл {zipFile} распакован в папку {targetFolder}");
                        break;
                    default:
                        Console.WriteLine("Пожалуйста выберите (1) или (2)");

                        break;

                }
            }



           
            
        }
    }
}
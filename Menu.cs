using System;
namespace OS_Practice1
{
    class Menu
    {
        private static void PrintOptions()
        {
            Console.WriteLine("Выберете пункт:");
            Console.WriteLine("1.Информация о дисках");
            Console.WriteLine("2.Файлы");
            Console.WriteLine("3.JSON");
            Console.WriteLine("4.XML");
            Console.WriteLine("5.ZIP архив");
            Console.WriteLine("6.Выход");

        }
        static void Main(string[] args)
        {
            while (true)
            {
                PrintOptions();
                string choice = Console.ReadLine();
                
                
                Console.Clear();
                switch (choice)
                {
                    case "1":
                        Drives.Start();
                        break;
                    case "2":
                        Files.Start();
                        break;
                    case "3":
                        JSON.Start();
                        break;
                    case "4":
                        XML.Start();
                        break;
                    case "5":
                        ZIP.Start();
                        break;
                    case "6":
                        Environment.Exit(0);
                        break;
                    default:
                        Console.WriteLine("Неизвестное значение");
                        break;

                }
                Console.WriteLine("Нажмите любую клавишу для продолжения...");
                Console.ReadKey();
                Console.Clear();
            }
        }

    }
}

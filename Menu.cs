using System;
namespace OS_Practice1
{
    class Menu
    {
        private static void PrintOptions()
        {
            Console.WriteLine("Выберете пункт:");
            Console.WriteLine("1.Drives info");
            Console.WriteLine("2.Files");
            Console.WriteLine("3.JSON");
            Console.WriteLine("4.XML");
            Console.WriteLine("5.Zip archives");
            Console.WriteLine("6.Exit");

        }
        static void Main(string[] args)
        {
            while (true)
            {
                PrintOptions();
                int choice;
                //Проверка ввода(Работа с исключениями)
                try
                {
                   choice = Convert.ToInt32(Console.ReadLine());
                }
                catch (Exception e)
                {
                    choice = 0;
                }
                Console.Clear();

                switch (choice)
                {
                    case 1:
                        Drives.Start();
                        break;
                    case 2:
                        Files.Start();
                        break;
                    case 3:
                        JSON.Start();
                        break;
                    case 6:
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

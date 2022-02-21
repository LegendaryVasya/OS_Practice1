using System;
namespace OS_Practice1
{
    class Menu
    {
        private static void PrintOptions()
        {
            Console.WriteLine("Choose task (1-5) or quit(0): ");
            Console.WriteLine("1. Drives info");
            Console.WriteLine("2. Files");
            Console.WriteLine("3. JSON");
            Console.WriteLine("4. XML");
            Console.WriteLine("5. Zip archives");
            
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
                    choice = -1;
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
                    case 0:
                        Environment.Exit(0);
                        break;
                    default:
                        Console.WriteLine("Unknown or invalid option");
                        break;

                }
                Console.WriteLine("Press any key to continue...");
                Console.ReadKey();
                Console.Clear();
            }
        }

        
    }
}

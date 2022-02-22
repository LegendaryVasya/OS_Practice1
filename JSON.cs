using System;
using System.IO;
using System.Text.Json;
using System.Text.Json.Serialization;

namespace OS_Practice1
{
    class Person
    {
        [JsonPropertyName("Firstname")]
        public string Name { get; set; }

        public int Age { get; set; }
    }

    class JSON
    {
        public static void Start()
        {
            string path = @"D:\urfile.json";
            FileInfo file = new FileInfo(path);

            Console.WriteLine("Введите имя:");
            string name = Console.ReadLine();
            Console.WriteLine("Введите возраст:");
            int age = Convert.ToInt32(Console.ReadLine());
            Person person = new Person() { Name = name, Age = age };
            string json = JsonSerializer.Serialize(person);

            using (StreamWriter sw = new StreamWriter(path, false))
            {
                sw.WriteLine(json);
            }

            using (StreamReader sr = new StreamReader(path, false))
            {
                Console.WriteLine("\nТекст в файле:");
                Console.WriteLine(sr.ReadToEnd());
            }
            Console.WriteLine("\nВы хотите удалить файл(1.Да/2.Нет):\n");
            string choice = Console.ReadLine();
            switch (choice)
            {
                case "1":
                    file.Delete();
                    Console.WriteLine("Файл удален");
                    break;
                case "2":
                    Console.WriteLine("Файл сохранен");
                    break;
                default:
                    Console.WriteLine("Пожалуйста выберите (1) или (2)");
                    break;

            }
            
            
        }
    }
}
using System;

namespace Task2
{
    class Program
    {
        static void Main(string[] args)
        {
            string name;
            
            Console.Write("Введите имя: ");
            name = Console.ReadLine();
            if (name == "Вячеслав")
            {
                Console.WriteLine($"Привет, {name}");
            }
            else
            {
                Console.WriteLine("Нет такого имени");
            }
            Console.ReadKey();
        }
    }
}
using System;

namespace task1
{
    class task1
    {
        static void Main(string[] args)
        {
            Console.Write("Введите число: ");
            int num = Convert.ToInt32(Console.ReadLine());
            if (num > 7)
            {
                Console.WriteLine("Привет");
            }

            Console.ReadKey();

        }
    }
}

using System;

namespace Task3
{
    class Program
    {
        static void Main(string[] args)
        {
            string num = "";
            string arr = "";

            while (true)
            {
                Console.Write("Введите ведите целое число, для остановки нажмите клавишу Enter: ");
                num = Console.ReadLine();
                if (num != "")
                {

                    if (Convert.ToInt32(num) % 3 == 0) arr = arr + num + " ";
                }
                else
                {
                    Console.WriteLine("Элементы массива кратные 3:");
                    Console.WriteLine(arr);
                    Console.ReadKey();
                    break;
                }
            }


        }
    }
}

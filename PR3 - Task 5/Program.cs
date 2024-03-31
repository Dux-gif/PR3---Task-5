using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PR3___Task_5
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Игра \"Угадай-ка\"");
            Console.Write("Введите желаемый диапазон от 0 до: ");
            int range = int.Parse(Console.ReadLine());
            Random rand = new Random();

            int iiNumber = rand.Next(1, range);
            int count = 0;
            string userNumber;
            

            while (true)
            {
                Console.Write("\nВведите число: ");
                userNumber = Console.ReadLine();
                if (string.IsNullOrWhiteSpace(userNumber))
                {
                    Console.Write("Загаданное число: " + iiNumber);
                    Console.ReadKey();
                    break;
                }
                else
                {
                    count++;
                    int number = Convert.ToInt32(userNumber);
                    if (number < iiNumber)
                    {
                        Console.WriteLine("Введенное число меньше загаданного. Попробуйте ещё раз");
                    }
                    else if (number > iiNumber)
                    {
                        Console.WriteLine("Введенное число больше загаданного. Попробуйте ещё раз");
                    }

                    else
                    {
                        Console.WriteLine($"Поздравляю, число угадано! Число попыток: {count}.");
                        Console.ReadKey();
                        break;
                    }
                }
            }
        }
    }
}

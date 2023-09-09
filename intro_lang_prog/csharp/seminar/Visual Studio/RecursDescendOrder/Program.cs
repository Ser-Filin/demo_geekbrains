/*Задача 64: Задайте значение N. Напишите программу, которая выведет все
натуральные числа в промежутке от N до 1. Выполнить с помощью рекурсии.
N = 5 -> "5, 4, 3, 2, 1"
N = 8 -> "8, 7, 6, 5, 4, 3, 2, 1"*/


using System;

namespace RecursDescendOrder
{
    internal class Program
    {
        static void Main()
        {
            void DescendNumber(int num)
            {

                if (num > 0)
                {
                    Console.Write(num + " ");
                    DescendNumber(num - 1);
                }
            }

            ConsoleKeyInfo input;

            Console.WriteLine("Программа выводит ряд натуральных чисел от N до 1.\n");
            
            Repeat:
            
            Console.Write("Введите число N: ");
            int number = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine();
            DescendNumber(number);
            Console.WriteLine("\n");

        Repeat2:

            Console.Write("Желаете продолжить (y/n)? ");

            input = Console.ReadKey();
            Console.WriteLine("\n");

            if (input.Key == ConsoleKey.Y)
            {
                Console.Clear();
                goto Repeat;
            }
            if (input.Key != ConsoleKey.N)
                goto Repeat2;
        }
    }
}

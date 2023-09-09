/*Задача 66: Задайте значения M и N. Напишите программу, которая найдёт сумму
натуральных элементов в промежутке от M до N.
M = 1; N = 15-> 120
M = 4; N = 8. -> 30*/


using System;

namespace SumNaturalNoRecurs
{
    internal class Program
    {
        static void Main()
        {
            uint Invitation(string outText)
            {
                Console.Write(outText);
                uint inNumber = Convert.ToUInt32(Console.ReadLine());

                return inNumber;
            }

            void SumNatural(uint start, uint end)
            {
                uint sum = 0;

                if (start == end)
                {
                    Console.WriteLine($"Сумма всех элементов в промежутке от и до {start} равна {start}.\n");
                }
                else if (start < end)
                {
                    for (uint i = start; i <= end; i++)
                        sum += i;

                    Console.WriteLine($"Сумма всех элементов в промежутке от {start} до {end} включительно " +
                            $"равна {sum}.\n");
                }
                else
                {
                    for (uint i = end; i <= start; i++)
                        sum += i;

                    Console.WriteLine($"Сумма всех элементов в промежутке от {end} до {start} включительно " +
                            $"равна {sum}.\n");
                }
            }


            ConsoleKeyInfo input;

            Console.WriteLine("Программа выводит сумму натуральных чисел промежутка от M до N.");

        Repeat:

            uint inM = Invitation("Введите начальное число (M) последовательности: ");
            uint inN = Invitation("Введите конечное число (N) последовательности: ");
            Console.WriteLine();

            SumNatural(inM, inN);

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

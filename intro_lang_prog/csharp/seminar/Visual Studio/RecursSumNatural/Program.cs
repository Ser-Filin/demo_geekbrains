/*Задача 66: Задайте значения M и N. Напишите программу, которая найдёт сумму
натуральных элементов в промежутке от M до N.
M = 1; N = 15-> 120
M = 4; N = 8. -> 30*/


using System;

namespace RecursSumNatural
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

            uint[] StepsOfAdding(uint[] inArray)
            {
                if (inArray[1] < inArray[2])
                {
                    inArray[1]++;
                    inArray[0] += inArray[1];
                    StepsOfAdding(inArray);
                }
                return inArray;
            }

            // Подготовка входных данных для рекурсивного сложения:

            void SumNatural(uint start, uint end)
            {
                if (start == end)
                {
                    Console.WriteLine($"Сумма всех элементов в промежутке от и до {start} равна {start}.\n");
                }
                else if (start < end)
                {
                    uint[] array = { start, start, end };
                    uint[] outArray = StepsOfAdding(array);
                    Console.WriteLine($"Сумма всех элементов в промежутке от {start} до {end} включительно " +
                        $"равна {outArray[0]}.\n");
                }
                else
                {
                    uint[] array = { end, end, start };
                    uint[] outArray= StepsOfAdding(array);
                    Console.WriteLine($"Сумма всех элементов в промежутке от {end} до {start} включительно " +
                        $"равна {outArray[0]}.\n");
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

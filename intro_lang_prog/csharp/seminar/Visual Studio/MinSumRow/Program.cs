/*Задача 56: Задайте прямоугольный двумерный массив. Напишите программу, которая будет
находить строку с наименьшей суммой элементов.

Например, задан массив:
1 4 7 2
5 9 2 3
8 4 2 4
5 2 6 7
Программа считает сумму элементов в каждой строке и выдаёт номер строки с наименьшей суммой элементов: 1 строка*/

using System;

namespace MinSumRow
{
    internal class Program
    {
        static void Main()
        {
            int[,] СreatingArray()
            {
                Random rnd = new Random();

                int row = rnd.Next(5, 16); // генерируются количество строк и столбцов
                int column = rnd.Next(5, 16); // в промежутке от 5 до 15 строк/столбцов

                while (row == column) // исключение создания квадратной матрицы
                {
                    column = rnd.Next(5, 15);
                }

                int[,] quadArray = new int[row, column];

                for (int i = 0; i < row; i++) // генерируется массив с числами от -20 до 20
                {
                    for (int j = 0; j < column; j++)
                        quadArray[i, j] = rnd.Next(-20, 21);
                }

                return quadArray;
            }

            void ShowArray(int[,] inArray)
            {
                for (int i = 0; i < inArray.GetLength(0); i++)
                {
                    for (int j = 0; j < inArray.GetLength(1); j++)
                        Console.Write(inArray[i, j] + "; ");
                    Console.WriteLine();
                }
            }

            void RowNumber(int[,] inArray)
            {
                int row = 0, sum = 0;

                for (int i = 0; i < inArray.GetLength(0); i++)
                {
                    int nextSum = 0;

                    for (int j = 0; j < inArray.GetLength(1); j++)
                        nextSum += inArray[i, j];

                    if (sum > nextSum)
                    {
                        sum = nextSum;
                        row = i;
                    }
                }
                Console.WriteLine($"номер строки с наименьшей суммой элементов: {row + 1}.");
            }

            ConsoleKeyInfo input;

            Console.WriteLine("Программа создаёт прямоугольный массив и выводит номер строки с наименьшей " +
                                "суммой элементов.\n");
            
            Repeat:
            
            int[,] genArray = СreatingArray();

            Console.WriteLine("В созданном массиве:\n");
            ShowArray(genArray);
            Console.WriteLine();
            RowNumber(genArray);
            Console.WriteLine();

            Repeat2:
            
            Console.Write("Создать новый массив (y/n)? ");
            
            input = Console.ReadKey();
            Console.WriteLine();

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
/*Задача 54: Задайте двумерный массив. Напишите программу, которая упорядочит
по убыванию элементы каждой строки двумерного массива.
Например, задан массив:
1 4 7 2
5 9 2 3
8 4 2 4
В итоге получается вот такой массив:
7 4 2 1
9 5 3 2
8 4 4 2*/

using System;

namespace ArrangeRows
{
    internal class Program
    {
        static void Main()
        {
            // Создание произвольного массива:

            int[,] СreatingArray()
            {
                Random rnd = new Random();

                int row = rnd.Next(5, 16); // генерируются количество строк и столбцов
                int column = rnd.Next(5, 16); // в промежутке от 5 до 15 строк/столбцов

                int[,] outArray = new int[row, column];

                for (int i = 0; i < row; i++) // генерируется массив с числами от -20 до 20
                {
                    for (int j = 0; j < column; j++)
                        outArray[i, j] = rnd.Next(-20, 21);
                }

                return outArray;
            }

            // Вывод массива на экран

            void ShowArray(int[,] inArray)
            {
                for (int i = 0; i < inArray.GetLength(0); i++)
                {
                    for (int j = 0; j < inArray.GetLength(1); j++)
                        Console.Write(inArray[i, j] + "; ");
                    Console.WriteLine();
                }
            }

            // Сортировка элементов строк по убыванию

            int[,] ArrangeRows(int[,] inArray)
            {
                for (int row = 0; row < inArray.GetLength(0); row++)
                {
                    int col = 0;

                    for (; col < inArray.GetLength(1) - 1; col++)
                    {
                        int greater = col, check = greater + 1;

                        for (; check < inArray.GetLength(1); check++)
                        {
                            if (inArray[row, greater] < inArray[row, check])
                                greater = check;
                        }
                        if (col != greater)
                        {
                            int temp = inArray[row, col];
                            inArray[row, col] = inArray[row, greater];
                            inArray[row, greater] = temp;
                        }
                    }
                }

                return inArray;
            }

            ConsoleKeyInfo input;

            Console.WriteLine("Программа создаёт произвольный массив, а затем сортирует " +
                "элементы каждой строки по убыванию.\n");

        Repeat:

            int[,] genSortArray = СreatingArray();

            Console.WriteLine("Создан массив:\n");
            ShowArray(genSortArray);
            Console.WriteLine();

            genSortArray = ArrangeRows(genSortArray);

            Console.WriteLine("Отсортированный массив:\n");
            ShowArray(genSortArray);
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

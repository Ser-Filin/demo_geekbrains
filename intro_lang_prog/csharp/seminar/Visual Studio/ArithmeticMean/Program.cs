/*
Задача 52. Задайте двумерный массив из целых чисел.
Найдите среднее арифметическое элементов в каждом столбце.

Например, задан массив:
1 4 7 2
5 9 2 3
8 4 2 4
Среднее арифметическое каждого столбца: 4,6; 5,6; 3,6; 3.
*/

using System;

namespace ArithmeticMean
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // Для начала создадим случайный массив

            int[,] GeneratedArray()
            {
                Random rnd = new Random();

                int rows = rnd.Next(5, 21); // генерируем количество строк
                int columns = rnd.Next(5, 21); // генерируем количество столбцов

                int[,] array = new int[rows, columns]; // по полученным данным резервируем под массив память

                for (int r = 0; r < rows; r++) // заполняем массив случайными значениями
                {
                    for (int c = 0; c < columns; c++)
                        array[r, c] = rnd.Next(-20, 21);
                }

                return array;
            }

            void CalculateMean(int[,] array)
            {
                // Вычисленное среднее арифметическое по столбцам
                // соберём в массив, который и будем выводить

                float[] meanArray = new float[array.GetLength(1)]; // резервируем память под новый массив
                                                                   // количеством столбцов исходного массива
                
                for (int i = 0; i < array.GetLength(1); i++)
                {
                    for (int r = 0; r < array.GetLength(0); r++)
                        meanArray[i] += array[r, i];

                    meanArray[i] /= array.GetLength(0);
                }

                for (int i = 0; i < meanArray.Length; i++)
                    Console.Write(meanArray[i] + "; ");
            }

            void ShowArray(int[,] array)
            {
                for (int r = 0; r < array.GetLength(0); r++)
                {
                    for (int c = 0; c < array.GetLength(1); c++)
                        Console.Write(array[r, c] + "; ");

                    Console.WriteLine();
                }
            }

            Console.WriteLine("Программа создаёт случайный двумерный массив\nи выводит среднее арифметическое" +
                                " каждого столбца.\n");
            int[,] genArray = GeneratedArray();

            Console.WriteLine("В массиве:\n");
            ShowArray(genArray);
            Console.Write("\nсреднее арифметическое каждого столбца: ");
            CalculateMean(genArray);
            Console.WriteLine();
        }
    }
}

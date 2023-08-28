/*Задача 47. Задайте двумерный массив размером m×n,
 * заполненный случайными вещественными числами.

m = 3, n = 4.
0,5 7 -2 -0,2
1 -3,3 8 -9,9
8 7,8 -7,1 9
*/

using System;

namespace RandомRealNumbers
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // Количество строк и столбцов не могут принимать отрицательные
            // значения, поэтому ограничиваем ввод беззнаковыми данными.

            uint Invitation(string outText)
            {
                Console.Write(outText);
                uint inNumber = Convert.ToUInt32(Console.ReadLine());

                return inNumber;
            }

            void GeneratedArray(uint rows, uint columns)
            {
                float[,] array = new float[rows, columns];
                sbyte[] multipliers = { -1, 1 }; // массив множителей для смены знака
                Random rnd = new Random();

                for (int r = 0; r < rows; r++)
                {
                    for (int c = 0; c < columns; c++)
                    {
                        array[r, c] = Convert.ToSingle(rnd.NextDouble() * 100);
                        int indexMult = rnd.Next(0, 2); // выбираем случайный множитель
                        array[r, c] *= multipliers[indexMult]; // меняем, или оставляем знак
                    }
                }

                // Вывод массива на экран:

                for (int r = 0; r < rows; r++)
                {
                    for (int c = 0; c < columns; c++)
                        Console.Write(Math.Round(array[r, c], 2) + "; "); // ограничиваем длину числа 2-мя знаками
                                                                          // после запятой

                    Console.WriteLine();
                }
            }

            uint numbersOfRows = Invitation("Введите количество строк: ");
            uint numbersOfColumns = Invitation("Введите количество столбцов: ");

            Console.WriteLine();
            GeneratedArray(numbersOfRows, numbersOfColumns);
            Console.WriteLine();

        }
    }
}

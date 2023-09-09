/*Задача 62. Напишите программу, которая заполнит спирально массив 4 на 4.
Например, на выходе получается вот такой массив:
01 02 03 04
12 13 14 05
11 16 15 06
10 09 08 07*/

using System;

namespace SpiralArray
{
    internal class Program
    {
        static void Main()
        {
            string Invitation(string outText)
            {
                Console.Write(outText);
                string inLine = Console.ReadLine();

                return inLine;
            }

            // Модуль извлечения чисел. Не совсем оптимальный, но рабочий:

            int[] NumbersExtract(string inLine)
            {
                char[] charArray = inLine.ToCharArray(0, inLine.Length);
                int[] tempArray = new int[charArray.Length];
                int ind = 0, quantiti = 0, number = -1;

                for (int i = 0; i < charArray.Length; i++)
                {
                    int digit = Convert.ToInt32(charArray[i]) - 48;
                    if (digit >= 0 && digit <= 9)
                    {
                        if (number >= 0)
                        {
                            number = number * 10 + digit;
                        }

                        else
                        {
                            number = 0;
                            number = number * 10 + digit;
                        }
                    }
                    else if (number >= 0)
                    {
                        tempArray[ind] = number;
                        ind++;
                        quantiti++;
                        number = -1;
                    }
                }

                if (number >= 0)
                {
                    tempArray[ind] = number;
                    quantiti++;
                }

                int[] outArray = new int[quantiti];

                for (ind = 0; ind < outArray.Length; ind++)
                    outArray[ind] = tempArray[ind];

                return outArray;
            }

            bool Check(int[] numArray)
            {
                if (numArray.Length < 2)
                {
                    Console.WriteLine("Вероятно Вы забыли ввести какие-то параметры.\n");
                    return false;
                }

                if (numArray.Length > 2)
                {
                    Console.WriteLine("Вы ввели лишние параметры.\n");
                    return false;
                }

                if (numArray[0] < 2 || numArray[1] < 2)
                {
                    Console.WriteLine($"Невозможно создать двумерный массив с параметрами ({numArray[0]}, " +
                        $"{numArray[1]}).\n");
                    return false;
                }

                if (numArray[0] * numArray[1] > 99)
                {
                    Console.WriteLine("Превышен лимит двузначных чисел.\n");
                    return false;
                }

                return true;
            }


            int[,] CreatingSpiralArray(int[] dataArray)
            {
                // spiralMatrix - конечная матрица
                // row - текущая строка
                // column - текущий столбец
                // stepsRow - количество заполняемых строк
                // stepsColumns - количество заполняемых столбцов
                // direction – направление заполнения
                // number – текущее число

                int[,] spiralMatrix = new int[dataArray[0], dataArray[1]];
                int row = 0, column = 0, stepsRow = dataArray[0], stepsColumn = dataArray[1],
                    direction = 1, number = 1;

                do
                {
                    for (int step = stepsColumn; step > 0; step--)
                    {
                        spiralMatrix[row, column] = number;
                        number++;
                        column += direction;
                    }

                    column -= direction;
                    stepsRow--;
                    row += direction;

                    for (int step = stepsRow; step > 0; step--)
                    {
                        spiralMatrix[row, column] = number;
                        number++;
                        row += direction;
                    }

                    row -= direction;
                    direction *= -1; // смена направления
                    stepsColumn--;
                    column += direction;
                }
                while (stepsRow > 0 && stepsColumn > 0);

                return spiralMatrix;
            }

            void ShowArray(int[,] inMatrix)
            {
                for (int r = 0; r < inMatrix.GetLength(0); r++)
                {
                    for (int c = 0; c < inMatrix.GetLength(1); c++)
                    {
                        if (inMatrix[r, c] > 9)
                            Console.Write(inMatrix[r, c] + " ");
                        else
                            Console.Write($"0{inMatrix[r, c]} ");
                    }

                    Console.WriteLine();
                }
            }

            ConsoleKeyInfo input;

            Console.WriteLine("Программа создаёт двумерный массив из одно- двузначных чисел, заполняя " +
                "его спирально по часовой стрелке.\nНапример:\n");

            int[] metric = { 4, 4 };
            int[,] matrix = CreatingSpiralArray(metric);

            ShowArray(matrix);
            Console.WriteLine();

        Repeat:

            string inData = Invitation("Введите размеры массива (строки, столбцы; разделителем может быть любой " +
                                        "нецифровой символ): ");
            Console.WriteLine();

            metric = NumbersExtract(inData);
            if (!Check(metric))
                goto Repeat;

            matrix = CreatingSpiralArray(metric);

            ShowArray(matrix);
            Console.WriteLine();

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

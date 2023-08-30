/*Задача 58: Задайте две матрицы. Напишите программу,
которая будет находить произведение двух матриц.
Например, даны 2 матрицы:
2 4 | 3 4
3 2 | 3 3
Результирующая матрица будет:
18 20
15 18*/

using System;

int[,] СreatingМatrices(int rows)
{
    Random rnd = new Random();

    int row,
        column;

    if (rows == 0)
        row = rnd.Next(5, 16);
    else
        row = rows;

    column = rnd.Next(5, 16);

    int[,] array = new int[row, column];

    for (int r = 0; r < row; r++)
    {
        for (int c = 0; c < column; c++)
            array[r, c] = rnd.Next(-20, 21);
    }

    return array;
}

int[,] MatrixMultiplication(int[,] arrayA, int[,] arrayB)
{
    int[,] arrayC = new int[arrayA.GetLength(0), arrayB.GetLength(1)];

    for (int r = 0; r < arrayA.GetLength(0); r++)
    {
        for (int c = 0; c < arrayB.GetLength(1); c++)
            for (int colA = 0; colA < arrayA.GetLength(1); colA++)
            {
                int temp = arrayA[r, colA] * arrayB[colA, c];
                arrayC[r, c] += temp;
            }
    }

    return arrayC;
}

void ShowMatrix(int[,] matrix)
{
    for (int r = 0; r < matrix.GetLength(0); r++)
    {
        for (int c = 0; c < matrix.GetLength(1); c++)
            Console.Write(matrix[r, c] + "; ");

        Console.WriteLine();
    }
}

ConsoleKeyInfo input;

Console.WriteLine("Программа создаёт две матрицы и выводит их произведение.\n");

Repeat:

int[,] firstMatrix = СreatingМatrices(0);
int[,] secondMatrix = СreatingМatrices(firstMatrix.GetLength(1));

Console.WriteLine("Первая матрица:\n");
ShowMatrix(firstMatrix);
Console.WriteLine();

Console.WriteLine("Вторая матрица:\n");
ShowMatrix(secondMatrix);
Console.WriteLine();

int[,] matrixProduct = MatrixMultiplication(firstMatrix, secondMatrix);

Console.WriteLine("Произведение первой и второй матрицы:\n");
ShowMatrix(matrixProduct);
Console.WriteLine();

Repeat2:

Console.Write("Создать новые матрицы (y/n)? ");

input = Console.ReadKey();
Console.WriteLine("\n");

if (input.Key == ConsoleKey.Y)
{
    Console.Clear();
    goto Repeat;
}
if (input.Key != ConsoleKey.N)
    goto Repeat2;

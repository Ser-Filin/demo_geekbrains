// Задайте двумерный массив размером m×n, заполненный случайными целыми числами.

// int [,] CreateRandom2dArray(int rows, int columns, int MinValue, MaxValue)
// {
//     int[,] array = new int[rows, columns];

//     for(int i = 0; i < rows; i++)

//         for(int j = 0; j < columns; j++)
//             array[i,j] = new Random().Next (MinValue, MaxValue + 1);

//         return array;
// }

// void SHow2dArray(int [,] array)
// {
//     for (int i = 0; i < array.GetLength(0); i++)
//     {
//         for (int j = 0; < array.GetLength(1); j++)
//         Console.WriteLine(array[i,j] + " ");

//         Console.WriteLine();
//     }
// }
// Console.WriteLine("Введите количество строк: ");
// int rows = Convert.ToInt32(Console.ReadLine());
// Console.WriteLine("");
// int columns = Convert.ToInt32(Console.ReadLine());
// Console.WriteLine("");
// int min = Convert.ToInt32Console.(ReadLine());
// Console.WriteLine("");
// int max = Convert.ToInt32(Console.ReadLine());



/*
// 1. Задайте двумерный массив размера m на n, каждый
// элемент в массиве находится по формуле: Aij = i+j.
// Выведите полученный массив на экран.

int Invitation(string outText)
{
    Console.Write(outText);
    int inNumber = Convert.ToInt32(Console.ReadLine());

    return inNumber;
}

void ComputeArray(int rows, int columns)
{
    int[,] array = new int[rows, columns];

    for (int j = 0; j < rows; j++)
    {
        for (int i = 0; i < columns; i++)
            array[j, i] = j + i;
    }

    for (int j = 0; j < array.GetLength(0); j++)
    {
        for (int i = 0; i < array.GetLength(1); i++)
            Console.Write(array[j,i] + " ");

        Console.WriteLine();
    }
}

int inM = Invitation("Введите количество строк: ");
int inN = Invitation("Введите количество столбцов: ");
ComputeArray(inM, inN);
*/


// 2. Задайте двумерный массив. Найдите элементы, у которых
// оба индекса чётные, и замените эти элементы на их квадраты.

int Invitation(string outText)
{
    Console.Write(outText);
    int inNumber = Convert.ToInt32(Console.ReadLine());

    return inNumber;
}

int[,] GenArray(int rows, int columns, int minValue, int maxValue)
{
    int[,] array = new int[rows, columns];

    for (int i = 0; i < rows; i++)
    {
        for (int j = 0; j < columns; j++)
            array[i, j] = new Random().Next(minValue, maxValue + 1);
    }

    return array;
}

int[,] SecondArray(int[,] array)
{

}

int inM = Invitation("Введите количество строк: ");
int inN = Invitation("Введите количество столбцов: ");
int min = Invitation("Введите минимальное значение: ");
int max = Invitation("Введите максимальное значение: ");

// 3. Задайте двумерный массив. Найдите сумму элементов, находящихся на главной диагонали
// (вне зависимости от размеров матрицы) и т.д.

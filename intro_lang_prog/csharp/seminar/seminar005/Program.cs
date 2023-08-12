/*
// Задайте массив из m элементов, заполненный случайными числами
// из промежутка [a, b]. Найдите сумму отрицательных элементов массива.

int[] CreateRandomArray(int size, int minValue, int maxValue)
{
    int[] array = new int[size];

    for (int i = 0; i < size; i++)
        array[i] = new Random().Next(minValue, maxValue + 1);

    return array;
}

void WriteArray(int[] array)
{
    for (int i = 0; i < array.Length; i++)
        Console.Write(array[i] + " ");

    Console.WriteLine();
}

int SumOfNegatives(int[] array)
{
    int sum = 0;

    for (int i = 0; i < array.Length; i++)
        if (array[i] < 0)
            sum += array[i];

    return sum;
}

Console.Write("Input a length of array: ");
int m = Convert.ToInt32(Console.ReadLine());
Console.Write("Input a min possible value: ");
int a = Convert.ToInt32(Console.ReadLine());
Console.Write("Input a max possible value: ");
int b = Convert.ToInt32(Console.ReadLine());

int[] myArray = CreateRandomArray(m, a, b);
WriteArray(myArray);
Console.WriteLine(SumOfNegatives(myArray));
*/


/*
// Напишите программу замена элементов массива: положительные
// элементы замените на соответствующие отрицательные, и наоборот.

int WriteWait(string outLine)
{
    Console.Write(outLine);
    int inNumber = Convert.ToInt32(Console.ReadLine());
    return inNumber;
}

int[] RandArr(int elem, int minVal, int maxVal)
{
    int[] randArray = new int[elem];

    for (int i = 0; i < elem; i++)
        randArray[i] = new Random().Next(minVal, maxVal + 1);

    return randArray;
}

int[] Mirror(int elem, int[] arr)
{
    int[] tempArray=new int[elem];

    for (int i = 0; i < elem; i++)
        tempArray[i] = arr[i] * (-1);

    return tempArray;
}

void OutArr(int elem, int[] whatArr)
{
    for (int i = 0; i < elem; i++)
        Console.Write($"{whatArr[i]} ");
}

int howMany = WriteWait("Введите количество элементов массива: ");
int min = WriteWait("Введите минимальное значение элемента: ");
int max = WriteWait("Введите максимальное значение элемента: ");
Console.WriteLine();

int[] array = RandArr(howMany, min, max);
int[] mirrorArray = Mirror(howMany, array);
Console.Write("Сгенерированный массив: ");
OutArr(howMany, array);
Console.WriteLine();
Console.Write("Обработанный массив: ");
OutArr(howMany, mirrorArray);
Console.WriteLine();
*/

/*
// Задайте массив. Напишите программу, которая определяет,
// присутствует ли заданное число в массиве.

int WriteWait(string outLine)
{
    Console.Write(outLine);
    int inNumber = Convert.ToInt32(Console.ReadLine());
    return inNumber;
}

int[] RandArr(int elem, int minVal, int maxVal)
{
    int[] randArray = new int[elem];

    for (int i = 0; i < elem; i++)
        randArray[i] = new Random().Next(minVal, maxVal + 1);

    return randArray;
}

bool FindNum(int elem, int[] array, int f)
{
    for (int i = 0; i < elem; i++)
        if (array[i] == f) return true;

    return false;
}

void OutArr(int elem, int[] whatArr)
{
    for (int i = 0; i < elem; i++)
        Console.Write($"{whatArr[i]} ");
}

int howMany = WriteWait("Введите количество элементов массива: ");
int min = WriteWait("Введите минимальное значение элемента: ");
int max = WriteWait("Введите максимальное значение элемента: ");
int find = WriteWait("Введите искомое число: ");

int[] genArray = RandArr(howMany, min, max);
Console.Write("Сгенерированный массив: ");
Console.WriteLine();
OutArr(howMany, genArray);
Console.WriteLine();

if(FindNum(howMany, genArray, find)) Console.WriteLine($"Искомое число {find} присутствует в массиве.");
else Console.WriteLine($"Искомое число {find} не обнаружено.");
*/

/*
// Задайте одномерный массив из m случайных чисел. Найдите количество
// элементов массива, значения которых лежат в отрезке [a,b].

int WriteWait(string outLine)
{
    Console.Write(outLine);
    int inNumber = Convert.ToInt32(Console.ReadLine());
    return inNumber;
}

int[] RandArr(int elem, int minVal, int maxVal)
{
    int[] randArray = new int[elem];

    for (int i = 0; i < elem; i++)
        randArray[i] = new Random().Next(minVal, maxVal + 1);

    return randArray;
}

void OutArr(int elem, int[] whatArr)
{
    for (int i = 0; i < elem; i++)
        Console.Write($"{whatArr[i]} ");
}

int NumOfNum(int elem, int[] arr, int start, int end)
{
    int nof = 0;
    for (int i = 0; i < elem; i++)
        if (arr[i] >= start && arr[i] <= end) nof++;

    return nof;
}

Repeat:
int howMany = WriteWait("Введите количество элементов массива: ");
if (howMany <= 0)
{
    Console.WriteLine("Количество элементов массива не может быть меньше 1!");
    goto Repeat;
}
int min = WriteWait("Введите минимальное значение элемента массива: ");
int max = WriteWait("Введите максимальное значение элемента массива: ");
int startSeg = WriteWait("Задайте начало отрезка: ");
int endSeg = WriteWait("Задайте конец отрезка: ");

int[] array = RandArr(howMany, min, max);
Console.Write("В массиве: ");
OutArr(howMany, array);
Console.WriteLine();
Console.WriteLine($"на заданном отрезке обнаружено элементов: {NumOfNum(howMany, array, startSeg, endSeg)}.");
*/
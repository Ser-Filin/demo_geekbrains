/*
// Напишите программу, которая перевернёт одномерный массив
// (последний элемент будет на первом месте, а первый - на
// последнем и т.д.)

int[] CreateRandomArray(int size, int minValue, int maxValue)
{
    int[] array = new int[size];

    for (int i = 0; i < size; i++)
        array[i] = new Random().Next(minValue, maxValue + 1);

    return array;
}

void ShowArray(int[] array)
{
    for (int i = 0; i < array.Length; i++)
        Console.Write(array[i] + " ");

    Console.WriteLine();
}

void ReverseArray(int[] array)
{
    for (int i = 0; i < array.Length / 2; i++)
    {
        int temp = array[i];
        array[i] = array[array.Length - 1 - i];
        array[array.Length - 1 - i] = temp;
    }
}

void ReverseArray2(int[] array)
{
    for (int i = 0, j = array.Length - 1; i < j; i++, j--)
    {
        int temp = array[i];
        array[i] = array[j];
        array[j] = temp;
    }
}

Console.Write("Input a length of array: ");
int length = Convert.ToInt32(Console.ReadLine());
Console.Write("Input a min possible value: ");
int min = Convert.ToInt32(Console.ReadLine());
Console.Write("Input a max possible value: ");
int max = Convert.ToInt32(Console.ReadLine());

int[] myArray = CreateRandomArray(length, min, max);
ShowArray(myArray);
ReverseArray(myArray);
ShowArray(myArray);
ReverseArray2(myArray);
ShowArray(myArray);
*/


/*
// Напишите программу, которая принимает на вход три числа и проверяет,
// может ли существовать треугольник со сторонами такой длины.

float WriteWait(string outLine)
{
    Console.Write(outLine);
    float inNumber = Convert.ToSingle(Console.ReadLine());
    return inNumber;
}

void ChekTriangle(float a, float b, float c)
{
    if (a + b > c && a + c > b && b + c > a)
        Console.WriteLine("Такой треугольник существует.");
    else
        Console.WriteLine("Такой треугольник невозможен.");
}

float firstSegment = WriteWait("Введите длину первого отрезка: ");
float secondSegment = WriteWait("Введите длину второго отрезка: ");
float thirdSegment = WriteWait("Введите длину третьего отрезка: ");

ChekTriangle(firstSegment, secondSegment, thirdSegment);
*/

/*
// Не используя рекурсию, выведите первые N чисел Фибоначчи.
// Первые два числа Фибоначчи: 0 и 1.

int WriteWait(string outLine)
{
    Console.Write(outLine);
    int inNumber = Convert.ToInt32(Console.ReadLine());
    return inNumber;
}

int[] Fibonacci(int n)
{
    int[] array = new int[n];
    array[0] = 0;
    array[1] = 1;
    for (int i = 2; i < n; i++)
        array[i] = array[i - 2] + array[i - 1];

    return array;
}

void OutFibonacci(int[] inArray)
{
    for (int i = 0; i < inArray.Length - 1; i++)
        Console.Write(inArray[i] + ", ");

    Console.WriteLine(inArray[inArray.Length - 1]);
}

Console.WriteLine("Программа выводит первые N чисел Фибоначчи.\n");
int howMany = WriteWait("Сколько чисел Фибоначчи вывести? ");
Console.WriteLine();

int[] numbersFibonacci = Fibonacci(howMany);
OutFibonacci(numbersFibonacci);
*/

/*
// Напишите программу, которая будет создавать копию заданного
// массива с помощью поэлементного копирования.

int WriteWait(string outLine)
{
    Console.Write(outLine);
    int inNumber = Convert.ToInt32(Console.ReadLine());
    return inNumber;
}

int[] GenArray(int size, int min, int max)
{
    int[] randArr = new int[size];

    for (int i = 0; i < size; i++)
        randArr[i] = new Random().Next(min, max + 1);

    return randArr;
}

void OutArr(int elem, int[] arr)
{
    Console.Write("[");
    for (int i = 0; i < elem - 1; i++)
        Console.Write($"{arr[i]}; ");
    Console.WriteLine(arr[elem - 1] + "]");
}

int[] CopyArray(int size, int[] startArray)
{
    int[] secondArr = new int[size];
    for (int i = 0; i < size; i++)
        secondArr[i] = startArray[i];

    return secondArr;
}

Repeat:
int numOfElem = WriteWait("Введите количество элементов массива: ");
if (numOfElem < 0)
{
    Console.WriteLine("Количество элементов не может быть меньше 1!");
    goto Repeat;
}
int minVal = WriteWait("Введите минимальное значение элемнта массива: ");
int maxVal = WriteWait("Введите максимальное значение элемента массива: ");

int[] array = GenArray(numOfElem, minVal, maxVal);
Console.WriteLine();
Console.WriteLine("Сгенерированный массив:");
OutArr(numOfElem, array);

array = CopyArray(numOfElem, array);
Console.WriteLine();
Console.WriteLine("Скопированный массив:");
OutArr(numOfElem, array);
*/

// Написать программу, преобразующую число из
// десятеричной системы счисления в двоичную.

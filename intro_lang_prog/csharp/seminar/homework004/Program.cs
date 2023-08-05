/*
// Задача 25: Напишите цикл, который принимает на вход два числа (A и B) и возводит число A в натуральную степень B.
// 3, 5 -> 243 (3⁵)
// 2, 4 -> 16


int WriteWait(string outLine)
{
    Console.Write(outLine);
    int inNumber = Convert.ToInt32(Console.ReadLine());
    return inNumber;
}

// Решение методом цикла:

int Powering(int inBase, int inPow)
{
    int powOfNum = inBase;

    for (int tempPow = inPow - 1; tempPow > 0; tempPow--)
        powOfNum *= inBase;

    return powOfNum;
}

int basePow = WriteWait("Введите основание степени: ");

Repeat:
int power = WriteWait("Введите целочисленный положительный показатель степени: ");

if (power <= 0)
{
    Console.WriteLine("Вы ввели неправильный показатель степени.");
    goto Repeat;
}

Console.WriteLine();
Console.WriteLine("Решение методом цикла:");
Console.WriteLine($"Число {basePow} в степени {power} равно {Powering(basePow, power)}.");
Console.WriteLine();

// Решение через Math.Pow():

Console.WriteLine("Решение через Math.Pow():");
Console.WriteLine($"Число {basePow} в степени {power} равно {Math.Pow(basePow, power)}.");
*/

/*
// Задача 27: Напишите программу, которая принимает на вход число и выдаёт сумму цифр в числе.
// 452 -> 11
// 82 -> 10
// 9012 -> 12

int WriteWait(string outLine)
{
    Console.Write(outLine);
    int inNumber = Convert.ToInt32(Console.ReadLine());
    return inNumber;
}

int Sum(int inNumber)
{
    int outSum = 0;

    for (int tempNumber = inNumber; tempNumber > 0; tempNumber /= 10)
        outSum += tempNumber % 10;

    return outSum;
}

int number=WriteWait("Пожалуйста, введите число: ");
Console.WriteLine($"Сумма всех цифр в числе {number} равна {Sum(number)}");
*/

/*
// Задача 29: Напишите программу, которая задаёт массив из m элементов и выводит их на экран.
// 1, 2, 5, 7, 19 -> [1, 2, 5, 7, 19]
// 6, 1, 33 -> [6, 1, 33]
*/

/*
// Данную задачу можно решить двумя способами:
// 1. Массив заполняется случайными числами.
// 2. Массив заполняется пользователем.


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

int[] UserArr(int elem)
{
    int[] userArray = new int[elem];

    for (int i = 0; i < elem; i++)
        userArray[i] = WriteWait($"Введите {i + 1}-й элемент массива: ");

    return userArray;
}

void OutArr(int elem, int[] whatArr)
{
    for (int i = 0; i < elem; i++)
        Console.Write($"{whatArr[i]} ");
}

int numOfElem = WriteWait("Задайте количество элементов массива: ");
int startVal = WriteWait("Задайте минимальное значение элемента для генератора: ");
int endVal = WriteWait("Задайте максимальное значение элемента для генератора: ");
int[] genArray = RandArr(numOfElem, startVal, endVal);
int[] inArray = UserArr(numOfElem);

Console.WriteLine();
Console.Write("Массив, сгенерированный программой: ");
OutArr(numOfElem, genArray);
Console.WriteLine();
Console.WriteLine();
Console.Write("Массив, введённый пользователем: ");
OutArr(numOfElem, inArray);
Console.WriteLine();
*/
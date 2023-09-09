/*Задача 64: Задайте значение N. Напишите программу, которая выведет все
натуральные числа в промежутке от N до 1. Выполнить с помощью рекурсии.
N = 5 -> "5, 4, 3, 2, 1"
N = 8 -> "8, 7, 6, 5, 4, 3, 2, 1"*/


using System;

/*
void DescendNumber(int num)
{
    if (num > 0)
    {
        Console.Write(num + " ");
        DescendNumber(num - 1);
    }
}

ConsoleKeyInfo input;

Console.WriteLine("Программа выводит ряд натуральных чисел от N до 1.\n");

Repeat:

Console.Write("Введите число N: ");
int number = Convert.ToInt32(Console.ReadLine());
Console.WriteLine();
DescendNumber(number);
Console.WriteLine("\n");

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
*/


/*Задача 66: Задайте значения M и N. Напишите программу, которая найдёт сумму
натуральных элементов в промежутке от M до N.
M = 1; N = 15-> 120
M = 4; N = 8. -> 30*/

// В задании не указано, каким способом решать данную задачу. Поэтому
// привожу 2 варианта её решения.

// 1-й вариант: без рекурсии:

/*
uint Invitation(string outText)
{
    Console.Write(outText);
    uint inNumber = Convert.ToUInt32(Console.ReadLine());

    return inNumber;
}

void SumNatural(uint start, uint end)
{
    uint sum = 0;

    if (start == end)
    {
        Console.WriteLine($"Сумма всех элементов в промежутке от и до {start} равна {start}.\n");
    }
    else if (start < end)
    {
        for (uint i = start; i <= end; i++)
            sum += i;

        Console.WriteLine(
            $"Сумма всех элементов в промежутке от {start} до {end} включительно "
                + $"равна {sum}.\n"
        );
    }
    else
    {
        for (uint i = end; i <= start; i++)
            sum += i;

        Console.WriteLine(
            $"Сумма всех элементов в промежутке от {end} до {start} включительно "
                + $"равна {sum}.\n"
        );
    }
}

ConsoleKeyInfo input;

Console.WriteLine("Программа выводит сумму натуральных чисел промежутка от M до N.");

Repeat:

uint inM = Invitation("Введите начальное число (M) последовательности: ");
uint inN = Invitation("Введите конечное число (N) последовательности: ");
Console.WriteLine();

SumNatural(inM, inN);

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
*/

// 2-ой вариант решения задачи № 66, с использованием рекурсии

/*
uint Invitation(string outText)
{
    Console.Write(outText);
    uint inNumber = Convert.ToUInt32(Console.ReadLine());

    return inNumber;
}

uint[] StepsOfAdding(uint[] inArray)
{
    if (inArray[1] < inArray[2])
    {
        inArray[1]++;
        inArray[0] += inArray[1];
        StepsOfAdding(inArray);
    }
    return inArray;
}

// Подготовка входных данных для рекурсивного сложения:

void SumNatural(uint start, uint end)
{
    if (start == end)
    {
        Console.WriteLine($"Сумма всех элементов в промежутке от и до {start} равна {start}.\n");
    }
    else if (start < end)
    {
        uint[] array = { start, start, end };
        uint[] outArray = StepsOfAdding(array);
        Console.WriteLine(
            $"Сумма всех элементов в промежутке от {start} до {end} включительно "
                + $"равна {outArray[0]}.\n"
        );
    }
    else
    {
        uint[] array = { end, end, start };
        uint[] outArray = StepsOfAdding(array);
        Console.WriteLine(
            $"Сумма всех элементов в промежутке от {end} до {start} включительно "
                + $"равна {outArray[0]}.\n"
        );
    }
}

ConsoleKeyInfo input;

Console.WriteLine("Программа выводит сумму натуральных чисел промежутка от M до N.");

Repeat:

uint inM = Invitation("Введите начальное число (M) последовательности: ");
uint inN = Invitation("Введите конечное число (N) последовательности: ");
Console.WriteLine();

SumNatural(inM, inN);

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
*/


/*Задача 68: Напишите программу вычисления функции Аккермана с помощью рекурсии.
Даны два неотрицательных числа m и n.
m = 2, n = 3->A(m, n) = 9
m = 3, n = 2->A(m, n) = 29*/

/*
uint Invitation(string outText)
{
    Console.Write(outText);
    uint inNumber = Convert.ToUInt32(Console.ReadLine());

    return inNumber;
}

uint Funct(uint inM, uint inN)
{
    if (inM == 0)
        return inN + 1;

    if (inN == 0)
        return Funct(inM - 1, 1);

    return Funct(inM - 1, Funct(inM, inN - 1));
}

Console.WriteLine("Программа вычисляет значение функции Аккермана.");
uint parM = Invitation("Введите параметр M функции: ");
uint parN = Invitation("Введите параметр N функции: ");
Console.WriteLine();

Console.WriteLine("Результат функции " + Funct(parM, parN));
*/

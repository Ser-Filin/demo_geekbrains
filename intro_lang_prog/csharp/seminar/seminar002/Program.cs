// Семинар 2.

// Теория.

/*
    13254 / 10 = 1325
    13254 / 100 = 132
    13254 / 1000 = 13
    13254 / 10000 = 1

    13254 % 10 = 4
    13254 % 100 = 54
    13254 % 1000 = 254
    13254 % 10000 = 3254
*/

// То, что у меня называется подпрограммой или процедурой,
// в до диез (C#) называется методом.

/*
// Задача 1. Написать программу, которая выводит случайное трёхзначное число
// и удаляет вторую цифру этого числа.


int CutNumber(int num)
{
    int hundreds = num / 100;
    int units = num % 10;

    int res = hundreds * 10 + units;
    return res;
}

int randNumber = new Random().Next(100, 1000);

int newNumber = CutNumber(randNumber);
Console.WriteLine($"Новой версией числа {randNumber} является число {newNumber}");
*/

/*
// Задача 2. Написать программу, которая получает на вход число и проверяет
// кратно ли оно одновременно a и b.


bool IsDivisible(int num, int div1, div2)
{
    // if (num % div1 == 0 && num % div2 == 0)
    //     return true;
    // else
    //     return false;

    return num % div1 == 0 && num % div2 == 0
}

Console.Write("Введите число для проверки: ");
int number = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите первый делитель: ");
int divider1 = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите второй делитель: ");
int divider2 = Convert.ToInt32(Console.ReadLine());

bool res = IsDivisible(number, divider1, divider2);
if (res) Console.WriteLine("Yes");
else Console.WriteLine("No");
*/

/*
// Написать программу, которая выводит случайное число из отрезка
// от 10 до 99 и показывает наибольшую цифру из этого числа

int MaxNum(int num)
{
    int tens = num / 10;
    int unit = num % 10;
    if (tens < unit) return unit;
    else return tens;
}

int randNumber = new Random().Next(10, 100);

Console.WriteLine($"В числе {randNumber} наибольшая цифра: {MaxNum(randNumber)}");
*/

/*
// Напишите программу, которая принимает на вход два числа и проверяет,
// является ли одно число квадратом другого.
*/

// int WriteWait(string outLine)
// {
//     Console.Write(outLine);
//     int inNumber = Convert.ToInt32(Console.ReadLine());
//     return inNumber;
// }

// bool Square(int num1, int num2)
// {
//     if (num1 == num2 * num2)
//     {
//         Console.WriteLine($"Число {num1} является квадратом числа {num2}.");
//         return true;
//     }

//     if (num2 == num1 * num1)
//     {
//         Console.WriteLine($"Число {num2} является квадратом числа {num1}.");
//         return true;
//     }

//     return false;
// }

// int number1 = WriteWait("Введите первое число: ");
// int number2 = WriteWait("Введите второе число: ");

// if (!(Square(number1, number2))) Console.WriteLine("Числа не являются квадратами друг друга.");
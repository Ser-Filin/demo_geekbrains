﻿/* Задача 2.
Написать программу, которая на входе принимает два числа
и выдаёт на выходе, какое число больше, а какое меньше


// Сначала выводим сообщения, предлагающие пользователю ввести по очереди
// два числа, и сохраняем введённые числа в переменных num1 и num2 соответственно,
// предварительно преобразовав символы в 32-х битовые числа.

Console.Write("Пожалуйста, введите первое число: ");
int num1 = Convert.ToInt32(Console.ReadLine());
Console.Write("Пожалуйста, введите второе число: ");
int num2 = Convert.ToInt32(Console.ReadLine());

// Дополнительно определим две переменные maxNum, которая получит значение
// наибольшего числа, и minNum, получающую значение наименьшего числа.
// Инициализируем их значением первого введённого числа.

int minNum = num1, maxNum = num1;

// Т.к. мы уже инициализировали дополнительные переменные значением
// первого введённого числа, то нам достаточно сравнить значение
// maxNum со вторым введённым числом. Если maxNum окажется меньше
// второго введённого числа, то его значение присваивается maxNum,
// minNum остаётся без изменения. Если maxNum не меньше второго
// введённого числа, то эта переменная остаётся неизменной, а
// переменной minNum присваивается значение второго введённого числа.
// Но на первом шаге сравним введённые числа между собой, предусмотрев
// возможность ввода пользователем одинаковых чисел. В таком случае
// выводится сообщение: «Введённые числа равны».

if (num1 == num2) Console.WriteLine("Введённые числа равны.");
else
{
    if (maxNum < num2) maxNum = num2;
    else minNum = num2;
    Console.WriteLine($"Наименьшее число: {minNum}; наибольшее число: {maxNum}");
}
*/

/* Задача 4.
Написать программу, которая на вход принимает три числа и
выдаёт максимальное из этих чисел.


// Сначала выводим сообщения, предлагающие пользователю ввести по очереди
// три числа, и сохраняем введённые числа в переменных num1, num2 и num3
// соответственно, предварительно преобразовав символы в 32-х битовые числа.

Console.Write("Пожалуйста, введите первое число: ");
int num1 = Convert.ToInt32(Console.ReadLine());

Console.Write("Пожалуйста, введите второе число: ");
int num2 = Convert.ToInt32(Console.ReadLine());

Console.Write("Пожалуйста, введите третье число: ");
int num3 = Convert.ToInt32(Console.ReadLine());

// Определяем дополнительную переменную numMax и инициализируем
// её значением первого введённого числа

int numMax = num1;

// Теперь нам достаточно сравнить дополнительную переменную с
// оставшимися двумя числами, и заменить её значение значением
// проверяемого числа, если величина numMax окажется меньше.

if (numMax < num2) numMax = num2;
if (numMax < num3) numMax = num3;

Console.WriteLine("Максимальное число: " + numMax);
*/

/* Задача 6.
Написать программу, которая на вход принимает число и
сообщает, является ли это число чётным.


// Сначала выводим сообщение, предлагающее пользователю ввести число,
// и сохраняем введённое число в переменной num, предварительно
// преобразовав символы в 32-х битовое число.

Console.Write("Пожалуйста, введите число: ");
int num = Convert.ToInt32(Console.ReadLine());

// Теперь проверяем, делится ли введённое число на 2 без остатка.
// Если в результате деления остаток равен нулю, то выводим
// сообщение: «Число чётное.» В противном случае выводим
// сообщение: «Число нечётное.»

if ((num % 2) == 0) Console.WriteLine("Число чётное.");
else Console.WriteLine("Число нечётное.");
*/

/* Задача 8.
Написать программу, которая на вход принимает число N, а на выходе
показывает все чётные числа от 1 до N.

// Код программы написан в двух вариантах, отличающихся только
// организацией цикла. 1-ый вариант «заточен» под команду
// процессора «loop». 2-ой вариант под обычную логику программиста.

// 1-ый вариант.
// Сначала выводим сообщение, предлагающее пользователю ввести число,
// и сохраняем введённое число в переменной «num», предварительно
// преобразовав символы в 32-х битовое число.

Console.Write("Пожалуйста, введите число: ");
int num = Convert.ToInt32(Console.ReadLine());

// Эту программу удобнее всего организовать в виде цикла со счётчикомы
// работающим на уменьшение от введённого числа до обнуления. В этом
// качестве будем использовать саму переменную «num». Но придётся ввести
// дополнительную переменную «count», значение которой
// будет увеличиваться на каждом круге цикла. Именно её значение и будет
// выводиться, если оно будет чётным.

int count = 1;

while (num > 0)
{
    if ((count % 2) == 0) Console.Write(count + " ");
    count++;
    num--;
}


// 2-ой вариант.

Console.Write("Пожалуйста, введите число: ");
int num = Convert.ToInt32(Console.ReadLine());

int count = 1;

while (count <= num)
{
    if ((count % 2) == 0) Console.Write(count + " ");
    count++;
}
*/
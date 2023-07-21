// Первый семинар
// Теория
/*
Некоторые типы данных:
int intNumber = 25; — целое число
double doubleNumber = 12.12; — десятичная дробь (двойной точности)
string text = "Какой-то текст";
bool logicVar = true; — логическая переменная только истина (true = 1), или ложь (false = 0)

int num1 = 5;
int num2 = 10;

// Вывод строки методом конкатенации (сцепления)
Console.WriteLine("Мои числа " + num1 + " и " + num2 + " это здорово!");

// Вывод строки методом форматирования ($ и переменные в фигурных скобках {})
Console.WriteLine($"Мои числа {num1} и {num2} это здорово!");

// Запрос и ввод данных
Console.Write("Введите число: ");

// В данном случае введённые символы преобразуются в число
int num = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Вы ввели число " + num);
*/

/* Задача 1.
Написать программу, которая проверяет
является ли первое число квадратом второго

Console.Write("Введите первое число: ");
int num1 = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите второе число: ");
int num2 = Convert.ToInt32(Console.ReadLine());

int quad2 = num2 * num2;

if (num1 == quad2)
{
    Console.WriteLine("Первое число является квадратом второго.");
}
else
{
    Console.WriteLine("Первое число не является квадратом второго.");
}
*/

/* Задача 2.
Написать программу, которая на вход принимает положительное число (N),
а на выходе показывает все целые числа от -N до N.

Console.Write("Введите число: ");
int num = Convert.ToInt32(Console.ReadLine());

int current = -num;

while(current <= num)
{
    Console.Write(current + " ");
    current++;
}
*/
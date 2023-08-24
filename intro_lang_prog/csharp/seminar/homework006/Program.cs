/*
// Задача 41:
// Пользователь вводит с клавиатуры M чисел.
// Посчитайте, сколько чисел больше 0 ввёл пользователь.


int WriteWait(string outLine)
{
    Console.Write(outLine);
    int inNumber = Convert.ToInt32(Console.ReadLine());
    return inNumber;
}

void Counting(int inTotal)
{
    int count = 0;

    for (int i = 0; i < inTotal; i++)
    {
        Console.Write($"Введите {i + 1}-е число: ");

        if ((Convert.ToInt32(Console.ReadLine()) > 0))
            count++;
    }

    Console.WriteLine("Вы ввели положительных чисел: " + count);
}

Console.WriteLine("Программа подсчитывает количество введённых положительных чисел.\n");
int howMany = WriteWait("Сколько чисел собираетесь ввести? ");
Counting(howMany);
*/

/*
// Задача 43:
// Напишите программу, которая найдёт точку пересечения двух прямых,
// заданных уравнениями y = k1 * x + b1, y = k2 * x + b2;
// значения b1, k1, b2 и k2 задаются пользователем.
*/

/*
// Данная задача решается как система двух уравнений.
// Применив вычитание из первого уравнения второго, а
// также несложные преобразования, получим для координаты «x»
// x = (b2 - b1) / (k1 - k2). Затем, подставив в
// уравнение полученное значение «x», найдём координату
// «y» точки пересечения двух прямых.

float WriteWait(string outLine)
{
    Console.Write(outLine);
    float inNumber = Convert.ToSingle(Console.ReadLine());
    return inNumber;
}

void СalculationIntersection(float k1, float k2, float b1, float b2)
{
    if (k1 - k2 == 0 && b2 - b1 == 0)
        Console.WriteLine("Прямые совпадают.");
    else if (k1 - k2 == 0 && b2 - b1 != 0)
        Console.WriteLine("Прямые параллельны");
    else
    {
        float x = (b2 - b1) / (k1 - k2);
        float y = x * k1 + b1;
        Console.WriteLine($"Прямые пересекаются в точке с координатами ({x}; {y}).");
    }
}

Console.WriteLine("Программа вычисляет координаты точки пересечения двух прямых, " +
                    "заданных уравнением y = k * x + b.\n");

float inK1 = WriteWait("Введите коэффициент k первой прямой: ");
float inB1 = WriteWait("Введите смещение b первой прямой: ");
float inK2 = WriteWait("Введите коэффициент k второй прямой: ");
float inB2 = WriteWait("Введите смещение b второй прямой: ");

СalculationIntersection(inK1, inK2, inB1, inB2);
*/
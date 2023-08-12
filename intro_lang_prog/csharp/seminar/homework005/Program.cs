/*
// Задача 34: Задайте массив заполненный случайными положительными
// трёхзначными числами. Напишите программу, которая покажет количество
// чётных чисел в массиве.
// [345, 897, 568, 234] -> 2


// Задача решена в двух вариантах:
// 1. Пользователь вводит количество элементов массива
// 2. Программа случайным образом выбирает размер массива (забавы ради)

// Метод, предлагающий пользователю ввести необходимые данные:

int WriteWait(string outLine)
{
    Console.Write(outLine); // выводим предлагаемую строку
    int inNumber = Convert.ToInt32(Console.ReadLine()); // получаем от пользователя число
    return inNumber; // возвращаем полученное число
}

// Метод, генерирующий массив с заданным количеством трёхзначных элементов:

int[] RandArr(int elem)
{
    int[] arr = new int[elem]; // резервируем память под массив
    for (int i = 0; i < elem; i++)
        arr[i] = new Random().Next(100, 1000); // программа заполняет массив случайными трёхзначными числами
    return arr;
}

// Метод, осуществляющий форматированный вывод заданного массива (как в примере к задаче)

void OutArr(int elem, int[] whatArr)
{
    Console.Write("["); // выводим открывающую скобку
    for (int i = 0; i < elem - 1; i++) // цикл выводит с разделением запятой на один элемент массива меньше
        Console.Write($"{whatArr[i]}, ");
    Console.WriteLine(whatArr[elem - 1] + "]"); // выводим последний элемент массива без запятой, но с закрывающей скобкой
}

// Метод, подсчитывающий количество чётных элементов массива

void EvenNum(int elem, int[] inArray)
{
    int even = 0;
    for (int i = 0; i < elem; i++)
        if (inArray[i] % 2 == 0) even++; // если элемент массива делится без остатка на два
                                         // увеличиваем счётчик чётных элементов
    Console.WriteLine(even);
}

Console.WriteLine("\n1-й вариант:\nПользователь задаёт длину массива.\n");

Repeat:
int numOfElem = WriteWait("Введите количество элементов массива: ");
if (numOfElem <= 0) // если пользователь ввёл число меньше 1-цы предупреждаем его об этом
                    // и просим повторить ввод
{
    Console.WriteLine("Количество элементов массива не может быть меньше 1!");
    goto Repeat;
}
Console.WriteLine();

int[] array = RandArr(numOfElem); // получаем сгенерированный массив
Console.Write("В массиве: ");
OutArr(numOfElem, array); // выводим сгенерированный массив
Console.Write("количество чётных элементов равно: ");
EvenNum(numOfElem, array); // выводим количество чётных элементов

Console.WriteLine("\n2-й вариант:\nСоздание массива полностью на совести программы.\n");
int genElem = new Random().Next(5, 21);
int[] genArray = RandArr(genElem); // получаем сгенерированный программой массив
Console.Write("В массив: ");
OutArr(genElem, genArray); // выводим сгенерированный массив
Console.WriteLine($"состоящий из {genElem} элементов");
Console.Write("программа вставила чётных элементов: ");
EvenNum(genElem, genArray); // выводим количество чётных элементов
*/

/*
// Задача 36: Задайте одномерный массив, заполненный случайными числами.
// Найдите сумму элементов, стоящих на нечётных позициях.
// [3, 7, 23, 12] -> 19
// [-4, -6, 89, 6] -> 0


// Метод, предлагающий пользователю ввести необходимые данные:

int WriteWait(string outLine)
{
    Console.Write(outLine); // выводим предлагаемую строку
    int inNumber = Convert.ToInt32(Console.ReadLine()); // получаем от пользователя число
    return inNumber; // возвращаем полученное число
}

// Метод, генерирующий массив с заданными параметрами:

int[] RandArr(int elem, int minVal, int maxVal)
{
    int[] arr = new int[elem]; // резервируем память под массив
    for (int i = 0; i < elem; i++)
        arr[i] = new Random().Next(minVal, maxVal + 1); // программа заполняет массив случайными числами
    return arr;
}

// Метод, осуществляющий форматированный вывод заданного массива (как в примере к задаче)

void OutArr(int elem, int[] whatArr)
{
    Console.Write("["); // выводим открывающую скобку
    for (int i = 0; i < elem - 1; i++) // цикл выводит с разделением запятой на один элемент массива меньше
        Console.Write($"{whatArr[i]}, ");
    Console.WriteLine(whatArr[elem - 1] + "]"); // выводим последний элемент массива без запятой, но с закрывающей скобкой
}

// Метод, подсчитывающий сумму элементов массива, стоящих на нечётных позициях

void SumOddPoz(int elem, int[] inArray)
{
    int sumOddPozElem = 0;
    for (int i = 1; i < elem; i += 2) // начинаем с 1-ой позиции и далее через одну
        sumOddPozElem += inArray[i];

    Console.WriteLine(sumOddPozElem);
}

Repeat:
int numOfElem = WriteWait("Введите количество элементов массива: ");
if (numOfElem <= 0) // если пользователь ввёл число меньше 1-цы предупреждаем его об этом
                    // и просим повторить ввод
{
    Console.WriteLine("Количество элементов массива не может быть меньше 1!");
    goto Repeat;
}

int min = WriteWait("Введите минимальное значение элемента массива: ");
int max = WriteWait("Введите максимальное значение элемента массива: ");
Console.WriteLine();

int[] array = RandArr(numOfElem, min, max); // получаем сгенерированный массив
Console.Write("В массиве: ");
OutArr(numOfElem, array); // выводим сгенерированный массив
Console.Write("сумма элементов, стоящих на нечётных позициях равна: ");
SumOddPoz(numOfElem, array); // выводим сумму
*/

/*
// Задача 38: Задайте массив вещественных чисел. Найдите разницу между
// максимальным и минимальным элементом массива.
// [3.22, 4.2, 1.15, 77.15, 65.2] => 77.15 - 1.15 = 76


// Целочисленный метод, приглашающий пользователя к вводу данных:

int WriteWait(string outLine)
{
    Console.Write(outLine); // выводим предлагаемую строку
    int inNumber = Convert.ToInt32(Console.ReadLine()); // получаем от пользователя число
    return inNumber; // возвращаем полученное число
}

// Метод, приглашающий пользователя к вводу данных двойной точности:

double DoubElem(string outLine)
{
    Console.Write(outLine); // выводим предлагаемую строку
    double inNumber = Convert.ToDouble(Console.ReadLine()); // получаем от пользователя число
    return inNumber; // возвращаем полученное число
}

// Метод, введённый, чтобы лишний раз не писать запрос количества элементов

int EnterNumElem()
{
Repeat:
    int numElem = WriteWait("\nВведите количество элементов массива: ");
    if (numElem <= 0) // если пользователь ввёл число меньше 1-цы предупреждаем его об этом
                      // и просим повторить ввод
    {
        Console.WriteLine("Количество элементов массива не может быть меньше 1!");
        goto Repeat;
    }

    return numElem;
}

// Генерируем случайный набор вещественных чисел с помощью
// Random().NextDouble(). Т.к. при этом генерируются числа
// с плавающей запятой, умножаем результат на 100 и округляем
// до двух знаков: Math.Round(new Random().NextDouble() * 100, 2).
// Кроме того, случайным образом будем менять знак числа. Для
// этого создадим массив множителей: int[] mulArray = { -1, 1 },
// а индекс элемента «j» также получим случайным образом:
// int j = new Random().Next(0, 2)

double[] RandArr(int elem)
{
    double[] arr = new double[elem]; // резервируем память под массив

    for (int i = 0; i < elem; i++)
    {
        int[] mulArray = { -1, 1 }; // задаём массив множителей для случайной смены знака числа

        int j = new Random().Next(0, 2); // получаем индекс множителя
        arr[i] = Math.Round(new Random().NextDouble() * 100, 2); // программа заполняет массив случайными числами
        arr[i] *= mulArray[j]; // меняем, или оставляем знак элемента массива
    }

    return arr;
}

// Метод, создающий массив из вводимых пользователем чисел

double[] UserArr(int elem)
{
    double[] userArray = new double[elem];

    for (int i = 0; i < elem; i++)
        userArray[i] = DoubElem($"Введите {i + 1}-й элемент массива: ");

    return userArray;
}


// Метод, выводящий созданный массив на монитор

void OutArr(int elem, double[] whatArr)
{
    Console.Write("["); // выводим открывающую скобку
    for (int i = 0; i < elem - 1; i++) // цикл выводит с разделением точкой с запятой на один элемент массива меньше
        Console.Write($"{whatArr[i]}; ");
    Console.WriteLine(whatArr[elem - 1] + "]"); // выводим последний элемент массива без точки с запятой, но с закрывающей скобкой
}

// Метод, находящий минимальное и максимальное число в массиве.
// Возвращает массив из двух элементов {максимальный, минимальный}

double[] MaxMin(int elem, double[] whatArr)
{
    double[] maxMin = new double[2]; // создаём массив для возврата значений
    double maxElem = whatArr[0]; // максимальному и минимальному для начала присваиваем первый элемент массива
    double minElem = maxElem;

    for (int i = 1; i < elem; i++)
    {
        if (maxElem < whatArr[i]) // если текущий максимальный оказался меньше очередного элемента
            maxElem = whatArr[i]; // массива, то заменяем максимальный значением этого элемента
        else                      // в противном случае проверяем минимальное значение
        {
            if (minElem > whatArr[i]) // если текущий минимальный оказался больше очередного элемента
                minElem = whatArr[i]; // массива, то заменяем минимальный значением этого элемента
        }

        maxMin[0] = maxElem; // заносим максимальный и минимальный в массив для возврата
        maxMin[1] = minElem;
    }

    return maxMin;
}

Console.WriteLine("\n1-й вариант:\nПрограмма генерирует массив заданного размера из вещественных чисел.");
int numOfElem = EnterNumElem(); // запрашиваем и получаем количество генерируемых элементов

double[] genArray = RandArr(numOfElem); // получаем сгенерированный массив
Console.Write("Сгенерированный массив: ");
OutArr(numOfElem, genArray);
double[] minMaxData = MaxMin(numOfElem, genArray);

// При выводе результата используем «Round», потому что иногда выводится много знаков после запятой
Console.WriteLine($"\nРазность между элементом с максимальным значением {minMaxData[0]}\n"
+ $"и элементом с минимальным значением {minMaxData[1]} равна: {Math.Round(minMaxData[0] - minMaxData[1], 2)}");

Console.WriteLine("\n2-ой вариант:\nПользователь вводит массив.");
int entNumOfElem = EnterNumElem();

double[] userEntArray = UserArr(entNumOfElem);
Console.WriteLine("Полученный массив: ");
OutArr(entNumOfElem, userEntArray);
double[] minMaxUser = MaxMin(entNumOfElem, userEntArray);
Console.WriteLine($"\nРазность между элементом с максимальным значением {minMaxUser[0]}\n"
+ $"и элементом с минимальным значением {minMaxUser[1]} равна: {Math.Round(minMaxUser[0] - minMaxUser[1], 2)}");
*/
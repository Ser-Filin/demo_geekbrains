/*
Задача 47. Задайте двумерный массив размером m×n,
заполненный случайными вещественными числами.

m = 3, n = 4.
0,5 7 -2 -0,2
1 -3,3 8 -9,9
8 7,8 -7,1 9


// Количество строк и столбцов не могут принимать отрицательные
// значения, поэтому ограничиваем ввод беззнаковыми данными.

uint Invitation(string outText)
{
    Console.Write(outText);
    uint inNumber = Convert.ToUInt32(Console.ReadLine());

    return inNumber;
}

void GeneratedArray(uint rows, uint columns)
{
    float[,] array = new float[rows, columns];
    sbyte[] multipliers = { -1, 1 }; // массив множителей для смены знака
    Random rnd = new Random();

    for (int r = 0; r < rows; r++)
    {
        for (int c = 0; c < columns; c++)
        {
            array[r, c] = Convert.ToSingle(rnd.NextDouble() * 100);
            int indexMult = rnd.Next(0, 2); // выбираем случайный множитель
            array[r, c] *= multipliers[indexMult]; // меняем, или оставляем знак
        }
    }

    // Вывод массива на экран:

    for (int r = 0; r < rows; r++)
    {
        for (int c = 0; c < columns; c++)
            Console.Write(Math.Round(array[r, c], 2) + "; "); // ограничиваем длину числа 2-мя знаками
                                                              // после запятой

        Console.WriteLine();
    }
}

uint numbersOfRows = Invitation("Введите количество строк: ");
uint numbersOfColumns = Invitation("Введите количество столбцов: ");
Console.WriteLine();

Console.WriteLine("Массив создан:\n");
GeneratedArray(numbersOfRows, numbersOfColumns);
Console.WriteLine();
*/

/*
Задача 50. Напишите программу, которая на вход принимает позиции элемента
в двумерном массиве, и возвращает значение этого элемента или же указание,
что такого элемента нет.

Например, задан массив:
1 4 7 2
5 9 2 3
8 4 2 4
17->такого числа в массиве нет
*/

/*
Данную задачу можно решить простым поочерёдным вводом индексов
строки, затем столбца. Но меня интересует ввод пользователем в одну строчку
индексов строки и столбца, с последующим преобразованием введённых
значений в соответствующие индексы массива. Любопытства ради.
И да простит мне мою вольность преподаватель!
В первом варианте разделитель индексов строки и столбца может быть
любой, но при этом сам метод не лучший и немного запутанный.

// Для начала создадим случайный массив

int[,] CreatingArray()
{
    Random rnd = new Random();

    int rows = rnd.Next(5, 11); // генерируем количество строк от 5 до 10
    int columns = rnd.Next(5, 11); // генерируем количество столбцов от 5 до 10

    int[,] array = new int[rows, columns]; // по полученным данным резервируем под массив память

    for (int r = 0; r < rows; r++) // заполняем массив случайными целыми числами от -20 до 20
    {
        for (int c = 0; c < columns; c++)
            array[r, c] = rnd.Next(-20, 21);
    }

    return array;
}

void ShowArray(int[,] array)
{
    for (int r = 0; r < array.GetLength(0); r++)
    {
        for (int c = 0; c < array.GetLength(1); c++)
            Console.Write(array[r, c] + " ");

        Console.WriteLine();
    }
}

bool Analysis(char[] array, int[,] inArray)
{
    int row = 0,
        column = 0,
        ichar = 0;

    for (; ichar < array.Length; ichar++) // получаем количество строк, или выводим сообщение
                                          // об ошибке
    {
        int temp = (Convert.ToInt32(array[ichar])) - 48; // цифровые символы в Юникоде начинаются
                                                         // с 48 (десятичное), т.е. '0' = 48
        if (temp >= 0 && temp <= 9) // проверяем попадание в пределы цифр
            row = row * 10 + temp; // собираем из массива символов индекс строки
                                   // сгенерированного массива
        else if (ichar == 0) // если строка начинается не с цифры, то выводим сообщение об ошибке
            goto Mistake;
        else // если при сборке индекса строки встретился нецифровой символ, прерываем цикл
            break;
    }

    if (row >= inArray.GetLength(0)) // если индекс существующих строк превышен
                                     // то выводим сообщение об ошибке
    {
        Console.WriteLine($"Строки с индексом {row} не существует.");
        goto Mistake;
    }

    // После сборки индекса строки переходим к сборке индекса столбца

    ichar++; // переводим указатель на следующий элемент массива символов

    if (ichar >= array.Length) // если после первого числа не последовало второго,
                               // то выводим сообщение об ошибке
        goto Mistake;

    // Сборка индекса столбца не многим отличается от сборки индекса строки:

    for (; ichar < array.Length; ichar++) // см. комментарии выше
    {
        int temp = (Convert.ToInt32(array[ichar])) - 48;
        if (temp >= 0 && temp <= 9)
            column = column * 10 + temp;
        else
            goto Mistake;
    }

    if (column >= inArray.GetLength(1))
    {
        Console.WriteLine($"Столбца с индексом {column} не существует.");
        goto Mistake;
    }

    Console.WriteLine($"В позиции [{row}, {column}] находится элемент {inArray[row, column]}.\n");

    return true;

    Mistake:

    Console.WriteLine("Ошибка ввода.\n");
    return false;
}

Console.WriteLine("Программа создаёт случайный двумерный массив и выводит элемент,\n" +
                "из указанной пользователем ячейки.\n"
);

int[,] generatedArray = CreatingArray();
ShowArray(generatedArray);
Console.WriteLine();

Repeat:

Console.Write("Введите индексы искомого элемента, разделяя их любым нецифровым " +
                "символом\n(например, индекс_строки,индекс_столбца): "
);

string inRowCol = Console.ReadLine(); // считываем с консоли введённую строку
char[] chars = inRowCol.ToCharArray(0, inRowCol.Length); // преобразовываем введённую строку в
                                                         // массив символов Юникода
Console.WriteLine();
bool result = Analysis(chars, generatedArray); // проверяем результат работы метода поиска элемента,
                                               // и в случае ошибки просим повторить ввод
if (!result)
    goto Repeat;
*/

/*
Второй вариант решения задачи 50. Здесь строго определённые
разделители индексов строки и столбца.


int[,] CreatingArray()
{
    Random rnd = new Random();

    int rows = rnd.Next(5, 16); // генерируем количество строк от 5 до 15
    int columns = rnd.Next(5, 16); // генерируем количество столбцов от 5 до 15

    int[,] array = new int[rows, columns]; // по полученным данным резервируем под массив память

    for (int r = 0; r < rows; r++) // заполняем массив случайными целыми числами от -20 до 20
    {
        for (int c = 0; c < columns; c++)
            array[r, c] = rnd.Next(-20, 21);
    }

    return array;
}

void ShowArray(int[,] array)
{
    for (int r = 0; r < array.GetLength(0); r++)
    {
        for (int c = 0; c < array.GetLength(1); c++)
            Console.Write(array[r, c] + " ");

        Console.WriteLine();
    }
}

bool Analysis(string[] array, int[,] inArray)
{
    if (array.Length < 2 || array.Length > 2) // проверяем, чтобы в строке было ровно 2 числа
        goto Mistake;

    int indexRow = Convert.ToInt32(array[0]); // первое число присваиваем индексу строки
    if (indexRow >= inArray.GetLength(0)) // если индекс вышел за пределы массива, выводим сообщение
										  // об ошибке
    {
        Console.WriteLine($"Строки с индексом {indexRow} не существует.");
        goto Mistake;
    }

    int indexColumn = Convert.ToInt32(array[1]); // второе число присваиваем индексу столбца
    if (indexColumn >= inArray.GetLength(1)) // проверяем попадание индекса в пределы массива
    {
        Console.WriteLine($"Столбца с индексом {indexColumn} не существует.");
        goto Mistake;
    }

    Console.WriteLine(
        $"В позиции [{indexRow}, {indexColumn}] находится элемент "
            + $"{inArray[indexRow, indexColumn]}.\n"
    );

    return true;

    Mistake:

    Console.WriteLine("Ошибка ввода.\n");
    return false;
}

char[] delimiterSymbols = { ' ', ',', '.', ';' }; // массив разделителей для введённых индексов

Console.WriteLine("Программа создаёт случайный двумерный массив и выводит элемент,\n" +
                    "из указанной пользователем ячейки.\n"
);

int[,] generatedArray = CreatingArray(); // генерируем массив
ShowArray(generatedArray); // и выводим его на экран
Console.WriteLine();

Repeat:

Console.Write("Введите индексы искомого элемента, разделяя их запятой, точкой, " +
                "пробелом,\nили точкой с запятой (например, индекс_строки;индекс_столбца): "
);

string inRowCol = Console.ReadLine(); // считываем с консоли введённую строку
string[] numbers = inRowCol.Split(delimiterSymbols); // преобразовываем в массив из чисел

Console.WriteLine();
bool result = Analysis(numbers, generatedArray); // проверяем результат работы метода поиска элемента,
                                                 // и в случае ошибки просим повторить ввод
if (!result)
    goto Repeat;
*/

/*
Задача 52. Задайте двумерный массив из целых чисел.
Найдите среднее арифметическое элементов в каждом столбце.

Например, задан массив:
1 4 7 2
5 9 2 3
8 4 2 4
Среднее арифметическое каждого столбца: 4,6; 5,6; 3,6; 3.


// Для начала создадим случайный массив

int[,] GeneratedArray()
{
    Random rnd = new Random();

    int rows = rnd.Next(5, 21); // генерируем количество строк
    int columns = rnd.Next(5, 21); // генерируем количество столбцов

    int[,] array = new int[rows, columns]; // по полученным данным резервируем под массив память

    for (int r = 0; r < rows; r++) // заполняем массив случайными значениями
    {
        for (int c = 0; c < columns; c++)
            array[r, c] = rnd.Next(-20, 21);
    }

    return array;
}

void CalculateMean(int[,] array)
{
    // Вычисленное среднее арифметическое по столбцам
    // соберём в массив, который и будем выводить

    float[] meanArray = new float[array.GetLength(1)]; // резервируем память под новый массив
                                                       // количеством столбцов исходного массива
    for (int i = 0; i < array.GetLength(1); i++)
    {
        for (int r = 0; r < array.GetLength(0); r++)
            meanArray[i] += array[r, i];

        meanArray[i] /= array.GetLength(0);
    }

    for (int i = 0; i < meanArray.Length; i++)
        Console.Write(meanArray[i] + "; ");
}

void ShowArray(int[,] array)
{
    for (int r = 0; r < array.GetLength(0); r++)
    {
        for (int c = 0; c < array.GetLength(1); c++)
            Console.Write(array[r, c] + "; ");

        Console.WriteLine();
    }
}

Console.WriteLine(
    "Программа создаёт случайный двумерный массив\nи выводит среднее арифметическое" +
        " каждого столбца.\n"
);
int[,] genArray = GeneratedArray();

Console.WriteLine("В массиве:\n");
ShowArray(genArray);
Console.Write("\nсреднее арифметическое каждого столбца: ");
CalculateMean(genArray);
Console.WriteLine();
*/

/*
По согласованию с преподавателем, сюда включена дополнительная задача
преобразования десятичного числа в его двоичный эквивалент.


uint Invitation(string outText)
{
    Console.Write(outText);
    uint inNumber = Convert.ToUInt32(Console.ReadLine());

    return inNumber;
}

void Converter(uint input)
{
    byte[] binaryArray = new byte[32]; // Резервируем 32 байта для массива
    byte b = 0; // Переменная для действительного количества байтов

    for (uint n = input; n > 0; n /= 2) // Организовываем цикл пока не обнулится исходное число
                                        // при делении на 2
    {
        binaryArray[b] = Convert.ToByte(n % 2); // Остаток очередного деления заносим в массив
        b++;
    }

    // Поскольку мы получили двоичное число задом наперёд, то переворачиваем его

    for (int i = 0; i < b / 2; i++)
    {
        byte temp = binaryArray[i];
        binaryArray[i] = binaryArray[b - i - 1];
        binaryArray[b - i - 1] = temp;
    }

    for (int i = 0; i < b; i++) // Выводим массив на экран
        Console.Write(binaryArray[i]);
}

Console.WriteLine(
    "Программа переводит число из десятичной системы счисления в двоичную.\n"
        + "Предельное значение 4 294 967 295.\n"
);
uint number = Invitation("Пожалуйста, введите целое положительное число для преобразования: ");

Console.Write("Ваше число в двоичной системе счисления, в порядке Big endian: ");
Converter(number);
Console.WriteLine();
*/

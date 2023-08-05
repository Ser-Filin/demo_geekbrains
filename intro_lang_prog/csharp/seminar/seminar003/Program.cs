// Семинар 3.

// Теория.

// Возведение в степень Math.Pow(число, степень)
// Извлечение квадратного корня Math.Sqrt(число)
// Округление до N знаков после запятой Math.Round(double число, N)

// Примеры:
// Console.WriteLine(Math.Pow(5, 2));
// Console.WriteLine(Math.Sqrt(25));
// Console.WriteLine(Math.Round(Math.Sqrt(24), 2));

/*
// Напишите программу, которая по заданному номеру четверти
// показывает диапазон возможных координат точек в этой четверти (x и y).

void WriteRange(int quad)
{
    if (quad < 1 || quad > 4) Console.WriteLine("Ошибочные данные!");
    else if (quad == 1) Console.WriteLine("x > 0 и y > 0");
    else if (quad == 2) Console.WriteLine("x < 0 и y > 0");
    else if (quad == 3) Console.WriteLine("x < 0 и y < 0");
    else Console.WriteLine("x > 0 и y < 0");
}

Console.Write("Введите номер квадранта: ");
int quadrant = Convert.ToInt32(Console.ReadLine());

WriteRange(quadrant);
*/


/*
// Напишите программу, которая принимает на вход координаты
// точки (X и Y), причём X ≠ 0 и Y ≠ 0 и выдаёт номер четверти
// плоскости, в которой находится эта точка.

int WriteWait(string outLine)
{
    Console.Write(outLine);
    int inNumber = Convert.ToInt32(Console.ReadLine());
    return inNumber;
}

bool ChekNull(int abs, int ord)
{return abs == 0 || ord == 0;}

int Quad(int abs, int ord)
{
    if (abs > 0 && ord > 0) return 1;
    if (abs < 0 && ord > 0) return 2;
    if (abs < 0 && ord < 0) return 3;
    return 4;
}

Repeat:
int x = WriteWait("Введите координату x: ");
int y = WriteWait("Введите координату y: ");

if (ChekNull(x, y))
{
    Console.WriteLine("Некорректный ввод, пожалуйста введите ещё раз.");
    goto Repeat;
}

else Console.WriteLine ($"Координаты лежат в {Quad(x, y)} квадранте.");
*/

/*
// Напишите программу, которая принимает на вход число (N)
// и выдаёт квадраты чисел от 1 до N.


int WriteWait(string outLine)
{
    Console.Write(outLine);
    int inNumber = Convert.ToInt32(Console.ReadLine());
    return inNumber;
}

void Square(int num)
{
    for (int count = 1; count <= num; count++)
    {
        Console.WriteLine($"{count} – {count * count}");
    }
}

Repeat:
int number = WriteWait("Пожалуйста, введите целое положительное число: ");
if (number <= 0)
{
    Console.WriteLine("Ошибочный ввод.");
    goto Repeat;
}
Square(number);
*/

/*
// Напишите программу, которая принимает на вход координаты
// двух точек и находит расстояние между ними в 2D пространстве.


int WriteWait(string outLine)
{
    Console.Write(outLine);
    int inNumber = Convert.ToInt32(Console.ReadLine());
    return inNumber;
}

void Distance(int xA, int yA, int xB, int yB)
{
    double hypotenuse = Math.Sqrt(Math.Pow((xA - xB), 2) + Math.Pow((yA - yB), 2));
    Console.WriteLine($"Расстояние между точками A и B равно: {Math.Round(hypotenuse, 2)}");
}

int abscA = WriteWait("Введите абсциссу точки A: ");
int ordA = WriteWait("Введите ординату точки A: ");
int abscB = WriteWait("Введите абсциссу точки B: ");
int ordB = WriteWait("Введите ординату точки B: ");

Distance(abscA, ordA, abscB, ordB);
*/
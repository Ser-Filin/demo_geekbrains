/*
// Задача 19
// Напишите программу, которая принимает на вход пятизначное число и проверяет, является ли оно палиндромом.
// 14212 -> нет
// 12821 -> да
// 23432 -> да
// Дополнение преподавателя: с любым количеством разрядов.

// Как обычно, метод приглашения и ввода 

int WriteWait(string outLine)
{
    Console.Write(outLine);
    int inNumber = Convert.ToInt32(Console.ReadLine());
    return inNumber;
}

// Проще всего развернуть число, т.е поменять местами старший и младший разряды
// и далее по порядку, а затем сравнить перевёртыш с исходным числом. Для этого
// будем в цикле выделять младший разряд исходного числа и прибавлять его к накопителю
// перевёртыша, предварительно умноженному на 10, для добавления очередного разряда.
// При таком подходе, если число оканчивается на ноль, то цикл прерывается, поскольку и
// начинать число с нуля тоже плохой тон. При возврате, нам нужно знать только:
// введённое число – палиндром, или нет. Поэтому возвращаться будет «ИСТИНА»,
// или «ЛОЖЬ». Предварительно проверим, что число имеет не менее 2-х разрядов.
// Переменные:
// number – введённое число;
// cutNumber – промежуточное число, чтобы не потерять исходное;
// flip – накопитель перевёртыша.

bool Palin(int num)
{
    if (num < 10) return false;
    else
    {
        int cutNumber = num, flip = 0;

        while (cutNumber > 0)
        {
            flip *= 10;
            flip += cutNumber % 10;
            if (flip == 0) return false;
            cutNumber /= 10;
        }

        if (flip != num) return false;
    }

    return true;
}

Repeat:
int number = WriteWait("Введите целое положительное число: ");
if (number <= 0) goto Repeat; // если ввели отрицательное число, повторяем запрос
if (Palin(number)) Console.WriteLine($"Число {number} – палиндром.");
else Console.WriteLine($"Число {number} – не палиндром.");
*/

/*
// Задача 21
// Напишите программу, которая принимает на вход координаты двух
// точек и находит расстояние между ними в 3D пространстве.
// A (3,6,8); B (2,1,-7), -> 15.84
// A (7,-5, 0); B (1,-1,9) -> 11.53

 
// Как обычно, метод приглашения и ввода

int WriteWait(string outLine)
{
    Console.Write(outLine);
    int inNumber = Convert.ToInt32(Console.ReadLine());
    return inNumber;
}

// Расстояние между точками вычислим по известной со школьной скамьи
// формуле. Вывод результата поместим в тело метода, поэтому он ничего
// возвращать не будет.

void Distance(int xA, int yA, int zA, int xB, int yB, int zB)
{
    double square = Math.Sqrt(Math.Pow((xB - xA), 2) + Math.Pow((yB - yA), 2) + Math.Pow((zB - zA), 2));
    Console.WriteLine("Расстояние между точками A и B равно " + Math.Round(square, 2));
}

int abscA = WriteWait("Введите абсциссу точки A: ");
int ordA = WriteWait("Введите ординату точки A: ");
int applA = WriteWait("Введите аппликату точки A: ");
int abscB = WriteWait("Введите абсциссу точки B: ");
int ordB = WriteWait("Введите ординату точки B: ");
int applB = WriteWait("Введите аппликату точки B: ");

Distance(abscA, ordA, applA, abscB, ordB, applB);
*/

/*
// Задача 23
// Напишите программу, которая принимает на вход число (N) и выдаёт таблицу кубов чисел от 1 до N.
// 3 -> 1, 8, 27
// 5 -> 1, 8, 27, 64, 125


// Как обычно, метод приглашения и ввода 

int WriteWait(string outLine)
{
    Console.Write(outLine);
    int inNumber = Convert.ToInt32(Console.ReadLine());
    return inNumber;
}

// Поместим вывод результата внутрь тела метода.
// В связи с этим, нам не нужно, чтобы он что-либо
// возвращал основной программе. Поэтому используем
// тип «void».

void Cubing(int num)
{
    int count = 1;
    while (count <= num)
    {
        Console.WriteLine($"{count} – {Math.Pow(count, 3)}");
        count++;
    }
}

Repeat:
int number = WriteWait("Введите целое положительное число: ");
if (number < 1)
{
    Console.WriteLine("Пожалуйста, будьте внимательны!");
    goto Repeat;
}
Console.WriteLine($"Таблица чисел от 1 до {number}:");
Cubing(number);
*/
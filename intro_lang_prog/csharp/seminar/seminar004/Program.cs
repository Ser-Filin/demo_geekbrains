// Напишите программу, которая принимает на вход число (А)
// и выдаёт сумму чисел от 1 до А.

// int WriteWait(string outLine)
// {
//     Console.Write(outLine);
//     int inNumber = Convert.ToInt32(Console.ReadLine());
//     return inNumber;
// }

// int Sum(int num)
// {
//     int accum = 0, count = 1;
//     while (count <= num)
//     {
//         accum += count;
//         count++;
//     }
//     return accum;
// }

// int number = WriteWait("Введите число: ");
// Console.WriteLine($"Сумма равна: {Sum(number)}");


// Напишите программу, которая принимает на вход
// число и выдаёт количество цифр в числе.

// int WriteWait(string outLine)
// {
//     Console.Write(outLine);
//     int inNumber = Convert.ToInt32(Console.ReadLine());
//     return inNumber;
// }

// int CompDigit(int num)
// {
//     int num2 = num; 
//     int i=0;
//     while(num2 > 0)
//     {
//         num2/=10;
//         i++; 
//     }
//     return i;
// }

// int number = WriteWait("Введите число: ");

// Console.WriteLine($"Количество цифр: {CompDigit(number)}");

// Напишите программу, которая принимает на вход
// число N и выдаёт произведение нечетных чисел от 1 до N.

// int WriteWait(string outLine)
// {
//     Console.Write(outLine);
//     int inNumber = Convert.ToInt32(Console.ReadLine());
//     return inNumber;
// }

// int Mult(int num)
// {
//     int count = 3, mul = 1;

//     while (count <= num)
//     {
//         mul*=count;
//         count+=2;
//     }
//     return mul;
// }

// int number = WriteWait("Введите число: ");
// Console.WriteLine(Mult(number));

/*
ПРО МАССИВЫ


int[] CreateRandomArray(int size, int minValue, int maxValue)
{
    int[] array = new int[size]; // инициализация массива: в квадратных скобках всегда указывается
                                 // размер массива
    for (int i = 0; i < size; i++)
        array[i] = new Random().Next(minValue, maxValue + 1);

    return array;
}

void WriteArray(int[] array)
{
    for (int i = 0; i < array.Length; i++)
        Console.Write(array[i] + " ");

    Console.WriteLine();
}

Console.Write("Введите количество элементов массива: ");
int length = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите минимальное значение элемента массива: ");
int min = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите максимальное значение элемента массива: ");
int max = Convert.ToInt32(Console.ReadLine());

int[] myArray=CreateRandomArray(length, min, max);
WriteArray(myArray);
*/
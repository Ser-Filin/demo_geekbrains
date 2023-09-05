using System;

/*Задача 58: Задайте две матрицы. Напишите программу,
которая будет находить произведение двух матриц.
Например, даны 2 матрицы:
2 4 | 3 4
3 2 | 3 3
Результирующая матрица будет:
18 20
15 18*/

/*
// Предоставим программе самой создать случайные матрицы:

// Чтобы матрицы можно было перемножить, количество столбцов
// первой матрицы должно быть равно количеству строк второй матрицы.
// Т.к. для генерации обеих матриц будет использоваться один и
// тот же метод, то в качестве параметра передаём количество
// столбцов первой сгенерированной матрицы, или ноль, если
// первая матрица не была создана.

int[,] СreatingМatrices(int rows)
{
    Random rnd = new Random(); // это для сокращения дальнейших записей

    int row,
        column;

    if (rows == 0) // если первая матрица не была создана,
        row = rnd.Next(5, 16); // программа генерирует количество строк первой матрицы от 5 до 15
    else
        row = rows; // либо количество строк второй матрицы принимает количество столбцов первой

    column = rnd.Next(5, 16); // для обеих матриц генерируется количество столбцов от 5 до 15

    int[,] array = new int[row, column];

    for (int r = 0; r < row; r++) // заполняем матрицы случайными числами от -20 до 20
    {
        for (int c = 0; c < column; c++)
            array[r, c] = rnd.Next(-20, 21);
    }

    return array;
}

// Модуль умножения матриц принимает первую и вторую матрицы
// и возвращает третью матрицу, являющуюся произведением первых двух.
// В результирующей матрице количество строк должно быть равно
// количеству строк первой матрицы, а количество столбцов – количеству
// столбцов второй. В таком порядке и резервируем память под результирующую
// матрицу.

int[,] MatrixMultiplication(int[,] arrayA, int[,] arrayB)
{
    int[,] arrayC = new int[arrayA.GetLength(0), arrayB.GetLength(1)];

    // Первый цикл пересчитывает строки результирующей матрицы:

    for (int r = 0; r < arrayA.GetLength(0); r++)
    {
        // Второй цикл пересчитывает столбцы результирующей матрицы:

        for (int c = 0; c < arrayB.GetLength(1); c++)

            // Третий цикл непосредственно выполняет перемножение
            // матриц A(nxk) и B(kxm) и поэлементно записывает результат
            // в результирующую матрицу соответственно формуле:
            // c(i,j) = a(i,1)*b(1,j) + a(i,2)*b(2,j) + ... + a(i,k)*b(k,j); i = 1,...,n; j = 1,...,m

            for (int colA = 0; colA < arrayA.GetLength(1); colA++)
            {
                int temp = arrayA[r, colA] * arrayB[colA, c]; // см. вышеприведённую формулу
                arrayC[r, c] += temp;
            }
    }

    return arrayC;
}

// Метод выводящий любую матрицу на экран:

void ShowMatrix(int[,] matrix)
{
    for (int r = 0; r < matrix.GetLength(0); r++)
    {
        for (int c = 0; c < matrix.GetLength(1); c++)
            Console.Write(matrix[r, c] + "; ");

        Console.WriteLine();
    }
}

ConsoleKeyInfo input; // чтобы впоследствии получить код нажатой клавиши

Console.WriteLine("Программа создаёт две матрицы и выводит их произведение.\n");

Repeat:

int[,] firstMatrix = СreatingМatrices(0); // генерируем первую матрицу
int[,] secondMatrix = СreatingМatrices(firstMatrix.GetLength(1)); // генерируем вторую матрицу

// Выводим на экран первую матрицу:

Console.WriteLine("Первая матрица:\n");
ShowMatrix(firstMatrix);
Console.WriteLine();

// Выводим на экран вторую матрицу:

Console.WriteLine("Вторая матрица:\n");
ShowMatrix(secondMatrix);
Console.WriteLine();

int[,] matrixProduct = MatrixMultiplication(firstMatrix, secondMatrix); // перемножаем матрицы

// Выводим на экран результирующую матрицу:

Console.WriteLine("Произведение первой и второй матриц:\n");
ShowMatrix(matrixProduct);
Console.WriteLine();

Repeat2:

Console.Write("Создать новые матрицы (y/n)? "); // это понятно без слов

input = Console.ReadKey(); // получаем код нажатой клавиши
Console.WriteLine("\n");

if (input.Key == ConsoleKey.Y) // если была нажата клавиша Y, очищаем экран и повторяем весь процесс
{
    Console.Clear();
    goto Repeat;
}
if (input.Key != ConsoleKey.N) // если не были нажаты ни Y, ни N, повторяем вопрос, иначе, завершаем программу
    goto Repeat2;
*/


/*Задача 60. ...Сформируйте трёхмерный массив из неповторяющихся двузначных чисел.
Напишите программу, которая будет построчно выводить массив, добавляя индексы каждого элемента.
Массив размером 2 x 2 x 2
66(0,0,0) 25(0, 1, 0)
34(1, 0, 0) 41(1, 1, 0)
27(0, 0, 1) 90(0, 1, 1)
26(1, 0, 1) 55(1, 1, 1)*/

// Модуль, приглашающий к вводу и возвращающий введённую строку:

            string Invitation(string outText)
            {
                Console.Write(outText);
                string inLine = Console.ReadLine();

                return inLine;
            }

            // Модуль извлекающий числа из строки, и игнорирующий все остальные символы:

            int[] NumbersExtract(string inLine)
            {
                char[] charArray = inLine.ToCharArray(0, inLine.Length); // строка преобразована в массив символов
                int[] tempArray = new int[charArray.Length]; // временный массив создан, чтобы не передавать ложный размер
                int ind = 0, quantiti = 0, number = -1; // по порядку: индекс временного и возвращаемого массивов,
                                                        // количество действительно собранных чисел,
                                                        // собираемое число (-1 цифра не обнаружена)

                for (int i = 0; i < charArray.Length; i++)
                {
                    int digit = Convert.ToInt32(charArray[i]) - 48;
                    if (digit >= 0 && digit <= 9)
                    {
                        if (number >= 0)
                        {
                            number = number * 10 + digit;
                        }

                        else
                        {
                            number = 0;
                            number = number * 10 + digit;
                        }
                    }
                    else if (number >= 0)
                    {
                        tempArray[ind] = number;
                        ind++;
                        quantiti++;
                        number = -1;
                    }
                }

                if (number >= 0)
                {
                    tempArray[ind] = number;
                    quantiti++;
                }

                int[] outArray = new int[quantiti]; // резервирование памяти возвращаемого массива действительным
                                                    // количеством элементов

                for (ind = 0; ind < outArray.Length; ind++)
                    outArray[ind] = tempArray[ind];

                return outArray;
            }

            // Проверка правильности ввода:

            bool Check(int[] numArray)
            {
                if (numArray.Length < 3)
                {
                    Console.WriteLine("Вероятно Вы забыли ввести какие-то параметры.\n");
                    return false;
                }

                if (numArray.Length > 3)
                {
                    Console.WriteLine("Вы ввели лишние параметры.\n");
                    return false;
                }

                if (numArray[0] < 2 || numArray[1] < 2 || numArray[2] < 2)
                {
                    Console.WriteLine($"Невозможно создать трёхмерный массив с параметрами ({numArray[0]}, " +
                        $"{numArray[1]}, {numArray[2]}).\n");
                    return false;
                }

                if (numArray[0] * numArray[1] * numArray[2] > 99)
                {
                    Console.WriteLine("Превышен лимит двузначных чисел.\n");
                    return false;
                }

                return true;
            }

            // модуль создания 3-х мерного массива

            int[,,] Creating3DArray(int[] inMetric)
            {
                int[,,] array3D = new int[inMetric[0], inMetric[1], inMetric[2]];

                // Чтобы не проходить по всем строкам, столбцам и глубине в поисках уже включённого
                // числа, создан вспомогательный байтовый массив, в котором отметка "1" – соответствует
                // уже включённому числу, "0" – его отсутствию. При этом сгенерированное число (число - 10) будет
                // являться индексом элемента проверочного массива.

                byte[] checkArray = new byte[90];

                // r – row, c – column, d – depth

                for (int d = 0; d < inMetric[2]; d++)
                {
                    for (int r = 0; r < inMetric[0]; r++)
                    {
                        for (int c = 0; c < inMetric[1]; c++)
                        {
                            int temp;

                            do
                            {
                                temp = new Random().Next(10, 100);
                            }
                            while (checkArray[temp - 10] != 0);

                            array3D[r, c, d] = temp;
                            checkArray[temp - 10] = 1;
                        }
                    }
                }

                return array3D;
            }

            void ShowArray(int[,,] array)
            {
                for (int d = 0; d < array.GetLength(2); d++)
                {
                    for (int r = 0; r < array.GetLength(0); r++)
                    {
                        for (int c = 0; c < array.GetLength(1); c++)
                            Console.Write($"{array[r, c, d]}({r}, {c}, {d}) ");
                        Console.WriteLine();
                    }
                    Console.WriteLine();
                }
            }


            ConsoleKeyInfo input;

            Console.WriteLine("Программа создаёт трёхмерный массив из неповторяющихся положительных " +
                "двузначных\nчисел и выводит его на экран, сопровождая каждый элемент его индексом.\n");

        Repeat:

            string inData = Invitation("Введите размеры массива (строки, столбцы, глубина; разделителем " +
                "может быть любой нецифровой символ): ");
            Console.WriteLine();

            int[] metric = NumbersExtract(inData);
            if (!Check(metric))
                goto Repeat;

            int[,,] array3d = Creating3DArray(metric);

            ShowArray(array3d);
            Console.WriteLine();

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

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

using System;

namespace ElementSearch
{
    internal class Program
    {
        static void Main(string[] args)
        {

            /*В данной задаче меня интересует ввод пользователем в одну строчку
            индексов строки и столбца, с последующим преобразованием введённых
            значений в соответствующие индексы массива. И да простит мне мою
            вольность преподаватель!
            В первом варианте разделитель индексов строки и столбца может быть
            любой, но при этом сам метод не лучший и немного запутанный.
            */

            /*
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
                int row = 0, column = 0, ichar = 0;

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

                // Сборка индекса столбца почти не отличается от сборки индекса строки:

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

            ConsoleKeyInfo input;

            Console.WriteLine("Программа создаёт случайный двумерный массив и выводит элемент,\n" +
                "из указанной пользователем ячейки.\n");

            int[,] generatedArray = CreatingArray();
            ShowArray(generatedArray);
            Console.WriteLine();

            Repeat:

            Console.Write("Введите индексы искомого элемента, разделяя их любым нецифровым " +
                            "символом\n(например, индекс_строки,индекс_столбца): ");


            string inRowCol = Console.ReadLine(); // считываем с консоли введённую строку
            char[] chars = inRowCol.ToCharArray(0, inRowCol.Length); // преобразовываем введённую строку в
                                                                     // массив символов Юникода
            Console.WriteLine();
            bool result = Analysis(chars, generatedArray); // проверяем результат работы метода поиска элемента,
                                                           // и в случае ошибки просим повторить ввод
            if (!result)
                goto Repeat;

            Repeat2:

            Console.Write("Продолжить (y/n)? ");

            input = Console.ReadKey();
            Console.WriteLine("\n");

            if (input.Key == ConsoleKey.Y)
                goto Repeat;
            if (input.Key != ConsoleKey.N)
                goto Repeat2;*/


            /*
            Второй вариант решения задачи 50. Здесь строго определённые
            разделители индексов строки и столбца.
            */

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

                Console.WriteLine($"В позиции [{indexRow}, {indexColumn}] находится элемент " +
                                    $"{inArray[indexRow, indexColumn]}.\n");

                return true;

            Mistake:

                Console.WriteLine("Ошибка ввода.\n");
                return false;
            }

            ConsoleKeyInfo input; // инициализируем переменную для считывания нажатой клавиши

            char[] delimiterSymbols = { ' ', ',', '.', ';' }; // массив разделителей для введённых индексов

            Console.WriteLine("Программа создаёт случайный двумерный массив и выводит элемент,\n" +
                "из указанной пользователем ячейки.\n");

            int[,] generatedArray = CreatingArray(); // генерируем массив
            ShowArray(generatedArray); // и выводим его на экран
            Console.WriteLine();

        Repeat:

            Console.Write("Введите индексы искомого элемента, разделяя их запятой, точкой, " +
                            "пробелом,\nили точкой с запятой (например, индекс_строки;индекс_столбца): ");

            string inRowCol = Console.ReadLine(); // считываем с консоли введённую строку
            string[] numbers = inRowCol.Split(delimiterSymbols); // преобразовываем в массив из чисел

            Console.WriteLine();
            bool result = Analysis(numbers, generatedArray); // проверяем результат работы метода поиска элемента,
                                                             // и в случае ошибки просим повторить ввод
            if (!result)
                goto Repeat;

            Repeat2:

            Console.Write("Продолжить (y/n)? "); // запрашиваем пользователя о продолжении или завершении работы

            input = Console.ReadKey();
            Console.WriteLine("\n");

            if (input.Key == ConsoleKey.Y)
                goto Repeat;
            if (input.Key != ConsoleKey.N)
                goto Repeat2;
        }
    }
}

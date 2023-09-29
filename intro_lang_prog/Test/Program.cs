using System;
using System.Text;

namespace Test
{
    internal class Program
    {
        static void Main()
        {
            // Для понимания кода, сверяйтесь с прилагаемой в репозитории блок-схемой алгоритма в формате «drowio».

            // Массивы, заданные в условии задачи:

            string[] array1 = { "Hello", "2", "world", ":-)" };
            string[] array2 = { "1234", "1567", "-2", "computer science" };
            string[] array3 = { "Russia", "Denmark", "Kazan" };

            // Сборка и вывод конечного массива из трёх или меньшего количества элементов:

            void ThreeSymbols(string[] arrayIn)
            {
                /*
 Для сборки конечного массива создаётся временный массив, в который будут
собраны все строки с количеством символов меньше или равным трём. Размер временного
массива задаётся равным размеру входящего массива. Поскольку размер конечного
массива может отличаться от размера входящего массива, то вводим счётчик элементов,
чтобы впоследствии создать конечный массив из требуемых элементов.
 */

                string[] tempArray = new string[arrayIn.Length]; // временный массив
                uint elementCount = 0; // счётчик количества элементов конечного массива

                for (int i = 0; i < arrayIn.Length; i++)
                {
                    if (arrayIn[i].Length <= 3) // если длина строки в пределах трёх символов
                    {
                        tempArray[elementCount] = arrayIn[i]; // заносим строку во временный массив
                        elementCount++; // подсчитываем элемент, готовим следующую ячейку временного массива к приёму
                    }
                }

                if (elementCount != 0) // если найдена хотя бы одна строка, удовлетворяющая заданному условию
                {
                    string[] outArray = new string[elementCount]; // размер конечного массива
                                                                  // равен количеству занесённых во временный
                                                                  // массив элементов
                    for (int i = 0; i < elementCount; i++)
                        outArray[i] = tempArray[i]; // перенос собранных элементов в конечный массив

                    Console.WriteLine("[\"{0}\"]", String.Join("\", \"", outArray)); // вывод собранного массива
                }

                else // если не найдена ни одна строка, удовлетворяющая заданному условию
                    Console.WriteLine("в заданном массиве отсутствуют элементы с меньшим " +
                        "или равным 3-ём количеством символов.");
            }

            void Examples(string[] arrayIn)
            {
                Console.WriteLine("Исходный массив: [\"{0}\"].", String.Join("\", \"", arrayIn));
                Console.Write("Созданный массив: ");
                ThreeSymbols(arrayIn);
                Console.WriteLine();
            }

            Console.InputEncoding = Encoding.Unicode; // в консоли можно вводить символы Юникода, в т.ч. русские
            ConsoleKeyInfo input; // переменная для получения кода клавиши

            Console.WriteLine("Программа из заданного массива собирает массив, содержащий строки из меньшего, или " +
                "равного 3-ём количества элементов.\nПримеры:\n");

            Examples(array1);
            Examples(array2);
            Examples(array3);

        Repeat:
            Console.Write("Введите ряд строковых значений (без кавычек), разделяя их запятыми и/или пробелами: ");
            string inString = Console.ReadLine(); // считывание введённой пользователем строки

            if (inString.Length == 0)
                goto Repeat;

            char[] separators = new char[] { ',', ' ' }; // массив разделителей для преобразования строки в
                                                    // строковый массив
            string[] stringArray = inString.Split(separators, StringSplitOptions.RemoveEmptyEntries); // создание
                                                                                                      // строкового
                                                                                                      // массива
            Console.Write("Созданный массив: ");
            ThreeSymbols(stringArray);
            Console.WriteLine();

        Repeat2:
            Console.Write("Желаете продолжить (y/n)? ");

            input = Console.ReadKey(); // получение кода нажатой клавиши
            Console.WriteLine();

            if (input.Key == ConsoleKey.Y) // если нажата клавиша с символом «Y»
            {
                Console.Clear();
                goto Repeat;
            }
            if (input.Key != ConsoleKey.N) // если не нажата клавиша с символом «N»
                goto Repeat2;
        }
    }
}

/*Задача 58: Задайте две матрицы. Напишите программу,
которая будет находить произведение двух матриц.
Например, даны 2 матрицы:
2 4 | 3 4
3 2 | 3 3
Результирующая матрица будет:
18 20
15 18*/

using System;

namespace MatrixProduct
{
    internal class Program
    {
        static void Main()
        {
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

                int row, column;

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
        }
    }
}

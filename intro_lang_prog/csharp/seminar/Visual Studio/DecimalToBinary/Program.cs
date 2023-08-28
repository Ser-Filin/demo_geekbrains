using System;

namespace DecimalToBinary
{
    internal class Program
    {
        static void Main(string[] args)
        {
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

            Console.WriteLine("Программа переводит число из десятичной системы счисления в двоичную.\n" +
                                "Предельное значение 4 294 967 295.\n");
            uint number = Invitation("Пожалуйста, введите целое положительное число для преобразования: ");

            Console.Write("Ваше число в двоичной системе счисления, в порядке Big endian: ");
            Converter(number);
            Console.WriteLine();
        }
    }
}

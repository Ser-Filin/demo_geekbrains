/*Задача 68: Напишите программу вычисления функции Аккермана с помощью рекурсии.
Даны два неотрицательных числа m и n.
m = 2, n = 3->A(m, n) = 9
m = 3, n = 2->A(m, n) = 29*/



using System;

namespace RecursAckermannFunction
{
    internal class Program
    {
        static void Main()
        {
            uint Invitation(string outText)
            {
                Console.Write(outText);
                uint inNumber = Convert.ToUInt32(Console.ReadLine());

                return inNumber;
            }

            uint Funct(uint inM, uint inN)
            {
                if (inM == 0)
                    return inN + 1;

                if (inN == 0)
                    return Funct(inM - 1, 1);

                return Funct(inM - 1, Funct(inM, inN - 1));
            }

            Console.WriteLine("Программа вычисляет значение функции Аккермана.");
            uint parM = Invitation("Введите параметр M функции: ");
            uint parN = Invitation("Введите параметр N функции: ");
            Console.WriteLine();

            Console.WriteLine("Результат функции " + Funct(parM, parN));
        }
    }
}

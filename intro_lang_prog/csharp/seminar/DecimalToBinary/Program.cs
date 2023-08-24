uint Invitation(string outText)
{
    Console.Write(outText);
    uint inNumber = Convert.ToUInt32(Console.ReadLine());

    return inNumber;
}

// На всякий случай будем возвращать полученный массив.
// Поэтому не будем использовать метод типа void.

byte[] Converter(uint input)
{
    // Будем переводить беззнаковое целое 32-х битовое число.
    // Первым элементом массива будет количество битов числа.
    
    byte[] binaryArray = new byte[33]; // Резервируем 32 байта для числа + 1 байт для количества битов
    byte b = 1; // Резервируем первый элемент массива

    for (uint n = input; n > 0; n /= 2) // Организовываем цикл пока не обнулится исходное число
                                        // при делении на 2
    {
        binaryArray[b] = Convert.ToByte(n % 2); // Остаток очередного деления заносим в массив
        b++;
    }

    binaryArray[0] = b; // Сохраняем количество битов в первом элементе массива

    // Поскольку мы получили двоичное число задом наперёд, то переворачиваем его,
    // исключая первый элемент массива

    for (int i = 1; i <= b / 2; i++)
    {
        byte temp = binaryArray[i];
        binaryArray[i] = binaryArray[b - i];
        binaryArray[b - i] = temp;
    }

    return binaryArray;
}

void OutBinary(byte[] binaryArray)
{
    byte size = binaryArray[0]; // Извлекаем количество битов

    for (int i = 1; i < size; i++) // Выводим массив на экран, начиная со второго элемента
        Console.Write(binaryArray[i]);
}

Console.WriteLine("Программа переводит число из десятичной системы счисления в двоичную.\n" +
                    "Предельное значение 4 294 967 295.\n");
uint number = Invitation("Пожалуйста, введите целое положительное число для преобразования: ");
byte[] binary = Converter(number);

Console.Write("Ваше число в двоичной системе счисления, в порядке Big endian: ");
OutBinary(binary);
Console.WriteLine();

uint Invitation(string outText)
{
    Console.Write(outText);
    uint inNumber = Convert.ToUInt32(Console.ReadLine());

    return inNumber;
}

byte[] Converter(uint input)
{
    byte[] binaryArray = new byte[33];
    byte b = 1;

    for (uint n = input; n > 0; n /= 2)
    {
        binaryArray[b] = Convert.ToByte(n % 2);
        b++;
    }

    binaryArray[0] = b;

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
    byte size = binaryArray[0];

    for (int i = 1; i < size; i++)
        Console.Write(binaryArray[i]);
}

Console.WriteLine(
    "Программа переводит число из десятичной системы счисления в двоичную.\n"
        + "Предельное значение 4 294 967 295.\n"
);
uint number = Invitation("Пожалуйста, введите целое положительное число для преобразования: ");
byte[] binary = Converter(number);

Console.Write("Ваше число в двоичной системе счисления, в порядке Big endian: ");
OutBinary(binary);
Console.WriteLine();

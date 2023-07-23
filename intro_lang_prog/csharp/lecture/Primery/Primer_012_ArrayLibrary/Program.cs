// Создаём метод FillArray, который принимает целочисленный
// аргумент collection, в качестве массива. void — означает,
// что метод не возвращает никаких значений.

void FillArray(int[] collection)
{
    int length = collection.Length; // присваиваем переменной length длину массива collection
    int index = 0;
    while (index < length)
    {
        collection[index] = new Random().Next(1, 10); // По очереди кладём в массив collection случайные числа в диапазоне от 1 до 9
        index++;
    }
} 

// Создаём метод, который будет выводить массив

void PrintArray(int[] col)
{
    int count = col.Length;
    int position = 0;
    while (position < count)
    {
        Console.WriteLine(col[position]);
        position++;
    }
}

// Определяем метод поиска элемента и вывод индекса

int IndexOf(int[] collection, int find)
{
    int count = collection.Length;
    int index = 0;
    int position = 0;
    while(index < count)
    {
        if(collection[index] == find)
        {
            position = index;
            break;
        }
        index++;
    }
    return position;
}

int[] array = new int[10]; // в массиве по умолчанию 10 элементов

FillArray(array);
PrintArray(array);
Console.WriteLine();

int pos = IndexOf(array, 4);
Console.WriteLine(pos);
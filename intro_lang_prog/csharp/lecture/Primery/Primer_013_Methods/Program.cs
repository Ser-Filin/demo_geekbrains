// Виды методов
// 1-ый вид: ничего не принимают, ничего не возвращают

// void Method1()
// {
//     Console.WriteLine("Автор ...");
// }

// Method1(); // Вызов вышеуказанного метода


// 2-ой вид: ничего не возвращают, но что-то принимают

// void Method2(string msg)
// {
//     Console.WriteLine(msg);
// }

// Method2("Текст сообщения.");

// void Method21(string msg, int count)
// {
//     int i = 0;
//     while (i < count)
//     {
//         i++;
//     }
// }

// Method21(count: 4, msg: "Новый текст"); // Пример вызова с именованными параметрами (можно указывать не по порядку)

// 3-й вид: ничего не принимают, но что-то возвращают

// int Method3()
// {
//     return DateTime.Now.Year;
// }

// int year = Method3();
// Console.WriteLine(year);

// 4-ый вид: что-то принимают и что-то возвращают

// string Method4(int count, string text)
// {
//     int i = 0;
//     string result = string.Empty;

//     while(i < count)
//     {
//         result = result + text;
//         i++;
//     }
//     return result;
// }

// string res = Method4(10, "asdf");
// Console.WriteLine(res);

// Тот же метод, но с циклом «for»

// string Method4(int count, string text)
// {
//     string result = string.Empty;

//     for(int i = 0; i < count; i++)
//     {
//         result = result + text;
//     }

//     return result;
// }

// string res = Method4(10, "asdf");
// Console.WriteLine(res);

// Цикл в цикле на примере таблицы умножения:

// for(int i = 2; i <= 10; i++)
// {
//     for(int j = 2; j <= 10; j++)
//     {
//         Console.WriteLine($"{i} x {j} = {i*j}");
//     }
//     Console.WriteLine("");
// }

// Работа с текстом
// Дан текст. В тексте нужно все пробелы заменить чёрточками,
// маленькие буквы «к» заменить большими «К»,
// а большие «С» заменить маленькими «с».
// Ясна ли задача?

// string text = "— Я думаю, – сказал князь, улыбаясь, – что, "
//             + "если бы вас послали вместо нашего милого Винценгероде, "
//             + "вы бы взяли приступом согласие прусского короля. "
//             + "Вы так красноречивы. Вы дадите мне чаю?";

// Как можно обращаться к символу:
// string s = "qwerty";
//             012...
// s[3] // r

// string Replace(string text, char oldValue, char newValue)
// {
//     string result = string.Empty;

//     int length = text.Length;
//     for (int i = 0; i < length; i++)
//     {
//         if (text[i] == oldValue) result = result + $"{newValue}";
//         else result = result + $"{text[i]}";
//     }

//     return result;
// }

// string newText = Replace(text, ' ', '_');
// Console.WriteLine(newText);
// Console.WriteLine("");
// newText = Replace(newText, 'к', 'К');
// Console.WriteLine(newText);

// Пример сортировки массива

// int[] arr = {1, 5, 4, 3, 2, 6, 7, 1, 1};

// void PrintArray(int[] array)
// {
//     int count = array.Length;

//     for (int i = 0; i < count; i++)
//     {
//         Console.Write($"{array[i]} ");
//     }

//     Console.WriteLine();
// }

// void SelectionSort(int[] array)
// {
//     for (int i = 0; i < array.Length - 1; i++)
//     {
//         int minPosition = i;

//         for(int j = i + 1; j < array.Length; j++)
//         {
//             if(array[j] < array[minPosition]) minPosition = j;
//         }


//         int temporary = array[i];
//         array[i] = array[minPosition];
//         array[minPosition] = temporary;
//     }
// }

// PrintArray(arr);
// SelectionSort(arr);
// PrintArray(arr);

// Задание: попробовать адаптировать метод для
// сортировки массива в обратном порядке
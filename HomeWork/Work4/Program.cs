// Задача 25: Напишите цикл, который принимает на вход два числа (A и B) и возводит число A в натуральную степень B.

// 3, 5 -> 243 (3⁵)

// 2, 4 -> 16

// Console.Write("Введите А: ");
// int a = Convert.ToInt32(Console.ReadLine());

// Console.Write("Введите B: ");
// int b = Convert.ToInt32(Console.ReadLine());

// int Exp(int a, int b)
// {
//     int result = 1;
//     for (int i = 0; i < b; i++)
//     {
//         result = result * a;
//     }
//     return result;
// }

// Console.WriteLine($" {a}, {b} -> {Exp(a,b)}");


// Задача 27: Напишите программу, которая принимает на вход число и выдаёт сумму цифр в числе.

// 452 -> 11

// 82 -> 10

// 9012 -> 12

// Console.Write("Введите Num: ");
// int num = Convert.ToInt32(Console.ReadLine());

// int SummDig(int num)
// {
//     int result = 0;

//     while (num > 0)
//     {

//         result = result + num % 10;
//         num = num / 10;
//     }

//     return result;
// }

// Console.WriteLine($"{num} -> {SummDig(num)}");


// Задача 29: Напишите программу, которая задаёт массив из 8 элементов и выводит их на экран.

// 1, 2, 5, 7, 19 -> [1, 2, 5, 7, 19]

// 6, 1, 33 -> [6, 1, 33]

// int[] CreateArray(int[] array, int minValue, int maxValue)
// {

//     for (int i = 0; i < 8; i++)
//     {
//         //     Console.WriteLine($"Введите {i+1} число");
//         //    array[i] = Convert.ToInt32(Console.ReadLine());
//         array[i] = new Random().Next(minValue, maxValue + 1);
//     }

//     return array;
// }

// void WriteArray(int[] array)
// {
//     for (int i = 0; i < array.Length; i++)
//     {
//              Console.Write($"{array[i]} ");
//     }
// }

// Console.Write("Введите минимальный элемент");
// int minValue = Convert.ToInt32(Console.ReadLine());


// Console.Write("Введите максимальный элемент");
// int maxValue = Convert.ToInt32(Console.ReadLine());


// int[] array = new int[8];

// CreateArray(array, minValue, maxValue);
// WriteArray(CreateArray(array, minValue, maxValue));
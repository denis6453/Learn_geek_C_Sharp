// Задача 34: Задайте массив заполненный случайными положительными трёхзначными числами. Напишите программу, которая покажет количество чётных чисел в массиве.

// [345, 897, 568, 234] -> 2


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
//         Console.Write($"{array[i]} ");
//     }
// }

// void CountInArray(int[] array)
// {
//     int lenght = array.Length;
//     int count = 0;

//     for (int i = 0; i < lenght; i++)
//     {
//         if (array[i] % 2 == 0)
//         {
//             count++;
//         }
//     }
//     Console.WriteLine();
//     Console.WriteLine($"количество -> {count}");
// }

// Console.Write("Введите минимальный элемент");
// int minValue = Convert.ToInt32(Console.ReadLine());


// Console.Write("Введите максимальный элемент");
// int maxValue = Convert.ToInt32(Console.ReadLine());


// int[] array = new int[8];

// CreateArray(array, minValue, maxValue);
// WriteArray(CreateArray(array, minValue, maxValue));

// CountInArray(array);


// Задача 36: Задайте одномерный массив, заполненный случайными числами. Найдите сумму элементов, стоящих на нечётных позициях.

// [3, 7, 23, 12] -> 19

// [-4, -6, 89, 6] -> 0




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
//         Console.Write($"{array[i]} ");
//     }
// }

// void SummInArray(int[] array)
// {
//     int lenght = array.Length;
//     int sum = 0;

//     for (int i = 0; i < lenght; i++)
//     {
//         if (i % 2 != 0)
//         {
//             sum += array[i];
//         }
//     }
//     Console.WriteLine();
//     Console.WriteLine($"сумма -> {sum}");
// }

// Console.Write("Введите минимальный элемент");
// int minValue = Convert.ToInt32(Console.ReadLine());


// Console.Write("Введите максимальный элемент");
// int maxValue = Convert.ToInt32(Console.ReadLine());


// int[] array = new int[8];

// CreateArray(array, minValue, maxValue);
// WriteArray(CreateArray(array, minValue, maxValue));

// SummInArray(array);


// Задача 38: Задайте массив вещественных чисел. Найдите разницу между максимальным и минимальным элементов массива.

// [3 7 22 2 78] -> 76

//array[i] = new Random().NextDouble();

// double[] CreateArray(double[] array, int minValue, int maxValue)
// {

//     for (int i = 0; i < 8; i++)
//     {
//         double digit = 0;
//         digit = new Random().NextDouble();
//         array[i] = new Random().Next(minValue, maxValue + 1);
//         array[i] += digit;
//     }

//     return array;
// }

// void WriteArray(double[] array)
// {
//     for (int i = 0; i < array.Length; i++)
//     {
//         Console.Write($"{array[i]} ");
//     }
// }

// void SummInArray(double[] array)
// {
//     int lenght = array.Length;
//     double max = array[0];
//     double min = array[0];

//     for (int i = 0; i < lenght; i++)
//     {
//         if (array[i] > max)
//         {
//             max = array[i];
//         }
//         else
//         {
//             if (array[i] < min)
//             {
//                 min = array[i];
//             }
//         }
//     }
//     Console.WriteLine();
//     Console.WriteLine($"Разница между max и min -> {max - min}");
// }

// Console.Write("Введите минимальный элемент");
// int minValue = Convert.ToInt32(Console.ReadLine());


// Console.Write("Введите максимальный элемент");
// int maxValue = Convert.ToInt32(Console.ReadLine());


// double[] array = new double[8];

// CreateArray(array, minValue, maxValue);
// WriteArray(CreateArray(array, minValue, maxValue));

// SummInArray(array);
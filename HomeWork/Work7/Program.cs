// Задача 47. Задайте двумерный массив размером m×n, заполненный случайными вещественными числами.

// m = 3, n = 4.

// 0,5 7 -2 -0,2

// 1 -3,3 8 -9,9

// 8 7,8 -7,1 9

// double[,] Create2DRandomArray(int sizeRows, int sizeColumns, int minvalue, int maxvalue)
// {
//     double temp;
//     double [,] array = new double[sizeRows, sizeColumns];
//     for (int i = 0; i < sizeRows; i++)
//     {
//         for (int j = 0; j < sizeColumns; j++)
//         {
//             array[i, j] = new Random().Next(minvalue, maxvalue + 1);
//             temp = new Random().NextDouble();
//             array[i, j] += temp;
//         }
//     }
//     return array;
// }

// void Print2DArray(double [,] array)
// {
//     for (int i = 0; i < array.GetLength(0); i++)
//     {
//         for (int j = 0; j < array.GetLength(1); j++)
//         {
//             Console.Write($"{array[i, j]} " );
//         }
//         Console.WriteLine();
//     }
// }


// Console.WriteLine("Введите размер строк в массиве");
// int sizeColumns = int.Parse(Console.ReadLine());

// Console.WriteLine("Введите размер столбцов в массиве");
// int sizeRows = int.Parse(Console.ReadLine());

// Console.WriteLine("Введите минимальное число в массиве");
// int minvalue = int.Parse(Console.ReadLine());

// Console.WriteLine("Введите максимальное число в массиве");
// int maxvalue = int.Parse(Console.ReadLine());

// double [,] array = Create2DRandomArray(sizeRows, sizeColumns, minvalue, maxvalue);

// Print2DArray(array);





// Задача 50. Напишите программу, которая на вход принимает позиции элемента в двумерном массиве, и возвращает значение этого элемента или же указание, что такого элемента нет.

// Например, задан массив:

// 1 4 7 2

// 5 9 2 3

// 8 4 2 4

// 17 -> такого числа в массиве нет


// double[,] Create2DRandomArray(int sizeRows, int sizeColumns, int minvalue, int maxvalue)
// {
//     double temp;
//     double[,] array = new double[sizeRows, sizeColumns];
//     for (int i = 0; i < sizeRows; i++)
//     {
//         for (int j = 0; j < sizeColumns; j++)
//         {
//             array[i, j] = new Random().Next(minvalue, maxvalue + 1);
//             temp = new Random().NextDouble();
//             array[i, j] += temp;
//         }
//     }
//     return array;
// }

// void Print2DArray(double[,] array)
// {
//     for (int i = 0; i < array.GetLength(0); i++)
//     {
//         for (int j = 0; j < array.GetLength(1); j++)
//         {
//             Console.Write($"{array[i, j]} ");
//         }
//         Console.WriteLine();
//     }
// }

// void GetElement(double[,] array, int row, int col)
// {
//     if (row < array.GetLength(0) && col < array.GetLength(1) && row >= 0 && col >= 0)
//     {
//         Console.WriteLine($"Element :{array[row, col]}");
//     }
//     else Console.WriteLine("Такого элемента нету");
// }


// Console.WriteLine("Введите размер строк в массиве");
// int sizeColumns = int.Parse(Console.ReadLine());

// Console.WriteLine("Введите размер столбцов в массиве");
// int sizeRows = int.Parse(Console.ReadLine());

// Console.WriteLine("Введите минимальное число в массиве");
// int minvalue = int.Parse(Console.ReadLine());

// Console.WriteLine("Введите максимальное число в массиве");
// int maxvalue = int.Parse(Console.ReadLine());

// double[,] array = Create2DRandomArray(sizeRows, sizeColumns, minvalue, maxvalue);

// Print2DArray(array);

// Console.WriteLine("Введите строку элемента");
// int row = int.Parse(Console.ReadLine());

// Console.WriteLine("Введите столбец элемента");
// int columns = int.Parse(Console.ReadLine());




// Задача 52. Задайте двумерный массив из целых чисел. Найдите среднее арифметическое элементов в каждом столбце.

// Например, задан массив:
// 1 4 7 2
// 5 9 2 3
// 8 4 2 4
// Среднее арифметическое каждого столбца: 4,6; 5,6; 3,6; 3.


// double[,] Create2DRandomArray(int sizeRows, int sizeColumns, int minvalue, int maxvalue)
// {
//     double temp;
//     double[,] array = new double[sizeRows, sizeColumns];
//     for (int i = 0; i < sizeRows; i++)
//     {
//         for (int j = 0; j < sizeColumns; j++)
//         {
//             array[i, j] = new Random().Next(minvalue, maxvalue + 1);
//             temp = new Random().NextDouble();
//             array[i, j] += temp;
//         }
//     }
//     return array;
// }

// void Print2DArray(double[,] array)
// {
//     for (int i = 0; i < array.GetLength(0); i++)
//     {
//         for (int j = 0; j < array.GetLength(1); j++)
//         {
//             Console.Write($"{array[i, j]} ");
//         }
//         Console.WriteLine();
//     }
// }

// void FindMiddleElement(double[,] array)
// {
//     double sum = 0;

//     Console.WriteLine("Среднее арифметическое каждого столбца: ");

//     for (int j = 0; j < array.GetLength(1); j++)
//     {
//         for (int i = 0; i < array.GetLength(0); i++)
//         {
//             sum += array[i, j];
//         }
//         Console.Write($"{sum / array.GetLength(0)}; ");
//         sum = 0;
//     }
// }


// Console.WriteLine("Введите размер строк в массиве");
// int sizeColumns = int.Parse(Console.ReadLine());

// Console.WriteLine("Введите размер столбцов в массиве");
// int sizeRows = int.Parse(Console.ReadLine());

// Console.WriteLine("Введите минимальное число в массиве");
// int minvalue = int.Parse(Console.ReadLine());

// Console.WriteLine("Введите максимальное число в массиве");
// int maxvalue = int.Parse(Console.ReadLine());

// double[,] array = Create2DRandomArray(sizeRows, sizeColumns, minvalue, maxvalue);

// Print2DArray(array);

// FindMiddleElement(array);
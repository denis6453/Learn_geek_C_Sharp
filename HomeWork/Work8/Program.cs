

int[,] Create2DArray(int[,] array, int minValue, int maxValue)
{
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            array[i, j] = new Random().Next(minValue, maxValue);
        }
    }
    return array;
}


void Print1DArray(int[] array)
{
    for (int i = 0; i < array.Length; i++)
    {
        Console.Write(array[i] + " ");
    }
    Console.WriteLine("\n");
}


void Print2DArray(int[,] array)
{
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            Console.Write(array[i, j] + " ");
        }
        Console.WriteLine();
    }
    Console.WriteLine();
}

void Print3DArray(int[,,] array)
{
    // 66(0,0,0) 25(0,1,0)
    // 34(1,0,0) 41(1,1,0)
    // 27(0,0,1) 90(0,1,1)
    // 26(1,0,1) 55(1,1,1)
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            for (int k = 0; k < array.GetLength(2); k++)
            {
                Console.Write(array[i, j, k] + $"(({i},{j},{k}) ");
            }
            Console.WriteLine();
        }
        // Console.WriteLine();
    }
    Console.WriteLine();
}






// Задача 54: Задайте двумерный массив. Напишите программу, которая упорядочит по убыванию элементы каждой строки двумерного массива.
// Например, задан массив:
// 1 4 7 2
// 5 9 2 3
// 8 4 2 4
// В итоге получается вот такой массив:
// 7 4 2 1
// 9 5 3 2
// 8 4 4 2

// int[,] SortRowsDesc(int[,] array)
// {
//     int temp = 0;
//     int k = 0;
//     for (int i = 0; i < array.GetLength(0); i++)
//     {
//         for (int sortedSize = 0; sortedSize <= array.GetLength(1) - 1; sortedSize++)
//         {
//             for (k = 0; k <= array.GetLength(1) - 2 - sortedSize; k++)
//             {
//                 if (array[i, k] < array[i, k + 1])
//                 {
//                     temp = array[i, k];
//                     array[i, k] = array[i, k + 1];
//                     array[i, k + 1] = temp;
//                 }
//             }
//         }
//         // Console.WriteLine($"Шаг: {i + 1}");
//         // Print2DArray(array);
//     }
//     return array;
// }


// Console.WriteLine("Введите количество строк в массиве");
// int rows = int.Parse(Console.ReadLine());

// Console.WriteLine("Введите количество столбцов в массиве");
// int columns = int.Parse(Console.ReadLine());

// Console.WriteLine("Введите минимальное число в массиве");
// int minValue = int.Parse(Console.ReadLine());

// Console.WriteLine("Введите максимальное число в массиве");
// int maxValue = int.Parse(Console.ReadLine());

// int[,] array = new int[rows, columns];

// Create2DArray(array, minValue, maxValue);
// Print2DArray(array);
// array = SortRowsDesc(array);
// Print2DArray(array);


// Задача 56: Задайте прямоугольный двумерный массив. Напишите программу, которая будет находить строку с наименьшей суммой элементов.

// Например, задан массив:

// 1 4 7 2

// 5 9 2 3

// 8 4 2 4

// 5 2 6 7

// Программа считает сумму элементов в каждой строке и выдаёт номер строки с наименьшей суммой элементов: 1 строка

// int[] GetSumRows(int[,] array)
// {
//     int[] arraySum = new int[array.GetLength(0)];

//     for (int i = 0; i < array.GetLength(0); i++)
//     {
//         arraySum[i] = 0;
//         for (int j = 0; j < array.GetLength(1); j++)
//         {
//             arraySum[i] += array[i, j];
//         }
//     }
//     return arraySum;
// }

// int FindMinInArray(int[] array)
// {
//     int min = array[0];
//     int minIndex = 0;
//     for (int i = 1; i < array.Length; i++)
//     {
//         if (array[i] < min)
//         {
//             min = array[i];
//             minIndex = i;
//         }
//     }
//     return minIndex + 1;
// }



// Console.WriteLine("Введите количество строк в массиве");
// int rows = int.Parse(Console.ReadLine());

// Console.WriteLine("Введите количество столбцов в массиве");
// int columns = int.Parse(Console.ReadLine());

// Console.WriteLine("Введите минимальное число в массиве");
// int minValue = int.Parse(Console.ReadLine());

// Console.WriteLine("Введите максимальное число в массиве");
// int maxValue = int.Parse(Console.ReadLine());

// int[,] array = new int[rows, columns];

// Create2DArray(array, minValue, maxValue);
// Print2DArray(array);

// int[] arraySum = GetSumRows(array);

// Print1DArray(arraySum);

// Console.WriteLine($"Номер строки с наименьшей суммой: {FindMinInArray(arraySum)}");





// Задача 58: Задайте две матрицы. Напишите программу, которая будет находить произведение двух матриц.
// Например, даны 2 матрицы:
// 2 4 | 3 4
// 3 2 | 3 3
// Результирующая матрица будет:
// 18 20
// 15 18

// int [] SelectRowArray(int[ , ] array, int row)
// {
//     int [] tempArray = new int[array.GetLength(1)];

//         for (int j = 0; j < array.GetLength(1); j++)
//         {
//             tempArray[j] = array[row, j];
//         }
//         return tempArray;    
// }


// int [] SelectColumnArray(int[ , ] array, int column)
// {
//     int [] tempArray = new int[array.GetLength(0)];

//         for (int i = 0; i < array.GetLength(1); i++)
//         {
//             tempArray[i] = array[column, i];
//         }
//         return tempArray;    
// }


// int ScalarMultiple (int [] array1 , int [] array2)
// {
//     int sum = 0;
//     for (int i = 0; i < array1.Length; i++)
//     {
//         sum += array1[i] * array2[i];
//     }
//     return sum;
// }


// void MultipleMatrix (int [,] matrix1, int [,] matrix2)// по сути произведение матриц можно считать поэлементно скалярным произведением нужных строк и столбцов
// {
//     if (matrix1.GetLength(1)!= matrix2.GetLength(0)) //Необходимое и достаточное условие для перемножения матриц
//     {
//         Console.WriteLine("Матрицы не согласованы");
//     }
//     else
//     {
//         int [,] multipleArray = new int [matrix1.GetLength(0), matrix2.GetLength(1)]; // результурующая матрица получается размером (число строк первой матрицы; число столбцов второй матрицы)

//         for (int i = 0; i < matrix1.GetLength(0); i++)
//         {
//             for (int j = 0; j < matrix2.GetLength(1); j++)
//                         {
//                             multipleArray[i, j] = ScalarMultiple(SelectRowArray(matrix1, i), SelectColumnArray(matrix2, j)); //выделяем i строку первой матрицы и j столбец второй матрицы и скалярно перемножаем
//                         }
//         }
//         Console.WriteLine("Результат:");
//         Print2DArray(multipleArray);
//     }
// }

// Console.WriteLine("Введите количество строк в массиве 1");
// int rows = int.Parse(Console.ReadLine());

// Console.WriteLine("Введите количество столбцов в массиве 1");
// int columns = int.Parse(Console.ReadLine());

// Console.WriteLine("Введите минимальное число в массиве 1");
// int minValue = int.Parse(Console.ReadLine());

// Console.WriteLine("Введите максимальное число в массиве 1");
// int maxValue = int.Parse(Console.ReadLine());

// int[,] matrix1 = new int[rows, columns];

// matrix1 = Create2DArray(matrix1, minValue, maxValue);



// Console.WriteLine("Введите количество строк в массиве 2");
// rows = int.Parse(Console.ReadLine());

// Console.WriteLine("Введите количество столбцов в массиве 2");
// columns = int.Parse(Console.ReadLine());

// Console.WriteLine("Введите минимальное число в массиве 2");
// minValue = int.Parse(Console.ReadLine());

// Console.WriteLine("Введите максимальное число в массиве 2");
// maxValue = int.Parse(Console.ReadLine());

// int[,] matrix2 = new int[rows, columns];

// matrix2 = Create2DArray(matrix2, minValue, maxValue);

// Print2DArray(matrix1);

// Print2DArray(matrix2);


// MultipleMatrix(matrix1, matrix2);



// Задача 60. ...Сформируйте трёхмерный массив из неповторяющихся двузначных чисел. Напишите программу, которая будет построчно выводить массив, добавляя индексы каждого элемента.
// Массив размером 2 x 2 x 2
// 66(0,0,0) 25(0,1,0)
// 34(1,0,0) 41(1,1,0)
// 27(0,0,1) 90(0,1,1)
// 26(1,0,1) 55(1,1,1)
// int GenerateUniqueNumber( int [,,] array, int minValue, int maxValue )
// {
//     int number = new Random().Next( minValue, maxValue );
//     for( int i = 0; i < array.GetLength( 0 ); i++ )
//     {
//         for( int j = 0; j < array.GetLength( 1 ); j++ )
//         {
//             for( int k = 0; k < array.GetLength( 2 ); k++ )
//             {
//                 if( array[ i, j, k ] == number )
//                 {
//                     number = GenerateUniqueNumber( array, minValue, maxValue );
//                 }
//             }
//         }
//     }
//     return number;
// }

// int[,,] Create3DUniqueArray(int[,,] array, int minValue, int maxValue)
// {
//     for (int i = 0; i < array.GetLength(0); i++)
//     {
//         for (int j = 0; j < array.GetLength(1); j++)
//         {
//             for (int k = 0; k < array.GetLength(2); k++)
//             {
//                 array[i, j, k] = GenerateUniqueNumber(array, minValue, maxValue);
//             }
//         }
//     }
//     return array;
// }

// Console.WriteLine("Введите количество строк в массиве");
// int rows = int.Parse(Console.ReadLine());

// Console.WriteLine("Введите количество столбцов в массиве");
// int columns = int.Parse(Console.ReadLine());

// Console.WriteLine("Введите количество третьей координаты в массиве");
// int time = int.Parse(Console.ReadLine());

// Console.WriteLine("Введите минимальное число в массиве");
// int minValue = int.Parse(Console.ReadLine());

// Console.WriteLine("Введите максимальное число в массиве");
// int maxValue = int.Parse(Console.ReadLine());

// int[,,] matrix = new int[rows, columns, time];

// Create3DUniqueArray(matrix, minValue, maxValue);

// Print3DArray(matrix);

// Задача 62. Напишите программу, которая заполнит спирально массив 4 на 4.
// Например, на выходе получается вот такой массив:
// 01 02 03 04
// 12 13 14 05
// 11 16 15 06
// 10 09 08 07



// // void FillMatrix(int[,] matrix, int row, int col, int lastValue)
// // {
// //     if (matrix[row, col] == 0)
// //     {
// //         matrix[row, col] = lastValue;
// //         lastValue++;
        
// //         if (col - 1 >= 0)
// //         {
// //             FillMatrix(matrix, row, col - 1, lastValue); // left
// //         }
// //         if (row - 1 >= 0)
// //         {
// //             FillMatrix(matrix, row - 1, col, lastValue); // up
// //         }
// //         if (col + 1 < matrix.GetLength(1))
// //         {
// //             FillMatrix(matrix, row, col + 1, lastValue); // right 
// //         }
// //         if (row + 1 < matrix.GetLength(0))
// //         {
// //             FillMatrix(matrix, row + 1, col, lastValue); // below
// //         }
// //     }
// // }




// // int[,] matrix = new int[5, 5];


// // Print2DArray(matrix);
// // FillMatrix(matrix, 0, 0, 1);
// // Print2DArray(matrix);

// void FillMatrix(int[,] matrix, int value, int row, int col, int size)
// {
//     if (size < 1) // если размер матрицы стал меньше 1, то выходим из рекурсии
//     {
//         matrix[row, col] = value;
//         return;
//     }
//     //заполнеие внешней части матрицы
//     for (int i = col; i <= col + size; i++) // вправо
//     {
//         matrix[row, i] = value;
//         value++;
//     }

//     for (int i = row + 1; i <= row + size; i++) // вниз
//     {
//         matrix[i, col + size] = value;
//         value++;
//     }

//     for (int i = col + size - 1; i >= col; i--) // влево
//     {
//         matrix[row + size, i] = value;
//         value++;
//     }

//     for (int i = row + size - 1; i > row; i--) // вверх
//     {
//         matrix[i, col] = value;
//         value++;
//     }

//     FillMatrix(matrix, value, row + 1, col + 1, size - 2); // рекурсивный вызов для внутренней части матрицы
// }

//     int n = 5; // размер матрицы
//     int[,] matrix = new int[n, n]; // создаем матрицу

//     FillMatrix(matrix, 1, 0, 0, n - 1); // заполняем матрицу по спирали

//     for (int i = 0; i < n; i++)
//     {
//         for (int j = 0; j < n; j++)
//         {
//             Console.Write(matrix[i, j]);
//         }
//         Console.WriteLine();
//     }






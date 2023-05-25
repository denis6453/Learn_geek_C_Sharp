// Задача 41: Пользователь вводит с клавиатуры M чисел. Посчитайте, сколько чисел больше 0 ввёл пользователь.

// 0, 7, 8, -2, -2 -> 2

// 1, -7, 567, 89, 223-> 3

// int[] CreateArray(int[] array)
// {

//     for (int i = 0; i < array.Length; i++)
//     {
//             Console.WriteLine($"Введите {i+1} число");
//            array[i] = Convert.ToInt32(Console.ReadLine());
//         //array[i] = new Random().Next(minValue, maxValue + 1);
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

// int CountNumper (int [] array)
// {
//     int size = array.Length;
//     int count = 0;

//     for (int i = 0; i < size; i++)
//     {
//           if (array[i] > 0)
//           {
//               count++;
//           }
//     }
//     return count;
// }

// Console.WriteLine("Input ArraySize:");

// int arraySize = int.Parse(Console.ReadLine());
// int[] array = new int[arraySize];

// CreateArray(array);
// WriteArray(array);
// Console.WriteLine(CountNumper(array));




// Задача 43: Напишите программу, которая найдёт точку пересечения двух прямых, заданных уравнениями y = k1 * x + b1, y = k2 * x + b2; значения b1, k1, b2 и k2 задаются пользователем.

// b1 = 2, k1 = 5, b2 = 4, k2 = 9 -> (-0,5; -0,5)

//k1 * x + b1 = k2 * x + b2

Console.WriteLine("Input b1");
double b1 = int.Parse(Console.ReadLine());

Console.WriteLine("Input k1");
double k1 = int.Parse(Console.ReadLine());

Console.WriteLine("Input b2");
double b2 = int.Parse(Console.ReadLine());

Console.WriteLine("Input k2");
double k2 = int.Parse(Console.ReadLine());


double FindX(double k1, double b1, double k2, double b2)
{
    
    if (k1 != k2) return (b2 - b1) / (k1 - k2);
    else {
        Console.WriteLine("Прямые параллельны или совпадают");
        return (b2 - b1) / (k1 - k2);
    }
}

double FindY(double k1, double b1, double x)
{
    return k1 * x + b1;
}

double x = FindX(k1, b1, k2, b2);
// Console.WriteLine((b2 - b1) / (k1 - k2));

Console.WriteLine($"b1 = {b1}, k1 = {k1}, b2 = {b2}, k2 = {k2} -> ({x}; {FindY(k1, b1, x)})");
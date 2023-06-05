// Задача 64: Задайте значение N. Напишите программу, которая выведет все натуральные числа в промежутке от N до 1. Выполнить с помощью рекурсии.

// N = 5 -> "5, 4, 3, 2, 1"
// N = 8 -> "8, 7, 6, 5, 4, 3, 2, 1"


// void ListNum(int n)
// {
//     Console.Write(n + " ");
//     if (n > 1)
//     {
//         ListNum(n - 1);
//     }
// }

// Console.Write("Input N: ");

// int n = int.Parse(Console.ReadLine());

// ListNum(n);

// Задача 66: Задайте значения M и N. Напишите программу, которая найдёт сумму натуральных элементов в промежутке от M до N.

// M = 1; N = 15 -> 120
// M = 4; N = 8. -> 30

// int SumNum(int n, int m)
// {
//     if (n > m)
//     {
//         return SumNum(n - 1, m) + n;
//     }
//     else if (n < m)
//     {
//         return SumNum(n, m - 1) + m;
//     }
//     else return n;
// }

// Console.Write("Input N: ");
// int n = int.Parse(Console.ReadLine());

// Console.Write("Input M: ");
// int m = int.Parse(Console.ReadLine());

// Console.WriteLine(SumNum(n, m));


// Задача 68: Напишите программу вычисления функции Аккермана с помощью рекурсии. Даны два неотрицательных числа m и n.
// m = 2, n = 3 -> A(m,n) = 9
// m = 3, n = 2 -> A(m,n) = 29

// функция ack(n, m)
//    если n = 0
//      вернуть m + 1
//    иначе, если m = 0
//      вернуть ack (n - 1, 1)
//    еще
//      вернуть ack(n - 1, ack (n, m - 1))


// long Ack(long n, long m)
// {
//     if (n == 0)
//     {
//         return m + 1;
//     }
//     else if (m == 0)
//     {
//         return Ack(n - 1, 1);
//     }
//     else return Ack(n - 1, Ack(n, m - 1));
// }

// Console.Write(Ack(3,5));
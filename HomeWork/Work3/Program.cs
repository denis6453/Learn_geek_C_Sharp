int UserInput(string message)
{
    Console.Write(message);
    int result = int.Parse(Console.ReadLine());
    return result;
}

// Задача 19 // Напишите программу, которая принимает на вход пятизначное число и проверяет, является ли оно палиндромом.
// 14212 -> нет
// 12821 -> да
// 23432 -> да

// Console.Clear();
// void IsPolindrom(int num)
// {
//     if (num > 9999 && num < 99999)
//     {
//         int currentNum = num;

//         int dig5 = num % 10; num = num / 10;
//         int dig4 = num % 10; num = num / 10;
//         num = num / 10;
//         int dig2 = num % 10; num = num / 10;
//         int dig1 = num % 10; num = num / 10;

//         if (dig1 == dig5 && dig2 == dig4) Console.WriteLine($"{currentNum} -> Да");
//         else Console.WriteLine($"{currentNum} -> Нет");
//     }
//     else Console.WriteLine($"Invalid");
// }

// int num = UserInput("Введите 5-значное число: ");
// IsPolindrom(num);






// Задача 21// Напишите программу, которая принимает на вход координаты двух точек и находит расстояние между ними в 3D пространстве.
// A (3,6,8); B(2, 1, -7), -> 15.84
// // A(7, -5, 0); B(1, -1, 9)-> 11.53
// Console.Clear();
// double Distance (int a1, int a2, int a3, int b1, int b2, int b3)
// {
//     return Math.Round(Math.Sqrt(Math.Pow((a1 - b1), 2) + Math.Pow((a2 - b2), 2) + Math.Pow((a3 - b3), 2)), 2);
// }

// int a1 = UserInput("Input A1: ");
// int a2 = UserInput("Input A2: ");
// int a3 = UserInput("Input A3: ");
// int b1 = UserInput("Input B1: ");
// int b2 = UserInput("Input B2: ");
// int b3 = UserInput("Input B3: ");

// Console.WriteLine($"A ({a1}, {a2}, {a3}); B({b1}, {b2}, {b3}) -> {Distance(a1, a2, a3, b1, b2, b3)}");






// Задача 23// Напишите программу, которая принимает на вход число (N) и выдаёт таблицу кубов чисел от 1 до N.
// 3 -> 1, 8, 27
// 5 -> 1, 8, 27, 64, 125
// Console.Clear();
// void QuadN(int n)
// {
//     int count = 1;
//     Console.Write($"{n} -> {count}");
//     while (count < n)
//     {
//         count++;
//         Console.Write($", {count * count * count}");
//     }

// }
// int n = UserInput("Input N: ");
// QuadN(n);

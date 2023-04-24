// Задача 10: Напишите программу, которая принимает на вход трёхзначное число и на выходе показывает вторую цифру этого числа.

// 456 -> 5
// 782 -> 8
// 918 -> 1

// int SecondDigital (int num)
// {
//    return (num % 100) / 10;
// }

// Console.WriteLine("Input number");
// int num = int.Parse(Console.ReadLine());

// Console.WriteLine($"{num} -> {SecondDigital(num)}");

// Задача 13: Напишите программу, которая выводит третью цифру заданного числа или сообщает, что третьей цифры нет.

// 645 -> 5

// 78 -> третьей цифры нет

// 32679 -> 6

// int ThreeDigital (int num)
// {
//    int [] array  = new int [10];
//    int count = 0;

//    while (num != 0)
//    {
//       num = num / 10;
//       array[count] = num;
//       count++;
//    } 

//    return (array[2] % 100)/10;
// }

// Console.WriteLine("Input number");
// int num = int.Parse(Console.ReadLine());
// int final = ThreeDigital(num);

// if (final != 0) Console.WriteLine($"{num} -> {final}");
// else Console.WriteLine($"{num} -> третьей цифры нету");

// Задача 15: Напишите программу, которая принимает на вход цифру, обозначающую день недели, и проверяет, является ли этот день выходным.

// 6 -> да
// 7 -> да
// 1 -> нет

// string IsWeekend (int day)
// {
//    if (day == 6 || day == 7)
//    {
//       return "Да";
//    }
//    else return "Нет";
// }

// Console.WriteLine("Input number");
// int num = int.Parse(Console.ReadLine());

// Console.WriteLine($"{num} -> {IsWeekend(num)}");
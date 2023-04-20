// Console.WriteLine("Введите переменную");
// string per = "";

// per = Console.ReadLine();

// Console.WriteLine($"Переменная {per}");


// Console.WriteLine("Введите переменную");
// int per = 0;

// per = Convert.ToInt32(Console.ReadLine());

// Console.WriteLine($"Переменная {{per}} тырыпыры");


/////////////////////////////////////////////////////////////////////// Task1 Запросить число и вывести его квадрат
// Console.WriteLine("Введите число, квадрат которого хотите получить");
// int per = 0;

// per = Convert.ToInt32(Console.ReadLine());

// Console.WriteLine($"Квадрат числа {per} = {per * per}");

/////////////////////////////////////////////////////////////////////// Task2 является ли первое число квадратом второго?
// Console.WriteLine("Введите два числа");
// int firstNamber = 0;
// int SecondNamber = 0;

// firstNamber = Convert.ToInt32(Console.ReadLine());
// SecondNamber = Convert.ToInt32(Console.ReadLine());

// if(SecondNamber == firstNamber * firstNamber )
// {
//     Console.WriteLine($"{SecondNamber} это квадрат числа {firstNamber}");    
// }
// else 
// {
//     Console.WriteLine($"{SecondNamber} это не квадрат числа {firstNamber}");
// }

/////////////////////////////////////////////////////////////////////// Task3 написать программу, которая принимает на вход число N, а на выходе мы получаем строчку от -N до N

// Console.WriteLine("Введите N");
// int n = int.Parse(Console.ReadLine());

// int count = n * (-1);

// while (count <= n)
// {
//     Console.Write(count);
//     count++;
// }

///////////////////////////////////////////////////////////////////////Task4 на вход принимаем 3ч значеное число, вывести последнюю цифру данного числа
Console.WriteLine("Введите трёхзначное число");
Console.WriteLine($"последняя цифра это {int.Parse(Console.ReadLine()) % 10}");

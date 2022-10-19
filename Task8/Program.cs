// Задача 8: Напишите программу, которая на вход принимает число (N), а на выходе показывает все чётные числа от 1 до N.

// 5 -> 2, 4
// 8 -> 2, 4, 6, 8

// Console.Write("Введите N: ");
// int N = Convert.ToInt32(Console.ReadLine());
// if (N > 1)
// {
//     Console.Write("Четные числа от 1 до N:");
//     for (int i = 2; i <= N; i += 2)
//     {
//         Console.Write(" " + i);
//     }
// }
// else
// {
//     Console.WriteLine("N меньше  или равно 1");
// }

// Задача 8: Напишите программу, которая на вход принимает число (N), а на выходе показывает все чётные числа от 1 до N.
// Если N < 1, то от N до 1.
//  5 -> 2, 4
//  8 -> 2, 4, 6, 8
// -5 -> -4, -2, 0
// -8 -> -8, -6, -4, -2, 0

Console.Write("Введите N: ");
int N = Convert.ToInt32(Console.ReadLine());
if (N == 1) Console.Write("N равно 1");
if (N > 1)
{
    Console.Write("Четные числа от 1 до N:");
    for (int i = 2; i <= N; i += 2)
    {
        Console.Write($" {i}");
    }
}
else
{
    Console.Write("Четные числа от N до 1:");
    N = N / 2 * 2;
    for (int i = N; i < 1; i += 2)
    {
        Console.Write($" {i}");
    }
}

// Задача 2: Напишите программу, которая на вход принимает два числа и выдаёт, какое число большее, а какое меньшее.

// a = 5; b = 7 -> max = 7
// a = 2 b = 10 -> max = 10
// a = -9 b = -3 -> max = -3

Console.Write("Введите a: ");
var A = Console.ReadLine();
Console.Write("Введите b: ");
var B = Console.ReadLine();
if (int.TryParse(A, out int a) && int.TryParse(B, out int b))
{
    int max = 0;
    if (a > b)
    {
        max = a;
    }
    else
    {
        max = b;
    }
    Console.WriteLine("a = " + a + "; b = " + b + " -> max = " + max);
}
else
{
    Console.WriteLine("Входные данные не являются числами!");
}

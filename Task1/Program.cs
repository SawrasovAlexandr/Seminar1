// 1. Напишите программу, которая на вход принимает два числа и проверяет,
//    является ли первое число квадратом второго.

Console.WriteLine("Введите два числа: ");
double a = Convert.ToDouble(Console.ReadLine());
double b = Convert.ToDouble(Console.ReadLine());
if (a / b == b)
{
    Console.Write("Да");
}
else
{
    Console.Write("Нет");
}
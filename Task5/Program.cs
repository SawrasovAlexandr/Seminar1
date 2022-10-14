// 5. Напишите программу, которая на вход принимает одно число (N), а на выходе показывает все целые числа в промежутке от -N до N.

// 4 -> "-4, -3, -2, -1, 0, 1, 2, 3, 4" 
// 2 -> " -2, -1, 0, 1, 2"

Console.Write("Введите N: ");
int N = Convert.ToInt32(Console.ReadLine());
if (N >= 0)
{
    Console.Write("Целые числа от -N до N:");
    for (int i = -1 * N; i < N; i++)
    {
        Console.Write(" " + i + ",");
    }
    Console.Write(" " + N);
}
else
{
    Console.Write("Целые числа от N до -N:");
    for (int i = N; i < -1 * N; i++)
    {
        Console.Write(" " + i + ",");
    }
    Console.Write(" " + -1 * N);
}
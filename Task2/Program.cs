// Задача 2: Напишите программу, которая на вход принимает два числа и выдаёт, какое число большее, а какое меньшее.

// a = 5; b = 7 -> max = 7
// a = 2 b = 10 -> max = 10
// a = -9 b = -3 -> max = -3

//ЗАМЕТКА!! Пример вывода не соответствует условию задачи, а по сему 
//          буду делать в соответствии с ТЗ, т.е. именно с условием))

Console.Write("Введите a: ");
var A = Console.ReadLine();
Console.Write("Введите b: ");
var B = Console.ReadLine();
if (int.TryParse(A, out int a) && int.TryParse(B, out int b))
{
    if (a == b)
    {
        Console.WriteLine("Введенные числа равны");
    }
    else
    {
        if (a > b)
        {
            Console.WriteLine("a - большее число, b - меньшее число");
        }
        else
        {
            Console.WriteLine("b - большее число, a - меньшее число");
        }
    }
}
else
{
    Console.WriteLine("Входные данные не являются числами!");
}

// 3. Напишите программу, которая будет выдавать название дня недели по заданному номеру.

//     3 -> Среда 
//     5 -> Пятница

Console.WriteLine("Введите номер дня недели: ");
int x = Convert.ToInt16(Console.ReadLine());
if (x <= 7 && x >= 1)
{
    if (x == 1)
    {
        Console.WriteLine("1 -> Понедельник");
    }
    if (x == 2)
    {
        Console.WriteLine("2 -> Вторник");
    }
    if (x == 3)
    {
        Console.WriteLine("3 -> Среда");
    }
    if (x == 4)
    {
        Console.WriteLine("4 -> Четверг");
    }
    if (x == 5)
    {
        Console.WriteLine("5 -> Пятница");
    }
    if (x == 6)
    {
        Console.WriteLine("6 -> Суббота");
    }
    if (x == 7)
    {
        Console.WriteLine("7 -> Воскресенье");
    }
}
else
{
    Console.WriteLine("Введенное число не принадлежит заданному диапазону");
}
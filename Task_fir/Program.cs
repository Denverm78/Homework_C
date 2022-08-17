/*Задача “со звездочкой”: (необязательное) Напишите функцию, которая принимает 
одно число - высоту елочки и рисует ее в консоли звездочками. */

Console.Clear();
Console.Write("Введите высоту елки: ");
int h = int.Parse(Console.ReadLine());
Console.Clear();

for (int i = 0; i <= h; i++)
{
    for (int j = 0; j < i; j++)
    {
        Console.SetCursorPosition(50 - j, i);
        Console.WriteLine("*");
        Console.SetCursorPosition(50 + j, i);
        Console.WriteLine("*");
    }
}



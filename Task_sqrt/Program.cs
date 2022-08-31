/*  Задача со звездочкой:
Написать функцию Sqrt(x) - квадратного корня, которая принимает на вход целочисленное значение x и возвращает целую часть квадратного корня от введенного числа.
4 -> 2
28 -> 5
Нельзя использовать встроенные функции библиотеки Math! */
/*25-1=24
24-3=21
21-5=16
16-7=9
9-9=0*/

int FindSqrt(int number)
{
    int count = 0;
    int oddNumber = 1;
    while (number >= oddNumber)
    {
        number -= oddNumber;
        oddNumber += 2;
        count++;
    }
    return count;
}

Console.Write("Введите число: ");
int num = int.Parse(Console.ReadLine());
Console.Write($"Целая часть квадратного корня от {num} равна {FindSqrt(num)} ");
Console.WriteLine();

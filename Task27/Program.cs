/*Задача 27: Напишите функцию и запустите ее, которая принимает 
на вход число и выдаёт сумму цифр в числе.
452 -> 11
82 -> 10
9012 -> 12*/

Console.Write("Введите число: ");
int number = int.Parse(Console.ReadLine());

int SumNumber(int num)
{
    int res = 0;
    while (num > 0)
    {
        res = res + num % 10;
        num = num / 10;

    }
    return res;
}

Console.WriteLine($"Сумма цифр в числе {number} равна {SumNumber(number)}");

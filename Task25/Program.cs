/*Задача 25: Напишите цикл, который принимает на вход два числа (A и B) и 
возводит число A в натуральную степень B.
3, 5 -> 243 (3⁵)
2, 4 -> 16*/

Console.Write("Введите число A: ");
int numberA = int.Parse(Console.ReadLine());
Console.Write("Введите число B: ");
int numberB = int.Parse(Console.ReadLine());

int Exponent(int A, int B)
{
    int res = A;
    for (int i = 2; i <= B; i++)
    {
        res *= A;
    }
    return res;
}

if (numberB == 0)
{
    Console.WriteLine($"{numberA} в степени {numberB} равно 1");
}
else
{
    Console.WriteLine($"{numberA} в степени {numberB} равно {Exponent(numberA, numberB)}");
}

/*   Задача 66: Задайте значения M и N. 
Напишите программу, которая найдёт сумму натуральных элементов в промежутке от M до N. 
M = 1; N = 15 -> 120
M = 4; N = 8. -> 30  */

int FindSum(int start, int end)
{
    int res = start;
    if (start == end) return res;
    else return res + FindSum(++start, end);
}

Console.Write("Введите начальный элемент, M: ");
int m = int.Parse(Console.ReadLine());
Console.Write("Введите конечный элемент, N: ");
int n = int.Parse(Console.ReadLine());
int sum = FindSum(m, n);
Console.WriteLine($"Сумма натуральных элементов от {m} до {n} равна {sum}");

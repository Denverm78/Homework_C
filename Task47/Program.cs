/* Задача 47. Задайте двумерный массив размером m×n, заполненный случайными вещественными числами.
m = 3, n = 4.
0,5 7 -2 -0,2
1 -3,3 8 -9,9
8 7,8 -7,1 9    */

double[,] GetArray(int sizeX, int sizeY, int minValue, int maxValue)
{
    double[,] res = new double[sizeX, sizeY];
    for (int i = 0; i < sizeX; i++)
    {
        for (int j = 0; j < sizeY; j++)
        {
            res[i, j] = new Random().Next(minValue, maxValue) + new Random().NextDouble();
        }

    }
    return res;
}

void PrintArray(double[,] mass1)
{
    for (int i = 0; i < mass1.GetLength(0); i++)
    {
        for (int j = 0; j < mass1.GetLength(1); j++)
        {
            Console.Write($"{mass1[i, j]:f1} ");
        }
        Console.WriteLine();
    }
}

Console.Write("Введите число строк массива, m: ");
int m = int.Parse(Console.ReadLine());
Console.Write("Введите число столбцов массива, n: ");
int n = int.Parse(Console.ReadLine());
Console.Write("Введите минимальный элемент массива: ");
int minNumber = int.Parse(Console.ReadLine());
Console.Write("Введите максимальный элемент массива: ");
int maxNumber = int.Parse(Console.ReadLine());
double[,] array = GetArray(m, n, minNumber, maxNumber);
PrintArray(array);

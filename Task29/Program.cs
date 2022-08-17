/*Задача 29: Напишите программу, которая задаёт массив из N элементов, 
заполненных случайными числами из [a, b) и выводит их на экран.
5, 0, 20 -> [1, 2, 5, 7, 19]
3, 1, 35 -> [6, 1, 33] */

Console.WriteLine("Введите количество элементов массива: ");
int count = int.Parse(Console.ReadLine());
Console.WriteLine("Введите число а - начало интервала: ");
int numberA = int.Parse(Console.ReadLine());
Console.WriteLine("Введите число b - конец интервала: ");
int numberB = int.Parse(Console.ReadLine());
//numberB+=1;

void RandomArray(int count1, int a, int b)
{
    int[] Array = new int[count1];
    for (int i = 0; i < count1; i++)
    {
        Array[i] = new Random().Next(a, b);
    }
    //for (int i = 0; i < count1; i++)
    //{
        //Console.Write($"{Array[i]} ");

    //}
    Console.WriteLine($"[{String.Join(", ", Array)}]");
    Console.WriteLine();
}

RandomArray(count, numberA, numberB);
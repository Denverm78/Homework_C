/*Задача "со звездочкой": Разобраться с алгоритмом сортировки методом пузырька. 
Реализовать невозрастающую сторировку.
[3, 0, 2, 4, -1] -> [4, 3, 2, 0, -1]
[1,2,2,3,2] -> [3, 2, 2, 2, 1]   */

int[] GetArray(int size, int minValue, int maxValue)
{
    int[] res = new int[size];
    for (int i = 0; i < size; i++)
    {
        res[i] = new Random().Next(minValue, maxValue + 1);
    }
    return res;
}

int[] Convert(int[] mass)
{
    int temp = 0;
    for (int i = 0; i < mass.Length; i++)
    {
        for (int j = i + 1; j < mass.Length; j++)
        {
            if (mass[i] < mass[j])
            {
                temp = mass[i];
                mass[i] = mass[j];
                mass[j] = temp;
            }
        }
    }
    return mass;
}

Console.Write("Введите число элементов массива: ");
int count = int.Parse(Console.ReadLine());
Console.Write("Введите минимальный элемент массива: ");
int minNumber = int.Parse(Console.ReadLine());
Console.Write("Введите максимальный элемент массива: ");
int maxNumber = int.Parse(Console.ReadLine());
int[] array = GetArray(count, minNumber, maxNumber);
Console.WriteLine($"[{String.Join(", ", array)}]");
Console.WriteLine($"[{String.Join(", ", Convert(array))}]");
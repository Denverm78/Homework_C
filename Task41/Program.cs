/* Задача 41: Пользователь вводит с клавиатуры M чисел. 
Посчитайте, сколько чисел больше 0 ввёл пользователь.
0, 7, 8, -2, -2 -> 2
1, -7, 567, 89, 223-> 3  */

int Posit(int col)
{
int count = 0;
for (int i = 0; i < col; i++)
{
    Console.Write($"Введите {i+1} число: ");
    int numberI = int.Parse(Console.ReadLine());
    if (numberI > 0) count++;
}
return count;
}

Console.Write("Введите количество чисел: ");
int number = int.Parse(Console.ReadLine());

Console.WriteLine($"Количество положительных чисел - {Posit(number)}");

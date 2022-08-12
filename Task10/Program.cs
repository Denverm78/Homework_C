/* 
Задача 10. Напишите программу, которая принимает на вход трехзначное число и на выходе
показывает вторую цифру этого числа.
*/
Console.Write("Введите трехзначное число: ");
int number = int.Parse(Console.ReadLine());
int SecondNumber = number / 10 % 10;
Console.WriteLine($"Вторая цифра числа {number} равна {SecondNumber}");

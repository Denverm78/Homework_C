/* 
Задача 15. Напишите программу, которая принимает на вход цифру, обозначающую день недели,
и проверяет, является ли этот день выходным.
*/
Console.Write("Введите цифру, обозначающую день недели (от 1 до 7): ");
int number = int.Parse(Console.ReadLine());
if (number ==6 || number == 7)
{
    Console.WriteLine($"День {number} - выходной");
}
else {
    Console.WriteLine($"День {number} - будний (невыходной)");
}

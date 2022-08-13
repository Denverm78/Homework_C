/*Напишите программу, которая принимает на вход пятизначное число 
и проверяет, является ли оно палиндромом.
*/

Console.Write("Введите пятизначное положительное число: ");
int number = int.Parse(Console.ReadLine());
if (number >= 10000 && number <= 99999)
{
    int number1 = number / 10000;
    int tempnumber = number % 10000;
    int number2 = tempnumber / 1000;    
    tempnumber = number % 100;
    int number4 = tempnumber / 10;    
    int number5 = number % 10;    
    if (number1 == number5 && number2 == number4)
    { 
        Console.WriteLine($"Число {number} является палиндромом");
    }
    else
    {
        Console.WriteLine($"Число {number} не является палиндромом");
    }
} 
else
{
    Console.WriteLine($"Число {number} не является пятизначным положительным числом");
}
/*Напишите программу, которая принимает на вход число (N) 
и выдаёт таблицу кубов чисел от 1 до N
*/
Console.Write("Введите число: ");
int number = int.Parse(Console.ReadLine());
for (int i = 1; i <= number - 1; i++)
{
    Console.Write(Math.Pow(i,3) + ", ");    
}
Console.Write(Math.Pow(number,3));
Console.WriteLine();
 

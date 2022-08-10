/* 
Задача 13. Напишите программу, которая выводит третью цифру заданного числа
или сообщает, что третьей цифры нет.
*/
Console.Write("Введите число: ");
int number = int.Parse(Console.ReadLine());
if (number > 99)
{
    int NumberEnd = number % 1000;
    int Number3 = NumberEnd / 100;
    Console.WriteLine($"В числе {number} третья цифра справа равна {Number3}");
} 
else
{
    Console.WriteLine($"В числе {number} третьей цифры нет");
}

/*Задача 43: Напишите программу, которая найдёт точку пересечения двух прямых, 
заданных уравнениями y = k1 * x + b1, y = k2 * x + b2; значения b1, k1, b2 и k2 задаются пользователем.
b1 = 2, k1 = 5, b2 = 4, k2 = 9 -> (-0,5; -0,5) */
/*     k1 * x + b1 = k2 * x + b2
       k1 * x - k2 * x = b2 - b1
       x * (k1 - k2) = b2 - b1
       x = (b2 - b1) / (k1 - k2)
       y = k1 * x + b1              */

double[] point(double bp1, double kp1, double bp2, double kp2)
{
    double[] res = new double[2];
    res[0] = (bp2 - bp1) / (kp1 - kp2);
    res[1] = kp1 * res[0] + bp1;
    return res;
}

Console.Write("Введите b1: ");
double b1 = double.Parse(Console.ReadLine());
Console.Write("Введите k1: ");
double k1 = double.Parse(Console.ReadLine());
Console.Write("Введите b2: ");
double b2 = double.Parse(Console.ReadLine());
Console.Write("Введите k2: ");
double k2 = double.Parse(Console.ReadLine());
double[] array = point(b1, k1, b2, k2);
Console.WriteLine($"Точка пересечения двух прямых ({array[0]:f1}; {array[1]:f1})");

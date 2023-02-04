// See https://aka.ms/new-console-template for more information
// Console.WriteLine("Hello, World!");

/* СЕМИНАР_6
ЗАДАЧА_43: напишите программу, которая найдет точку пересечения двух прямых, заданных уравнениями 
у=k1*x+b1, y=k2*x+b2, значения b1, k1, b2 и k2 задаются пользователем
b1=2, k1=5, b2=4, k2=9 -> (-0,5;-0,5) */

Console.Clear();
Console.WriteLine("Задайте координаты точек и увидите маГию, подставив в уравнение у=k*x+b мы определим точку пересечения прямых");
Console.Write("k1 = ");
double k1 = Convert.ToDouble(Console.ReadLine());

Console.Write("b1 = ");
double b1 = Convert.ToDouble(Console.ReadLine());

Console.Write("k2 = ");
double k2 = Convert.ToDouble(Console.ReadLine());

Console.Write("b2 = ");
double b2 = Convert.ToDouble(Console.ReadLine());

void Formula(double k1, double k2, double b1, double b2)
{
    if (k1 == k2)
    {
        Console.WriteLine("точки пересечения нет, а система уравнений не вычисляет x и y");
    }
    else
    {
        double x = (b2 - b1) / (k1 - k2);
        double y = k1 * x + b1;

        Console.Write($"точка перечения прямых: x = {x} y = {y}");
    }

}
Formula(k1, k2, b1, b2);




// Напишите программу, которая
// 1. принимает на вход координаты двух точек и
// 2. находит расстояние между ними в 2D пространстве.

// A (3,6); B (2,1) -> 5,09
// A (7,-5); B (1,-1) -> 7,21

Console.WriteLine("Введите координаты точек:");
Console.WriteLine("Координата Х1:");
double x1 = Convert.ToDouble(Console.ReadLine());
Console.WriteLine("Координата Y1:");
double y1 = Convert.ToDouble(Console.ReadLine());
Console.WriteLine("Координата Х2:");
double x2 = Convert.ToDouble(Console.ReadLine());
Console.WriteLine("Координата Y2:");
double y2 = Convert.ToDouble(Console.ReadLine());

double Distance(double x1, double y1, double x2, double y2)
{
    double distance = Math.Sqrt(Math.Pow(x2-x1,2)+Math.Pow(y2-y1,2));
    return distance;
}

double res= Math.Round(Distance(x1, y1, x2, y2), 2, MidpointRounding.ToZero);
Console.WriteLine(res);



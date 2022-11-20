// Напишите программу, которая 
// 1. принимает на вход координаты двух точек и 
// 2. находит расстояние между ними в 3D пространстве.

// A (3,6,8); B (2,1,-7), -> 15.84
// A (7,-5, 0); B (1,-1,9) -> 11.53

Console.WriteLine("Введите координаты точек:");
Console.WriteLine("Координата Х1:");
double x1 = Convert.ToDouble(Console.ReadLine());
Console.WriteLine("Координата Y1:");
double y1 = Convert.ToDouble(Console.ReadLine());
Console.WriteLine("Координата Z1:");
double z1 = Convert.ToDouble(Console.ReadLine());
Console.WriteLine("Координата Х2:");
double x2 = Convert.ToDouble(Console.ReadLine());
Console.WriteLine("Координата Y2:");
double y2 = Convert.ToDouble(Console.ReadLine());
Console.WriteLine("Координата Z2:");
double z2 = Convert.ToDouble(Console.ReadLine());

double Distance(double x1, double y1, double z1, double x2, double y2, double z2)
{
    double distance = Math.Sqrt(Math.Pow(x2 - x1, 2) + Math.Pow(y2 - y1, 2) + Math.Pow(z2 - z1, 2));
    return distance;
}

double res = Math.Round(Distance(x1, y1, z1, x2, y2, z2), 2, MidpointRounding.ToZero);
Console.WriteLine(res);
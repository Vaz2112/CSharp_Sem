// Напишите программу, которая 
// 1. найдёт точку пересечения двух прямых, 
// заданных уравнениями y = k1 * x + b1, y = k2 * x + b2;
// 2. значения b1, k1, b2 и k2 задаются пользователем.

// b1 = 2, k1 = 5, b2 = 4, k2 = 9 -> (-0,5; -0,5)

Console.WriteLine("Введите значение b1");
double b1 = Convert.ToDouble(Console.ReadLine());
Console.WriteLine("Введите значение k1");
double k1 = Convert.ToDouble(Console.ReadLine());
Console.WriteLine("Введите значение b2");
double b2 = Convert.ToDouble(Console.ReadLine());
Console.WriteLine("Введите значение k2");
double k2 = Convert.ToDouble(Console.ReadLine());

double[] Intersection(double vb1, double vk1, double vb2, double vk2)
{
    double[] pointXY = new double[2];
    if (vb1 == vb2) //без этой проверки иногда выдает координату х = "-0"
    {
        pointXY[0] = 0;
        pointXY[1] = vb1;
    }
    else pointXY[0] = Math.Round((vb2 - vb1) / (vk1 - vk2), 1);
    pointXY[1] = Math.Round(vk1 * pointXY[0] + vb1, 1);
    return pointXY;
}

void PrintArray(double[] array)
{
    Console.Write("(");
    for (int i = 0; i < array.Length; i++)
    {
        if (i < array.Length - 1) Console.Write($"{array[i]}; ");
        else Console.Write($"{array[i]}");
    }
    Console.WriteLine(")");
}

if (k1 == k2) Console.WriteLine("Эти прямые параллельны, они не пересекутся никогда!");
else
{
    double[] intersection = Intersection(b1, k1, b2, k2);
    Console.WriteLine($"Точка пересечения прямых y={k1}*x+{b1} и y={k2}*x+{b2}");
    PrintArray(intersection);
}
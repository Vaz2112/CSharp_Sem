// Напишите программу, которая 
// 1.принимает на вход координаты точки (X и Y), причём 
// 2. X ≠ 0 и Y ≠ 0 и
// 3. выдаёт номер четверти плоскости, в которой находится эта точка.

Console.WriteLine("Введите координаты точек:");
Console.Write("Х:");
int x = Convert.ToInt32(Console.ReadLine());
Console.Write("Y:");
int y = Convert.ToInt32(Console.ReadLine());

int Quarter(int xc, int yc)
{
    if(xc>0 && yc>0) return 1;
    if(xc<0 && yc>0) return 2;
    if(xc<0 && yc<0) return 3;
    if(xc>0 && yc<0) return 4;
    return 0;
}

int quater = Quarter(x, y);
string result = quater > 0
         ? $"Указанные коодинаты соответсвуют четверти -> {quater}"
         : "Введены некорректные данные";
Console.WriteLine(result);
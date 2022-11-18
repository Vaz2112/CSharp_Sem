// Напишите программу, которая 
// 1. по заданному номеру четверти, показывает диапазон возможных координат точек в этой четверти (x и y).

Console.WriteLine("Введите номер четверти:");
int quat = Convert.ToInt32(Console.ReadLine());

string Quarter(int xc)
{
    if (xc == 1) return "x>0, y>0";
    if (xc == 2) return "x<0, y>0";
    if (xc == 3) return "x<0, y<0";
    if (xc == 4) return "x>0, y<0";
    return "0";
}

string quate = Quarter(quat);
string result = quat > 0 && quat < 5
         ? $"Диапазон возможных координат точек в этой четверти -> {quate}"
         : "Введены некорректные данные";
Console.WriteLine(result);
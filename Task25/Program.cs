// Напишите цикл, который 
// 1.принимает на вход два числа (A и B) и 
// 2.возводит число A в натуральную степень B.

// 3, 5 -> 243
// 2, 4 -> 16

Console.WriteLine("Введите любое число, которое нужно возвести в степень: ");
double number = Convert.ToDouble(Console.ReadLine());

Console.WriteLine("Введите степень (натуральное число): ");
int degree = Convert.ToInt32(Console.ReadLine());

double Exponentiation(double num, int degr)
{
    double res = num;
    for(int i=1; i<degr; i++)
    {
        res=res*num;
    }
    return res;
}

if (degree >0)
{
double exponentiation= Exponentiation(number, degree);
Console.WriteLine($"Число {number} в степени {degree} = {exponentiation}");
}
else Console.WriteLine("Введите натуральную степень!");
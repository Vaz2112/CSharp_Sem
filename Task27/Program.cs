// Напишите программу, которая 
// 1.принимает на вход число и 
// 2.выдаёт сумму цифр в числе.

// 452 -> 11
// 82 -> 10
// 9012 -> 12

Console.WriteLine("Введите целое число: ");
int number = Convert.ToInt32(Console.ReadLine());

int SumDigits(int num)
{
    int sum = 0;
    num = Math.Abs(num);
    while (num > 0)
    {
        sum = sum + num % 10;
        num = num / 10;
    }
    return sum;
}

int res = SumDigits(number);
Console.WriteLine($"Сумма цифр числа {number} равна {res}");
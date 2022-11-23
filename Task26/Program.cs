// 1. принимает на вход число
// 2. выдает количество цифр в числе

// 456 -> 3
// 78 -> 2
// 89126 -> 5

Console.WriteLine("Введите целое число: ");
int number = Convert.ToInt32(Console.ReadLine());

int CountDigits(int num)
{
    int count = 0;
    //num = Math.Abs(num);
    while (num != 0)
    {
        num = num / 10;
        count++;
    }
    return count == 0 ? 1 : count;
}

int countDigits = CountDigits(number);
Console.WriteLine($"Количество цифр в числе {number} = {countDigits}");
// 1. принимает на вход число А
// 2. выдает сумму чисел от 1 до А

// 7 -> 28
// 4 -> 10
// 8 -> 36

Console.WriteLine("Введите натуральное число: ");
int number = Convert.ToInt32(Console.ReadLine());

int SumNumbers(int num)
{
    int sum =0;
    for(int i=1; i<=num; i++)
    {
        sum+=i;
    }
    return sum;
}

if (number >0)
{
int sumNumbers= SumNumbers(number);
Console.WriteLine($"Сумма чисел от 1 до {number} = {sumNumbers}");
}
else Console.WriteLine("Введите натуральное число!");
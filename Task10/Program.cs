// Напишите программу, которая
// 1. принимает на вход трёхзначное число и 
// 2. на выходе показывает вторую цифру этого числа.
// Выполнить с помощью числовых операций (целочисленное деление, остаток от деления).

// 456 -> 5
// 782 -> 8
// 918 -> 1

Console.WriteLine("Введите трехзначное число:");
int number = Convert.ToInt32(Console.ReadLine());

int SecondDigit(int num)
{
    return (num/10)%10;
}

if(number<100 || number>999) Console.WriteLine("Ошибка ввода!");
else 
{
    int secondDigit=SecondDigit(number);
    Console.WriteLine($"Вторая цифра {number} -> {secondDigit}");
}
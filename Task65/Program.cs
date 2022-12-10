/* Задача 65: Задайте значения M и N. Напишите программу, которая
выведет все натуральные числа в промежутке от M до N.
M = 1; N = 5 -> "1, 2, 3, 4, 5"
M = 4; N = 8 -> "4, 6, 7, 8" */

Console.WriteLine("Введите два числа:");
Console.Write("Введите число M: ");
int m = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите число N: ");
int n = Convert.ToInt32(Console.ReadLine());

NaturalNumbersFromMToN(m, n);

void NaturalNumbersFromMToN(int num1, int num2)
{
    if (num1 > num2)
    {
        Console.Write($"{num1} ");
        NaturalNumbersFromMToN(num1 - 1, num2);
    }
    else if (num1 < num2)
    {
        Console.Write($"{num1} ");
        NaturalNumbersFromMToN(num1 + 1, num2);
    }
    else Console.Write($"{num1} ");
}
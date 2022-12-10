/* Задача 66: Задайте значения M и N.
Напишите программу, которая
найдёт сумму натуральных элементов в промежутке от M до N.

M = 1; N = 15 -> 120
M = 4; N = 8. -> 30 */

Console.WriteLine("Введите два числа:");
Console.Write("Введите число M: ");
int m = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите число N: ");
int n = Convert.ToInt32(Console.ReadLine());

int SumNaturalNumbersFromMToN(int num1, int num2)
{
    if (num1 == num2) return num1;
    else
        return num1 + SumNaturalNumbersFromMToN(num1 - 1, num2);
}

int sumNumbers = 0;
if (m > n)
    sumNumbers = SumNaturalNumbersFromMToN(m, n);
else
    sumNumbers = SumNaturalNumbersFromMToN(n, m);

Console.WriteLine($"Cумма элементов в промежутке от {m} до {n} = {sumNumbers} ");
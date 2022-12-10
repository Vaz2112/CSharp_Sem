/* Задача 69: Напишите программу, которая на вход принимает два числа A и B, и
возводит число А в целую степень B с помощью рекурсии.
A = 3; B = 5 -> 243 (3⁵)
A = 2; B = 3 -> 8 */

Console.Write("Введите число M: ");
int m = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите степень N: ");
int n = Convert.ToInt32(Console.ReadLine());

int ExponentiationNumber(int numM, int numN)
{
    if (numN == 0) return 1;
    return numM * ExponentiationNumber(numM, numN - 1);
}

int res = ExponentiationNumber(m, n);
Console.WriteLine($"Число {m} в степени {n} = {res}");
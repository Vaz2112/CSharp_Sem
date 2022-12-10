/* Задача 68: Напишите программу вычисления функции Аккермана с помощью рекурсии.
Даны два неотрицательных числа m и n.
m = 2, n = 3 -> A(m,n) = 9
m = 3, n = 2 -> A(m,n) = 29 */

Console.WriteLine("Для вычисления функции Аккермана введите два неотрицателных числа:");
Console.Write("Введите число m: ");
int m = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите число n: ");
int n = Convert.ToInt32(Console.ReadLine());

int AckermanFunctionRecursive(int m, int n)
{
    if (m == 0)
        return n + 1;
    else if (n == 0)
        return AckermanFunctionRecursive(m - 1, 1);
    else
        return (AckermanFunctionRecursive(m - 1, AckermanFunctionRecursive(m, n - 1)));
}

if (m >= 0 && n >= 0)
{
    int resAck = AckermanFunctionRecursive(m, n);
    Console.WriteLine();
    Console.WriteLine($"Функция Аккермана для чисел {m} и {n} = {resAck}");
}
else
{
    Console.WriteLine();
    Console.WriteLine("Введены некорректные данные!");
}
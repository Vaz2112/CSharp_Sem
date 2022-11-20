// Напишите программу, которая 
// 1. принимает на вход число (N) и 
// 2. выдаёт таблицу кубов чисел от 1 до N.

// 5 ->
// 1 | 1
// 2 | 8
// 3 | 27
// 4 | 64
// 5 | 125

Console.WriteLine("Введите число N: ");
int number = Convert.ToInt32(Console.ReadLine());

void Quad(int num)
{
    Console.Write($"{num} {Math.Pow(num, 3)}");
    Console.WriteLine();
}

if (number <= 0)
{
    Console.WriteLine("Введены некорректные данные");
}
else
{
    int count = 1;
    while (count <= number)
    {
        Quad(count);
        count++;
    }
}
// Напишите программу, которая
// 1. принимает на вход число (N) и 
// 2. выдаёт таблицу квадратов чисел от 1 до N.

Console.WriteLine("Введите число N: ");
int number = Convert.ToInt32(Console.ReadLine());

void Quad(int num)
{
    Console.Write(num + " " + num * num);
    Console.WriteLine();
}
int count = 1;
int num = Math.Abs(number);
while (count <= num)
{
    Quad(count);
    count++;
}
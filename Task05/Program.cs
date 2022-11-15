// Напишите программу, которая 
// 1. на вход принимает одно число (N), а 
// 2. на выходе показывает все целые числа в промежутке от -N до N.

// 4 -> "-4, -3, -2, -1, 0, 1, 2, 3, 4"
// 2 -> " -2, -1, 0, 1, 2"

Console.WriteLine("Введите целое число: ");
int number = Convert.ToInt32(Console.ReadLine());
int count = -1*number;
while (count<=number)
{
if(count!=number) Console.Write(count + ", ");
else Console.Write(count);
count++;
}
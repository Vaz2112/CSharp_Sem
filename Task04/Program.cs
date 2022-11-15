// 1. Принимаем на вход 3 числа
// 2. Выдаем максимальное из них

Console.WriteLine("Введите первое целое число: ");
int num1 = Convert.ToInt32(Console.ReadLine());

Console.WriteLine("Введите второе целое число: ");
int num2 = Convert.ToInt32(Console.ReadLine());

Console.WriteLine("Введите третье целое число: ");
int num3 = Convert.ToInt32(Console.ReadLine());

int max = num1;

if (max < num2)  max = num2;
if (max < num3)  max = num3;

Console.WriteLine($"Максимальное число {max}");
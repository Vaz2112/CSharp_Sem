//Преобразование десятичного числа в двоичное использую рекурсию

Console.WriteLine("Введите десятичное число: ");
int number = Convert.ToInt32(Console.ReadLine());

DecimalToBinary(number);

void DecimalToBinary(int num)
{
    if (num > 0)
    {
        DecimalToBinary(num/2);
        Console.Write($"{num%2}");
    }
}
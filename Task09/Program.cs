// 1. Выводит случайное число из отрезка [10, 99]
// 2. Показывает наибольшую цифру числа

// 78 -> 8
// 12 -> 2
// 85 -> 8

int number = new Random().Next(10, 100);
Console.WriteLine($"Cлучайное число из отрезка [10, 99] --> {number}");

/* int firstDigit = number / 10;
int secondDigit = number % 10;

if (firstDigit>secondDigit) Console.WriteLine($"Наибольшая цифра числа --> {firstDigit}");
else Console.WriteLine($"Наибольшая цифра числа --> {secondDigit}"); */

//Реализация метода

int MaxDigit(int num)
{
    int firstDigit = num / 10;
    int secondDigit = num % 10;

    if (firstDigit>secondDigit) return firstDigit;
    return secondDigit;
}

int maxDigit = MaxDigit(number);
Console.WriteLine($"Наибольшая цифра числа --> {maxDigit}");
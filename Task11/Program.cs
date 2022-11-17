// 1. Выводит случайное трехзначное число
// 2. Удаляет вторую цифру этого числа

// 456 -> 46
// 782 -> 72
// 918 -> 98

int number = new Random().Next(100, 1000);
Console.WriteLine($"Cлучайное трехзначное число --> {number}");

int DelSecondDigit(int num)
{
    int firstDigit = num / 100;
    int thirdDigit = num % 10;

    int result = firstDigit * 10 + thirdDigit;
    return result;
}

int res=DelSecondDigit(number);
Console.WriteLine($"Искомое число --> {res}");
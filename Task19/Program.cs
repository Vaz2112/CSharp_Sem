// Напишите программу, которая 
// 1. принимает на вход пятизначное число и 
// 2. проверяет, является ли оно палиндромом.
// Выполнить с помощью числовых операций (целочисленное деление, остаток от деления).

// 14212 -> нет
// 12821 -> да
// 23432 -> да

Console.WriteLine("Вветиде пятизначное число");
int number = Convert.ToInt32(Console.ReadLine());

bool Palindrome(int num)
{
    int reversNum = num % 10 * 10000 + (num / 10) % 10 * 1000 + (num / 100) % 10 * 100 + (num / 1000) % 10 * 10 + num / 10000;
    return reversNum == num;
}

int numAbs = Math.Abs(number);
if (numAbs > 99999 || numAbs < 10000)
    Console.WriteLine("Вы ввели не пятизначное число!");
else
{
    bool palindrom = Palindrome(numAbs);
    string result = palindrom ? "Полиндром" : "Не полиндром";
    Console.WriteLine($"{number} -> {result}");
}
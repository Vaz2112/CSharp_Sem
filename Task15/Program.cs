// Напишите программу, которая 
// 1. принимает на вход цифру, обозначающую день недели, и 
// 2. проверяет, является ли этот день выходным.

// 6 -> да
// 7 -> да
// 1 -> нет

Console.WriteLine("Введите номер дня недели:");
int number = Convert.ToInt32(Console.ReadLine());

bool Weekend(int day)
{
    return day == 6 || day == 7;
}

if (number < 1 || number > 7) Console.WriteLine("Дня недели с таким номером не существует!");
else
{
    bool weekend = Weekend(number);
    Console.WriteLine(weekend ? "Да" : "Нет");
}
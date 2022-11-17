// 1. Принимаем на вход два числа
// 2. Проверяем, является ли одно кавадратом другого

// 5, 25  -> да
// -4, 16 -> да
// 25, 5  -> да
// 8, 9   -> нет

Console.Write("Введите первое число: ");
int number1 = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите второе число: ");
int number2 = Convert.ToInt32(Console.ReadLine());

bool IsSquare(int num1, int num2)
{
    return num1 * num1 == num2 || num2 * num2 == num1;
}

bool res = IsSquare(number1, number2);
Console.WriteLine(res ? "Да" : "Нет");
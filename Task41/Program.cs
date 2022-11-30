// Пользователь 
// 1.вводит с клавиатуры M чисел. 
// 2. Посчитайте, сколько чисел больше 0 ввёл пользователь.

// 0, 7, 8, -2, -2 -> 2
// -1, -7, 567, 89, 223-> 3

int[] InputNumbers()
{
    Console.WriteLine("Сколько чисел Вы хотите ввести?");
    int num = Convert.ToInt32(Console.ReadLine());

    int[] n = new int[num];

    for (int i = 0; i < num; i++)
    {
        Console.WriteLine($"Введите число {i + 1}");
        n[i] = Convert.ToInt32(Console.ReadLine());
    }
    return n;
}

int CountPositiveNumbers(int[] array)
{
    int count = 0;
    for (int i = 0; i < array.Length; i++)
    {
        if (array[i] > 0) count++;
    }
    return count;
}

int[] numbers = InputNumbers();

int countPositiveNumbers = CountPositiveNumbers(numbers);

Console.WriteLine($"Количество чисел больше нуля = {countPositiveNumbers}");
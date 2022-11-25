// Напишите программу, которая 
// 1.задаёт массив из 8 элементов и 
// 2.выводит их на экран.

// 1, 2, 5, 7, 19, 6, 1, 33 -> [1, 2, 5, 7, 19, 6, 1, 33]

int[] array = new int[8];

Console.WriteLine("Введите целое число - нижнюю границу диапазона случайных чисел: ");
int min = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите целое число - верхнюю границу диапазона случайных чисел: ");
int max = Convert.ToInt32(Console.ReadLine());

void FillArray(int[] arr, int minR, int maxR)
{
    Random rnd = new Random();
    for (int i = 0; i < arr.Length; i++)
    {
        arr[i] = rnd.Next(minR, maxR + 1);
    }
}

void PrintArray(int[] arr)
{
    Console.Write("[");
    for (int i = 0; i < arr.Length - 1; i++)
    {
        Console.Write(arr[i] + ", ");
    }
    Console.Write($"{arr[arr.Length - 1]}]");
}

if (min <= max)
{
    FillArray(array, min, max);
    PrintArray(array);
}
else
{
    Console.WriteLine("Неверный диапазон!");
}
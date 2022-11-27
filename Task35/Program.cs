// 1. Задайте одномерный массив из 123 случайных чисел.
// 2.Найдите количество элементов массива,
//  значения которых лежат в отрезке [10,99].

// Пример для массива из 5, а не 123 элементов. В своём решении сделайте для 123

// [5, 18, 123, 6, 2] -> 1
// [1, 2, 3, 6, 2] -> 0
// [10, 11, 12, 13, 14] -> 5

int[] CreateArrayRndInt(int size, int min, int max)
{
    int[] array = new int[size];
    Random rnd = new Random();
    for (int i = 0; i < array.Length; i++)
    {
        array[i] = rnd.Next(min, max + 1);
    }
    return array;
}

void PrintArray(int[] array)
{
    Console.Write("[");
    for (int i = 0; i < array.Length; i++)
    {
        if (i < array.Length - 1) Console.Write($"{array[i]}, ");
        else Console.Write($"{array[i]}");
    }
    Console.WriteLine("]");
}

int FindNumQuantity (int[] array)
{
    int sum=0;
    for (int i = 0; i < array.Length; i++)
    {
        if(array[i]>9&&array[i]<100)
           sum++;
    }
    return sum;
}

int[] arr = CreateArrayRndInt(123, 1, 300);

PrintArray(arr);
int result = FindNumQuantity (arr);
Console.WriteLine($"количество элементов массива, значения которых лежат в отрезке [10,99] -> {result}");


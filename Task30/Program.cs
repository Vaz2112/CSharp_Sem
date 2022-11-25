// 1.задаёт массив из 8 элементов из 0 и 1 
// 2.выводит их на экран.

int[] array = new int[8];

// int[] FillArray(int[] arr)
// {
//     for (int i = 0; i < arr.Length; i++)
//     {
//         arr[i] = new Random().Next(0, 2);
//     }
//     return arr;
// }

void FillArray(int[] arr)
{
    Random rnd = new Random();
    for (int i = 0; i < arr.Length; i++)
    {
        arr[i] = rnd.Next(0, 2);
    }
}

void PrintArray(int[] arr)
{
    Console.Write("[");
    for (int i = 0; i < arr.Length-1; i++)
    {
        Console.Write(arr[i]+", ");
    }
    Console.Write($"{arr[arr.Length-1]}]");
}

//int[] resArray = FillArray(array);
//PrintArray(resArray);

FillArray(array);
PrintArray(array);
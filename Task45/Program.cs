/* Напишите программу, которая будет создавать
копию заданного массива с помощью поэлементного
копирования. */

int[] CopyArray(int[] massive)
{
    int[] newArray = new int[massive.Length];
    for (int i = 0; i < massive.Length; i++)
    {
        newArray[i] = massive[i];
    }
    return newArray;
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

int[] arr = CreateArrayRndInt(10, 1, 10);
int[] newarr = CopyArray(arr);
newarr[0]=-1;
PrintArray(arr);
PrintArray(newarr);

/* Напишите программу, которая будет преобразовывать
десятичное число в двоичное.

45 -> 101101
3 -> 11
2 -> 10 */

Console.WriteLine("Вветиде десятичное число");
int num = Convert.ToInt32(Console.ReadLine());

int[] DexToBin(int n)
{
    int count = 0;
    while (n > 0)
    {
        n = n / 2;
        count++;
    }

    int[] array = new int[count];

    for (int i = 0; i < count; i++)
    {
        array[count - 1 - i] = num % 2;
        num = num / 2;
    }
    return array;
}

void PrintArray(int[] array)
{
    for (int i = 0; i < array.Length; i++)
    {
        Console.Write(array[i]);
    }
}

int[] arr = DexToBin(num);
PrintArray(arr);

/* Задача 57: Составить частотный словарь элементов
двумерного массива. Частотный словарь содержит
информацию о том, сколько раз встречается элемент
входных данных. */

int[,] CreateMatrixRndInt(int rows, int columns, int min, int max)
{
    int[,] matrix = new int[rows, columns];
    Random rnd = new Random();

    for (int i = 0; i < matrix.GetLength(0); i++)
    {
        for (int j = 0; j < matrix.GetLength(1); j++)
        {
            matrix[i, j] = rnd.Next(min, max + 1);
        }
    }
    return matrix;
}

void PrintMatrix(int[,] matrix)
{
    for (int i = 0; i < matrix.GetLength(0); i++)
    {
        Console.Write("|");
        for (int j = 0; j < matrix.GetLength(1); j++)
        {
            if (j < matrix.GetLength(1) - 1) Console.Write($"{matrix[i, j],4}, ");
            else Console.Write($"{matrix[i, j],4} ");
        }
        Console.WriteLine("|");
    }
}

int[] ReverceMatrixToArray(int[,] matrix)
{
    int y = 0;
    int[] arr = new int[matrix.GetLength(0) * matrix.GetLength(1)];
    for (int i = 0; i < matrix.GetLength(0); i++)
    {
        for (int j = 0; j < matrix.GetLength(1); j++)
        {
            arr[y] = matrix[i, j];
            y++;
        }
    }
    return arr;
}

void PrintCountNumbers(int[] arr)
{
    int count = 1;
    int num = arr[0];
    for (int i = 1; i < arr.Length; i++)
    {
        if (arr[i] == num) count++;
        else
        {
            Console.WriteLine($"{num} встречается {count} раз");
            num = arr[i];
            count = 1;
        }
    }
    Console.WriteLine($"{num} встречается {count} раз");
}



int[,] array2D = CreateMatrixRndInt(3, 3, 0, 10);
PrintMatrix(array2D);
Console.WriteLine();

int[] array = ReverceMatrixToArray(array2D);
Array.Sort(array);
PrintCountNumbers(array);
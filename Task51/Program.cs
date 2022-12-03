/* Задайте двумерный массив. Найдите сумму
элементов, находящихся на главной диагонали (с индексами
(0,0); (1;1) и т.д. */

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

int SumMainDiagonal(int[,] matrix)
{
    int sum = 0;
    int minLenght = 0;

    if (matrix.GetLength(0) < matrix.GetLength(1))
    {
        minLenght = matrix.GetLength(0);
    }
    else
    {
        minLenght = matrix.GetLength(1);
    }
    {
        for (int i = 0; i < minLenght; i++)
        {
            sum = sum + matrix[i, i];
        }
    }
    return sum;
}

int[,] array2D = CreateMatrixRndInt(3, 4, -10, 10);
PrintMatrix(array2D);
int sumMainDiagonal = SumMainDiagonal(array2D);
Console.WriteLine($"Сумма элементов главной диагонали = {sumMainDiagonal}");
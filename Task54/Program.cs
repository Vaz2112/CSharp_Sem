/* Задача 54: Задайте двумерный массив. Напишите программу, 
которая упорядочит по убыванию элементы каждой строки двумерного массива.

Например, задан массив:
1 4 7 2
5 9 2 3
8 4 2 4

В итоге получается вот такой массив:
7 4 2 1
9 5 3 2
8 4 4 2 */

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

void DecreasingRowsMatrix(int[,] matrix)
{
    int maxIJ = 0;
    int indexJ = 0;

    for (int i = 0; i < matrix.GetLength(0); i++)
    {
        for (int k = 0; k < matrix.GetLength(1); k++)
        {
            maxIJ = matrix[i, k];
            indexJ = k;

            for (int j = k + 1; j < matrix.GetLength(1); j++)
            {
                if (maxIJ < matrix[i, j])
                {
                    maxIJ = matrix[i, j];
                    indexJ = j;
                }
            }
            matrix[i, indexJ] = matrix[i, k];
            matrix[i, k] = maxIJ;
        }
    }
}

int[,] array2D = CreateMatrixRndInt(5, 3, 1, 99);
PrintMatrix(array2D);
Console.WriteLine();

DecreasingRowsMatrix(array2D);
PrintMatrix(array2D);
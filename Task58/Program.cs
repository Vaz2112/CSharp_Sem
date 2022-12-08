/* Задача 58: Задайте две матрицы. Напишите программу,
которая будет находить произведение двух матриц.

Например, даны 2 матрицы:
2 4 | 3 4
3 2 | 3 3

Результирующая матрица будет:
18 20
15 18 */

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

void PrintTwoMatrix(int[,] matrix1, int[,] matrix2)
{
    int minLengthRow = 0;
    if (matrix1.GetLength(0) > matrix2.GetLength(0))
        minLengthRow = matrix2.GetLength(0);
    else
        minLengthRow = matrix1.GetLength(0);

    for (int i = 0; i < minLengthRow; i++)
    {
        Console.Write("|");
        for (int j = 0; j < matrix1.GetLength(1); j++)
        {
            if (j < matrix1.GetLength(1) - 1) Console.Write($"{matrix1[i, j],4}, ");
            else Console.Write($"{matrix1[i, j],4} ");
        }
        Console.Write("|");
        Console.Write($"    ");

        Console.Write("|");
        for (int j = 0; j < matrix2.GetLength(1); j++)
        {
            if (j < matrix2.GetLength(1) - 1) Console.Write($"{matrix2[i, j],4}, ");
            else Console.Write($"{matrix2[i, j],4} ");
        }
        Console.WriteLine("|");
    }

    if (matrix1.GetLength(0) > matrix2.GetLength(0))
    {
        for (int i = minLengthRow; i < matrix1.GetLength(0); i++)
        {
            Console.Write("|");
            for (int j = 0; j < matrix1.GetLength(1); j++)
            {
                if (j < matrix1.GetLength(1) - 1) Console.Write($"{matrix1[i, j],4}, ");
                else Console.Write($"{matrix1[i, j],4} ");
            }
            Console.WriteLine("|");
        }
    }
    else
    {
        for (int i = minLengthRow; i < matrix2.GetLength(0); i++)
        {
            Console.Write("|".PadLeft(matrix1.GetLength(1) * 6 + 6));
            for (int j = 0; j < matrix2.GetLength(1); j++)
            {
                if (j < matrix2.GetLength(1) - 1) Console.Write($"{matrix2[i, j],4}, ");
                else Console.Write($"{matrix2[i, j],4} ");
            }
            Console.WriteLine("|");
        }
    }

}

int[,] MatrixMultiplication(int[,] matrix1, int[,] matrix2)
{
    int[,] multiArray = new int[matrix1.GetLength(0), matrix2.GetLength(1)];
    int m = 0;
    int n = 0;

    for (int i = 0; i < matrix1.GetLength(0); i++)
    {
        for (int j = 0; j < matrix2.GetLength(1); j++)
        {
            for (int k = 0; k < matrix1.GetLength(1); k++)
            {
                multiArray[i, j] += matrix1[m, k] * matrix2[k, n];
            }
            n++;
        }
        n = 0;
        m++;
    }
    return multiArray;
}

int[,] array2DFirst = CreateMatrixRndInt(3, 4, 1, 9);
int[,] array2DSecond = CreateMatrixRndInt(4, 2, 1, 9);
PrintTwoMatrix(array2DFirst, array2DSecond);
Console.WriteLine();

if (array2DFirst.GetLength(1) == array2DSecond.GetLength(0))
{
    int[,] matrixMultiplication = MatrixMultiplication(array2DFirst, array2DSecond);
    PrintMatrix(matrixMultiplication);
}
else
    Console.WriteLine("Данные матрицы невозможно перемножить!");
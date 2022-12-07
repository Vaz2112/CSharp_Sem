/* Напишите программу, которая на вход принимает позиции элемента в двумерном массиве,
 и возвращает значение этого элемента или же указание, что такого элемента нет.

Например, задан массив:

1 4 7 2
5 9 2 3
8 4 2 4

1,7 -> такого элемента в массиве нет */

double[,] CreateMatrixRndDoubleRound(int rows, int columns, int min, int max, int round)
{
    double[,] matrix = new double[rows, columns];
    Random rnd = new Random();

    for (int i = 0; i < matrix.GetLength(0); i++)
    {
        for (int j = 0; j < matrix.GetLength(1); j++)
        {
            matrix[i, j] = rnd.NextDouble() * (max - min) + min;
            matrix[i, j] = Math.Round(matrix[i, j], round);
        }
    }
    return matrix;
}

void PrintMatrixDouble(double[,] matrix)
{
    for (int i = 0; i < matrix.GetLength(0); i++)
    {
        Console.Write("|");
        for (int j = 0; j < matrix.GetLength(1); j++)
        {
            if (j < matrix.GetLength(1) - 1) Console.Write($"{matrix[i, j],5}, ");
            else Console.Write($"{matrix[i, j],5} ");
        }
        Console.WriteLine("|");
    }
}

double[,] array2DdoubleRound = CreateMatrixRndDoubleRound(3, 4, -10, 10, 2);
PrintMatrixDouble(array2DdoubleRound);
Console.WriteLine();

Console.WriteLine("Введите индекс строки");
int iRow = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите индекс стоблца");
int iColumn = Convert.ToInt32(Console.ReadLine());
Console.WriteLine();

if (iRow > array2DdoubleRound.GetLength(0) - 1 || iRow < 0 || iColumn > array2DdoubleRound.GetLength(1) - 1 || iColumn < 0)
{
    Console.WriteLine("Такого элемента в массиве нет!");
}
else
{
    Console.WriteLine($"Значение элемента массива с индексами [{iRow}, {iColumn}] = {array2DdoubleRound[iRow, iColumn]}");
}
/* Напишите программу, которая заполнит спирально массив 4 на 4.
Например, на выходе получается вот такой массив:
01 02 03 04
12 13 14 05
11 16 15 06
10 09 08 07 */

void PrintMatrix(int[,] matrix)
{
    for (int i = 0; i < matrix.GetLength(0); i++)
    {
        Console.Write("|");
        for (int j = 0; j < matrix.GetLength(1); j++)
        {
            if (j < matrix.GetLength(1) - 1) Console.Write($"{matrix[i, j],4:d2}, ");
            else Console.Write($"{matrix[i, j],4:d2} ");
        }
        Console.WriteLine("|");
    }
}

int[,] SpiralFillingArray(int rows, int columns)
{
    int[,] spiralArray = new int[rows, columns];

    int iMin = 0;
    int iMax = rows;
    int jMin = 0;
    int jMax = columns;
    int number = 1;

    while (true)
    {
        // Слева направо
        //----------------------------------------
        for (int j = jMin; j < jMax; j++)
            spiralArray[iMin, j] = number++;

        iMin++;
        if (iMin == iMax)
            return spiralArray;
        //----------------------------------------

        // Сверху вниз
        //----------------------------------------
        for (int i = iMin; i < iMax; i++)
            spiralArray[i, jMax - 1] = number++;

        jMax--;
        if (jMin == jMax)
            return spiralArray;
        //----------------------------------------

        // Справа налево
        //----------------------------------------
        for (int j = jMax - 1; j >= jMin; j--)
            spiralArray[iMax - 1, j] = number++;

        iMax--;
        if (iMin == iMax)
            return spiralArray;
        //----------------------------------------

        // Снизу вверх
        //----------------------------------------
        for (int i = iMax - 1; i >= iMin; i--)
            spiralArray[i, jMin] = number++;

        jMin++;
        if (jMin == jMax)
            return spiralArray;
        //----------------------------------------
    }
}

PrintMatrix(SpiralFillingArray(7, 5));
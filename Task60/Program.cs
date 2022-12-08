/* Задача 60. 
Сформируйте трёхмерный массив из неповторяющихся двузначных чисел.
Напишите программу, которая будет построчно выводить массив,
добавляя индексы каждого элемента.

Например, задан массив размером 2 x 2 x 2.
Результат:
66(0,0,0) 27(0,0,1) 25(0,1,0) 90(0,1,1)
34(1,0,0) 26(1,0,1) 41(1,1,0) 55(1,1,1) */

int[,,] Create3DMatrixRndIntNonrepeat(int rows, int columns, int depth, int min, int max)
{
    int[,,] matrix = new int[rows, columns, depth];
    int[] array = new int[matrix.Length];
    int l = 0;
    Random rnd = new Random();

    for (int i = 0; i < matrix.GetLength(0); i++)
    {
        for (int j = 0; j < matrix.GetLength(1); j++)
        {
            for (int k = 0; k < matrix.GetLength(2); k++)
            {
                while (Array.Exists(array, v => v == matrix[i, j, k]))
                {
                    matrix[i, j, k] = rnd.Next(min, max + 1);
                }
                array[l] = matrix[i, j, k];
                l++;
            }
        }
    }
    return matrix;
}

void Print3DMatrix(int[,,] matrix)
{
    for (int i = 0; i < matrix.GetLength(0); i++)
    {
        for (int j = 0; j < matrix.GetLength(1); j++)
        {
            for (int k = 0; k < matrix.GetLength(2); k++)
            {
                Console.Write($"{matrix[i, j, k],2}({i},{j},{k}) ");
            }
        }
        Console.WriteLine();
    }
}

int[,,] matrix3D = Create3DMatrixRndIntNonrepeat(4, 2, 3, 10, 99);
Print3DMatrix(matrix3D);
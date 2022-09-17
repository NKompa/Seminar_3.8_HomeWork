// Задайте две матрицы. Напишите программу, которая будет находить произведение двух матриц.

int[,] GetMatrix(int rows, int columns, int min, int max)
{
    int[,] array = new int[rows, columns];
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            array[i, j] = new Random().Next(min, max);
            Console.Write(array[i, j] + "\t");
        }
        Console.WriteLine();
    }
    return array;
}

Console.WriteLine("Матрица A:");
int[,] matrixA = GetMatrix(4, 3, 1, 5);
Console.WriteLine("Матрица B:");
int[,] matrixB = GetMatrix(4, 3, 1, 5);
Console.WriteLine("Матрица C:");

if (matrixA.GetLength(1) == matrixB.GetLength(0))
{
    int[,] matrixC = new int[matrixA.GetLength(0), matrixB.GetLength(1)];
    for (int i = 0; i < matrixC.GetLength(0); i++)
    {
        for (int j = 0; j < matrixC.GetLength(1); j++)
        {
            for (int k = 0; k < matrixB.GetLength(0); k++)
            {
                matrixC[i, j] += matrixA[i, k] * matrixB[k, j];
            }
            Console.Write(matrixC[i, j] + "\t");
        }
        Console.WriteLine();
    }
}
else Console.WriteLine("Произведение матриц невозможно,т.к. количество столбцов Матрицы А не равно количеству строк Матрицы B.");
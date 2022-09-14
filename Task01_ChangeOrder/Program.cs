// Задайте двумерный массив. Напишите программу, которая упорядочит по убыванию элементы каждой строки двумерного массива: 1 4 7 2 => 7 4 2 1

int [,] GetMatrix (int rows, int columns, int min, int max)
{
    int [,] array = new int [rows,columns];
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            array[i,j] = new Random().Next(min,max);
            Console.Write(array[i,j]+"\t");
        }
        Console.WriteLine();
    }
    return array;
}

void SortMatrix (int [,] array)
{
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            int maxIndex = j;
            for (int k = j+1; k < array.GetLength(1); k++)
            {
                if(array[i,k] > array[i,maxIndex]) maxIndex=k;
            }
            int temp = array[i,j];
            array[i,j] = array[i,maxIndex];
            array[i,maxIndex] = temp;
            Console.Write(array[i,j]+"\t");
        }
        Console.WriteLine();
    }
}

int [,] newArray = GetMatrix(4,4,1,21);
Console.WriteLine();
SortMatrix(newArray);

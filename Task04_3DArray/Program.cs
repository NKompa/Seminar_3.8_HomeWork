// Сформируйте трёхмерный массив из неповторяющихся двузначных чисел. Напишите программу, которая будет построчно выводить массив, добавляя индексы каждого элемента. 
// Массив размером 2 x 2 x 2
int[] array2D = new int[90];
for (int i = 0; i < array2D.Length; i++)
{
    array2D[i] = 10 + i;
}
for (int i = 0; i < array2D.Length; i++)
{
    int j = new Random().Next(array2D.Length);
    int temp = array2D[j];
    array2D[j] = array2D[i];
    array2D[i] = temp;
}

int [,,] GetMatrix (int tables, int rows, int columns, int min, int max)
{
    int m = 0;
    int [,,] array = new int [tables,rows,columns];
    for (int k = 0; k < array.GetLength(0); k++)
    {
        for (int i = 0; i < array.GetLength(1); i++)
        {
            for (int j = 0; j < array.GetLength(2); j++)
            {
                array[k,i,j] = array2D[m];
                Console.Write($"{array[k,i,j]} ({k},{i},{j})  ");
                m++;
            }
            Console.WriteLine();
        }
        Console.WriteLine();
    }
    return array;
}

int [,,] array3D = GetMatrix(2,2,2,10,100);
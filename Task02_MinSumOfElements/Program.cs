// Задайте прямоугольный двумерный массив. Напишите программу, которая будет находить строку с наименьшей суммой элементов. 
// Программа считает сумму элементов в каждой строке и выдаёт номер строки с наименьшей суммой элементов: 1 строка

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

int [,] newArray = GetMatrix(4,5,0,11);

int minRow = int.MaxValue;
int minIndex = 0;
for (int i = 0; i < newArray.GetLength(0); i++)
{
    int sumRow = 0;
    for (int j = 0; j < newArray.GetLength(1); j++)
    {
        sumRow = sumRow + newArray[i,j];
    }
    Console.WriteLine($"Сумма строки {i+1} равна {sumRow}");
    if(sumRow < minRow) 
    {
        minRow = sumRow;
        minIndex = i;
    } 
}
Console.WriteLine($"Минимальная сумма в строке {minIndex+1}");
// Напишите программу, которая заполнит спирально массив 4 на 4.

int [,] array = new int [4,4];
int number = 0;
int i = 0;
int j = 0;

for (j = 0; j < array.GetLength(1); j++)
{
    array[i,j] = number+1;
    number++;
}
j=3;
for (i = 1; i < array.GetLength(0); i++)
{
    array[i,j] = number+1;
    number++;
}
i=3;
for (j = 2; j >= 0; j--)
{
    array[i,j] = number+1;
    number++;
}
j=0;
for (i = 2; i >= 1 ; i--)
{
    array[i,j] = number+1;
    number++; 
}
i = 1;
for (j = 1; j <= 2; j++)
{
    array[i,j] = number+1;
    number++;    
}
i = 2;
for (j = 2; j >= 1; j--)
{
    array[i,j] = number+1;
    number++;
}

for (i = 0; i < array.GetLength(0); i++)
{
    for (j = 0; j < array.GetLength(1); j++)
    {
        Console.Write(array[i,j]+"\t");
    }
    Console.WriteLine();
}
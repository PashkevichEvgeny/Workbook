// Задача 53:
// Задайте двумерный массив. Напишите программу, 
// которая поменяет местами первую и последнюю строку массива.
//  10 10 11 15 -\  /-> 40 44 40 44
//  21 25 29 20   \/    21 25 29 20
//  38 33 37 34   /\    38 33 37 34 
//  40 44 40 44 -/  \-> 10 10 11 15

int[,] FillArray(int m, int n)
{
    int[,] array = new int[m,n]; 
    for (int i = 0; i < m; i++)
    {
        for (int j = 0; j < n; j++)
        {
            array[i, j] = new Random().Next(1, 10);
        }
    }
    return array;
}

void ChangedFirstLast(int[,] array)
{
    int len = array.GetLength(0) - 1;
    for (int i = 0; i < array.GetLength(1); i++)
    {
        (array[0, i], array[len, i]) = (array[len, i], array[0, i]);
    }
}

void PrintArray(int[,] array)
{
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            System.Console.Write($"{array[i,j]} ");
        }
        System.Console.WriteLine();
    }
}

int[,] a = FillArray(3,4);
PrintArray(a);
ChangedFirstLast(a);
System.Console.WriteLine();
PrintArray(a);

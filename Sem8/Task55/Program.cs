// Задача 55:
// Задайте двумерный массив. Напишите программу, которая заменяет строки на столбцы. 
// В случае, если это невозможно, программа должна вывести сообщение для пользователя.
//  10 10 11 15        10 21 38 40
//  21 25 29 20   ->   10 25 33 44
//  38 33 37 34   ->   11 29 37 40
//  40 44 40 44        14 20 34 44

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

bool ChangedFirstLast(int[,] array)
{
    if (array.GetLength(0) != array.GetLength(1))
    {
        System.Console.WriteLine("Невозможно");
        return false;
    }
    int len = array.GetLength(0) - 1;
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = i; j < array.GetLength(0); j++)
        {
            (array[j, i], array[i, j]) = (array[i, j], array[j, i]);
            
        }
    }
    return true;
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
int[,] b = {{10, 10, 11, 15}, {21, 25, 29, 20}, {38, 33, 37, 34}, {40, 44, 40, 44}};
int[,] a = FillArray(4,4);
PrintArray(a);
ChangedFirstLast(a);
System.Console.WriteLine();
PrintArray(a);
System.Console.WriteLine();
PrintArray(b);
ChangedFirstLast(b);
System.Console.WriteLine();
PrintArray(b);

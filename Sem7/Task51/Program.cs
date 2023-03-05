// Задача 51: 
// Задайте двумерный массив. 
// Найдите сумму элементов, находящихся на главной диагонали 
// с индексами (0,0); (1; 1) и т.д.
// Например, задан массив:
// 1 4 7 2    1
// 5 9 2 3      9
// 8 4 2 4        2
// Сумма элементов главной диагонали: 1+9+2 = 12

Console.WriteLine("Введите количество столбцов: ");
int m = int.Parse(Console.ReadLine()!);
Console.WriteLine("Введите количество строк: ");
int n = int.Parse(Console.ReadLine()!);
int[,] array = new int[m, n];

void FillArray(int m, int n)
{
    for (int i = 0; i < m; i++)
    {
        for (int j = 0; j < n; j++)
        {
            array[i, j] = new Random().Next(1, 10);
        }
    }
}

int SumDiagonal(int[,] array)
{
    int sum = 0;
    for (int i = 0; i < m; i++)
    {
        for (int j = 0; j < n; j++)
        {
            if (i == j) sum += array[i,j];
        }
    }
    return sum;
}

void PrintArray(int[,] array)
{
    for (int i = 0; i < m; i++)
    {
        for (int j = 0; j < n; j++)
        {
            Console.Write($" {array[i, j]} ");
        }
        Console.WriteLine();
    }
}
FillArray(m, n);
PrintArray(array);
Console.WriteLine(SumDiagonal(array));


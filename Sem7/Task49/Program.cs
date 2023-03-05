// Задача 49:
// Задайте двумерный массив.
// Найдите элементы, у которых оба индекса чётные,
// и замените эти элементы на их квадраты.
// Например, изначально массив выглядел вот так:
// 1 4 7 2
// 5 9 2 3
// 8 4 2 4
// 1 2 3 4
// Новый массив будет выглядеть вот так:
// 1   4   7   2
// 5 *81*  2  *9*
// 8   4   2   4
// 1 *16*  3 *81*

System.Console.WriteLine("Введите количество столбцов: ");
int m = int.Parse(Console.ReadLine()!);
int n = int.Parse(Console.ReadLine()!);
int[,] array = new int[m,n];

void FillArray(int m, int n)
{
    for (int i = 0; i < m; i++)
{
    for (int j = 0; j < n; j++)
    {
        array[i,j] = new Random().Next(1, 10);
    }
}
}

void FillArray2(int[,] array)
{
    for (int i = 0; i < m; i++)
{
    for (int j = 0; j < n; j++)
    {
        if (i % 2 == 1 && j % 2 == 1) array[i,j] = array[i,j] * array[i,j];
    }
}
}

void PrintArray(int[,] array)
{
for (int i = 0; i < m; i++)
{
    for (int j = 0; j < n; j++)
    {
        if (i % 2 == 1 && j % 2 == 1) Console.Write($"*{array[i,j]}*");
        else System.Console.Write($" {array[i,j]} ");
    }
    System.Console.WriteLine();
}
}
FillArray(m,n);
PrintArray(array);
System.Console.WriteLine();
FillArray2(array);
PrintArray(array);
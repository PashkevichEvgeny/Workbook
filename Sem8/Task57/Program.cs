// Задача 57:
// Создайте двумерный массив n * m и заполните его случайными числами от 1 до 10.
// Выведите сколько раз встречается каждое число от 1 до 10
// 6 6 3 1  
// 7 1 7 10 
// 3 8 6 0  
// 7 8 9 8 
// Вывод
// 0 встречается 1
// 1 встречается 2
// 3 встречается 2
// 6 встречается 3
// 7 встречается 3
// 8 встречается 3
// 9 встречается 1
// 10 встречается 1

System.Console.WriteLine("Введите: ");
int a = int.Parse(Console.ReadLine()!);
System.Console.WriteLine("Введите: ");
int b = int.Parse(Console.ReadLine()!);

int[,] FillArray(int m, int n, int minValue, int maxValue)
{
    int[,] array = new int[m,n]; 
    for (int i = 0; i < m; i++)
    {
        for (int j = 0; j < n; j++)
        {
            array[i, j] = new Random().Next(minValue, maxValue + 1);
        }
    }
    return array;
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

int[][] CountElement(int[,] array, int minValue, int maxValue)
{
    int[][] count = new int[maxValue - minValue + 1][];
    for (int i = 0; i < count.GetLength(0); i++)
    {
        count[i] = new int[1];
    }

    for (int i = minValue; i < maxValue + 1; i++)
    {
        for (int j = 0; j < array.GetLength(0); j++)
        {
            for (int k = 0; k < array.GetLength(1); k++)
            {
                if (i == array[j,k])
                {
                    count[j][k] += 1;
                }
            }
        }
    }
    return count;
}

int[,] newArray = FillArray(10, 10, a, b);
int[][] countArray = CountElement(newArray, a, b);
PrintArray(newArray);
// for (int i = 0; i < countArray.GetLength(0); i++)
// {
//     System.Console.WriteLine($"{string.Join(" ", countArray[i])} ");
// }




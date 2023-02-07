// Задача 30:
// Напишите программу, которая выводит массив из 8 элементов, 
// заполненный нулями и единицами в случайном порядке.
// [1,0,1,1,0,1,0,0]

int[] MakeArray()
{
    int length = 8;
    int[] array = new int[length];
    for (int i = 0; i < length; i++)
    {
        array[i] = new Random().Next(2);
    }
    return array;
}

int[] arrayA = MakeArray();
// Вывод массива через foreach
foreach (var item in arrayA) Console.Write(item + " ");
Console.WriteLine();
Console.WriteLine($"[{string.Join(",", arrayA)}]");

// Создание и заполнение массива заданной длины
int[] MakeSomeArray(int length)
{
    int[] array = new int[length];
    for (int i = 0; i < length; i++)
    {
        array[i] = new Random().Next(2);
    }
    return array;
}

int[] arrayB = MakeSomeArray(25);
Console.WriteLine($"[{string.Join(",", arrayB)}]");

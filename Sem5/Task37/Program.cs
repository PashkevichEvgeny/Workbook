// Задача 37: 
// Найдите произведение пар чисел в одномерном массиве заданным пользователем. 
// Парой считаем первый и последний элемент, второй и предпоследний и т.д. 
// Результат запишите в новом массиве.
// [1 2 3 4 5] -> 5 8 3
// [6 7 3 6] -> 36 21

Console.Clear();

// Метод создающий массив заданной длины
int[] MakeArray(int length)
{
    int[] array = new int[length];
    for (int i = 0; i < length; i++) array[i] = new Random().Next(10);
    return array;
}

int[] FoldedArray(int[] array)
{
    int len = array.Length;
    if (len == 1) return array;
    int foldLen = (len % 2 == 0) ? len / 2: len / 2 + 1;
    int[] fold = new int[foldLen];
    for (int i = 0; i < foldLen; i++)
    {
        if (len % 2 == 1 && i == foldLen - 1)
        {
            fold[i] = array[i];
        }
        else
        {
        fold[i] = array[i] * array[len - i - 1];
        }
    }
    return fold;
}

void Main()
{
    int[] randomArray = MakeArray(new Random().Next(1, 10));
    Console.WriteLine($"Массив длиной: {randomArray.Length} - [{String.Join(" ", randomArray)}]");
    int[] foldedRandomArray = FoldedArray(randomArray);
    Console.WriteLine($"Сложенный массив длиной: {foldedRandomArray.Length} - [{String.Join(" ", foldedRandomArray)}]");
}

Main();


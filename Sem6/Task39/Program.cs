// Задача 39:
// Напишите программу, которая перевернёт одномерный массив 
// (последний элемент будет на первом месте, а первый - на последнем и т.д.)
// [0, 1, 2, 3, 4] -> [4, 3, 2, 1, 0]

// пишем метод создающий массив, можно взять из прошлого занятия
// Метод создающий массив заданной длины
int[] MakeArray(int length)
{
    int[] array = new int[length];
    for (int i = 0; i < length; i++) array[i] = new Random().Next(10);
    return array;
}

// метод переварачивающий массив
void ReverseArray(int[] array)
{
    int len = array.Length;
    for (int i = 0; i < array.Length / 2; i++)
    {
        (array[i], array[len - i - 1]) = (array[len - i - 1], array[i]);
    }
}

int[] massiv = MakeArray(10);
foreach (var item in massiv)
{
    System.Console.Write($"{item}");
}
System.Console.WriteLine();
ReverseArray(massiv);
foreach (var item in massiv)
{
    System.Console.Write($"{item}");
}
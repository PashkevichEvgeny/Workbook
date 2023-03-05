// Задача 35: 
// Задайте одномерный массив из 123 случайных чисел.
// Найдите количество элементов массива, значения которых лежат в отрезке [10,99].
// Пример для массива из 5, а не 123 элементов. В своём решении сделайте для 123
// [5, 18, 123, 6, 2] -> 1
// [1, 2, 3, 6, 2] -> 0
// [10, 11, 12, 13, 14] -> 5

Console.Clear();

// Метод создающий массив заданной длины
int[] MakeArray(int length)
{
    int[] array = new int[length];
    for (int i = 0; i < length; i++) array[i] = new Random().Next(1000);
    return array;
}

// Метод подсчитывающий количество элементов массива на заданном отрезке
int AmountPointsOnSegment(int[] array, int pointA, int pointB)
{
    int amount = 0;
    foreach (int item in array)
    {
        if (item > pointA && item < pointB) amount++;
    }
    return amount;
}

void Main()
{
    // задаем параметры: Точка А, Точка Б, Размер массива
    int pointA = 10, pointB = 99, len = 123;
    // Создаем новый массив заданной длины
    int[] randomArray123 = MakeArray(len);
    // Вывод созданного массива
    // Console.WriteLine($"[{String.Join(", ", randomArray123)}]"); 
    // Вывод точек из заданного отрезка
    //Console.WriteLine($"{String.Join(" ", 
    //                from num in randomArray123 
    //                where num > pointA && num < pointB
    //                select num)}");
    // Подсчет точек на заданном отрезке
    int amountOfPoints = AmountPointsOnSegment(randomArray123, pointA, pointB);
    // Вывод количества точек на отрезке
    Console.WriteLine($"Количество точек на отрезке [{pointA}, {pointB}]: {amountOfPoints}");
}

Main();
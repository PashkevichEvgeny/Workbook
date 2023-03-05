// Задача 31: 
// Задайте массив из 12 элементов, заполненный случайными числами из промежутка [-9, 9].
// Найдите сумму отрицательных и положительных элементов массива.
// Например, в массиве [3, 9, -8, 1, 0, -7 , 2, -1, 8, -3, -1, 6] 
// сумма положительных чисел равна 29, сумма отрицательных равна -20.

Console.Clear();

int[] MakeArray(int length, int minValue, int maxValue)
{
    int[] array = new int[length];
    for (int i = 0; i < length; i++) array[i] = new Random().Next(minValue, maxValue);
    return array;
}

// Метод с выходными параметрами с суммами положительных и отрицательных чисел
void SumOfPosAndNegInArray(int[] array, out int sumOfPositive, out int sumOfNegative)
{
    sumOfPositive = 0; 
    sumOfNegative = 0;
    foreach (int item in array)
    {
        if (item < 0) sumOfNegative += item;
        if (item > 0) sumOfPositive += item;
    }
}

// Рандомный массив
int[] randomArray = MakeArray(12, -9, 10);
Console.WriteLine($"Массив: [{string.Join(", ", randomArray)}]");

// Положительные и отрицательные числа в массиве
Console.WriteLine($"отриц: [{string.Join(", ", 
                      from num in randomArray 
                      where num < 0 select num)}]  полож: [{
                      string.Join(", ", 
                      from num in randomArray 
                      where num > 0 select num)}]");

// Суммы этих чисел
SumOfPosAndNegInArray(randomArray, out int positive, out int negative);
System.Console.WriteLine($"Сумма отрицательных {negative} и положительных чисел {positive}");

// Задача 32: 
// Напишите программу замена элементов массива: 
// положительные элементы замените на соответствующие отрицательные, и наоборот.
// [-4, -8, 8, 2] -> [4, 8, -8, -2] 

Console.Clear();

int[] MakeArray(int length, int minValue, int maxValue)
{
    int[] array = new int[length];
    for (int i = 0; i < length; i++) array[i] = new Random().Next(minValue, maxValue);
    return array;
}
// меняем знак
int[] ChangingSign(int[] array)
{
    for (int i = 0; i < array.Length; i++) 
    {
        array[i] = array[i] * -1;
    }
    return array;
}
// вывод 
void Main()
{
    int[] randomArray = MakeArray(10, -9, 10);
    Console.WriteLine($"Старый Массив: [{string.Join(", ", randomArray)}]");

    int[] changingArray = ChangingSign(randomArray);
    Console.WriteLine($"Новый Массив: [{string.Join(", ", changingArray)}]");
}

Main();
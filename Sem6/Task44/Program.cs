// Задача 44:
// Не используя рекурсию, выведите первые N чисел Фибоначчи.
// Первые два числа Фибоначчи: 0 и 1.
// Если N = 5-> 0 1 1 2 3
// Если N = 3 -> 0 1 1
// Если N = 7 -> 0 1 1 2 3 5 8

int nFibonacci(int number)
{
    int result = 0;
    int a = 1, b = 0;
     for (int i = 0; i < number; i++)
     {
        (a, result) = (a + b, a + result);
        (a, b) = (b, a);
     }
    return result;
}

for (int i = 1; i < 20; i++)
{
    System.Console.WriteLine($"{i} - {nFibonacci(i)}");
}
// Задача 28:
// Напишите программу, которая принимает на вход число N и 
// выдаёт произведение чисел от 1 до N.
// 

ulong Factorial(ulong number)
{
    ulong result = 1;
    for (ulong i = 2; i <= number; i++)
    {
        result *= i;
        System.Console.WriteLine(result);
    }
    return result;
}

Console.Write("Введите любое число, но не больше 20: ");
ulong a = Factorial(ulong.Parse(Console.ReadLine()!));
// System.Console.WriteLine(a);
System.Console.WriteLine(ulong.MaxValue);
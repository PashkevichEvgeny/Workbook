// Задача 26: 
// Напишите программу, которая принимает на вход число и 
// выдаёт количество цифр в числе.
// 456  - > 3
// 78    -> 2
// 89126 -> 5

int Amount(int number)
{
    int count = 1;
    while (number > 10)
    {
        number /= 10;
        count++;
    }
    return count;
}

Console.Write("Введите число: ");
int a = Amount(int.Parse(Console.ReadLine()!));
System.Console.WriteLine(a);

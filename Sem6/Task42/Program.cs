// Задача 42:
// Напишите программу, которая будет преобразовывать десятичное число в двоичное.
// 7 -> 111

// System.Console.Write("Число:");
// int a = int.Parse(Console.ReadLine()!);
// int b = 1;

void DecToBin(int a)
{
    int b = 0;
    while (a > 1)
    {
        b = a % 2;
        a = a / 2;
        System.Console.Write($"{a} , {b}");
    }
}

for (int i = 1; i < 64; i++)
{
    System.Console.WriteLine($"{i} - ");
    DecToBin(i);
}

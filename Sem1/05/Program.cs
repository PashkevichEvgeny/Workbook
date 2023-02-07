Console.Clear();
Console.Write("Введите трехзначное число: ");
int number = int.Parse(Console.ReadLine()!);
int numberB;

if (99 < number & number < 1000)
{
    numberB = number % 10;        // Остаток от деления будет последняя цифра
    Console.Write($"Последняя цифра числа {number} - это {numberB}");
}
else
{
    Console.Write("Вы ввели не трехзначное число");
}

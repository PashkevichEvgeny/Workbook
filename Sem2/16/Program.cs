// Напишите программу, которая принимает на вход два числа и проверяет, 
// является ли одно число квадратом другого.
//  5, 25  ->  да
// -4, 16  ->  да
//  25, 5  ->  да
//  8,9    ->  нет

Console.Clear();
Console.Write("Введите первое число: ");
int numberA = int.Parse(Console.ReadLine());
Console.Write("Введите второе число: ");
int numberB = int.Parse(Console.ReadLine());

if (numberA * numberA == numberB)
{
    Console.WriteLine($"да, {numberA} - квадрат {numberB}");
}
else if (numberB * numberB == numberA)
{
    Console.WriteLine($"да, {numberB} - квадрат {numberA}");
}
else
{
    Console.WriteLine("нет");
}
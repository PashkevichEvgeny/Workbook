// Напишите программу, которая принимает на вход число и проверяет, 
// кратно ли оно одновременно 7 и 23.
// 14 -> нет 
// 46 -> нет 
// 161 -> да

Console.Clear();
Console.Write("Введите число: ");
int number = int.Parse(Console.ReadLine()!);
int numberA = number %  7;
int numberВ = number %  23;
if (numberA == 0 && numberВ == 0)
{
    Console.WriteLine($"да {number} кратно 7 и 23");
}
else
{
    Console.WriteLine("нет");
}
// Задача 63:
// Напишите программу, которая на вход принимает число N, 
// и выводит строку от 1 до N с помощью рекурсии.
// 5  ->  1 2 3 4 5

string PrintNumbers(int a)
{
    if (a == 1) return $"{a} ";
    else return PrintNumbers(a - 1) + $"{a} ";
}
System.Console.WriteLine(PrintNumbers(5));
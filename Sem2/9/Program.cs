// Напишите программу, которая выводит случайное число из отрезка [10, 99] и 
// показывает наибольшую цифру числа.
// 78 -> 8
// 12-> 2
// 85 -> 8

Console.Clear();
int number = new Random().Next(10, 100);
int a = number / 10;
int b = number % 10;
if (a < b) a = b;
System.Console.WriteLine($"Number = {number}, Max = {a}");

// Напишите программу, которая выводит случайное трёхзначное число и 
//удаляет вторую цифру этого числа.
// 456 -> 46
// 782 -> 72
// 918 -> 98

Console.Clear();
int number = new Random().Next(99, 1000);
int a = number % 10;
int b = number / 100 * 10;
System.Console.WriteLine($"Случайное число {number}, Ответ {a + b}");
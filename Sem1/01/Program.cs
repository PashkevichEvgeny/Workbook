Console.Clear();
Console.Write("Enter value: ");
int number = int.Parse(Console.ReadLine()!);
int sqr = number * number;
Console.WriteLine($"Квадрат числа {number} - это {sqr}");

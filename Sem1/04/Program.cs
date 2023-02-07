Console.Clear();
Console.Write("Введите число: ");
int number = int.Parse(Console.ReadLine()!);
int numberB = number * -1;

while (numberB <= number)
{
    if (numberB % 2 == 0)
    {
        Console.Write($"{numberB} ");
    }
    numberB++; 
}


Console.Clear();
Console.Write("Enter value: ");
int numberA = int.Parse(Console.ReadLine()!);
Console.Write("Enter value: ");
int numberB = int.Parse(Console.ReadLine()!);
int sqr = numberB * numberB;
if (sqr == numberB)
{
    Console.WriteLine("Yes");
}
else
{
    Console.WriteLine("No");
}

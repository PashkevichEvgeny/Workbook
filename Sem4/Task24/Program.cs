// Задача 24:
// Напишите программу, которая принимает на вход число A
// и выдаёт сумму чисел от 1 до A
// A = 5   ->  1 + 2 + 3 + 4 + 5 = 15
// A = 10  ->  55

int SumFromOne(int number)
{
    return number * (number + 1) / 2;;
}
Console.Write("Введите число: ");
int a = SumFromOne(int.Parse(Console.ReadLine()!));
System.Console.WriteLine(a);

string Fib(int number)
{
    string result = "1";
    int a = 0, b = 1;
     for (int i = 1; i < number; i++)
     {
        a += b;
        result += ", " + a;
        (a, b) = (b, a);
     }
    return result;
}

Console.Write("Введите число: ");
string aa = Fib(int.Parse(Console.ReadLine()!));
int len = aa.Split(",").Length;
System.Console.WriteLine(aa.Split(",")[len - 1].Trim());
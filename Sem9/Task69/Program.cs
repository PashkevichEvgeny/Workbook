// Задача 69:
// Напишите программу, которая на вход принимает два числа A и B, 
// и возводит число А в целую степень B с помощью рекурсии.

int PowerAinB(int a, int b)
{
    if (a == 0) return 0;
    if (b == 0) return 1;
    else return a * PowerAinB(a, b - 1);
}

System.Console.WriteLine(PowerAinB(0, 2));
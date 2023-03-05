// Задача 40:
// Напишите программу, которая принимает на вход три числа и проверяет, 
// может ли существовать треугольник с сторонами такой длины.
// 3, 4, 5 -> да

int[] triangle = new int[3];
for (int i = 0; i < 3; i++)
{
    System.Console.WriteLine("Введите длину стороны:");
    triangle[i] = int.Parse(Console.ReadLine()!);
}

bool ExistTriangle(int[] array)
{
    int max = array[0], b = array[1], c = array[2];
    if (max < array[1])
    {
        max = array[1];
        b = array[0];
    }
    else if (max < array[2])
    {
        max = array[2];
        c = array[1];
    }
    if (max >= b + c) return false;
    return true;
}

System.Console.WriteLine(ExistTriangle(triangle));
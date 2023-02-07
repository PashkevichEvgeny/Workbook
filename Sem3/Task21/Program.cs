// Задача 21:
// Напишите программу, которая принимает на вход координаты двух точек и 
// находит расстояние между ними в 2D пространстве.
// A (3,6); B (2,1) -> 5,09 
// A (7,-5); B (1,-1) -> 7,21
using static System.Console;
Clear();

char[,] namePoint = {{'A', 'x'}, {'A', 'y'}, 
                       {'B', 'x'}, {'B', 'y'}};
int len = namePoint.GetLength(0);
int[] coordArray = new int[len];

for (int i = 0; i < len; i++)
{
    Write($"Введите координату точки {namePoint[i, 0]} по оси {namePoint[i, 1]}: ");
    coordArray[i] = int.Parse(ReadLine()!);
}
double distance = Math.Sqrt(Math.Pow((coordArray[0] - coordArray[2]), 2) +
                            Math.Pow((coordArray[1] - coordArray[3]), 2));
WriteLine($"{Math.Round(distance, 2)}");
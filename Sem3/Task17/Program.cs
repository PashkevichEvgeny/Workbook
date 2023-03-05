// Задача №17:
// Напишите программу, которая принимает на вход координаты точки (X и Y), 
// причем X ≠ 0 и Y ≠ 0 и выдаёт номер четверти плоскости, в которой находится эта точка.

using static System.Console;
Clear();

Write("Введите точку на прямой x: ");
int x = int.Parse(ReadLine()!);
Write("Введите точку на прямой y: ");
int y = int.Parse(ReadLine()!);

if (x > 0 && y > 0){
    Write("1");
} else if (x < 0 && y < 0)
{
    Write("2");
} else if (x < 0 && y < 0)
{
    Write("3");
} else if (x > 0 && y < 0)
{
    Write("4");
} else if (x == 0 && y == 0)
{
    Write("Точка на оси");
}

// Задача 18:
// Напишите программу, которая по заданному номеру четверти, 
//показывает диапазон возможных координат точек в этой четверти (x и y).
using static System.Console;
Clear();

Write("Введите номер четверти: ");
int number = int.Parse(ReadLine()!);

switch (number)
{
case 1:
        Write("x > 0, y > 0");
        break;
case 2:
        Write("x < 0, y < 0");
        break;
case 3:
        Write("x <, y < 0");
        break;
case 4:
        Write("x > 0, y < 0");
        break;
default:
        Write("Неправильный номер четверти");
        break;
}

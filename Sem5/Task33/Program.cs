// Задача 33: 
// Задайте массив и случайное число. Напишите программу, которая определяет, 
// присутствует ли заданное число в массиве.
// 4; массив [6, 7, 19, 345, 3] -> нет
// -3; массив [6, 7, 19, 345, 3] -> да

Console.Clear();

// Метод принимающий числа в массив от пользователя
int[] arrayUser()
{
    int[] newArray = new int[10];
    System.Console.Write("Введите числа: ");
    string[] text = Console.ReadLine()!.Split(' ');
    for (int i = 0; i < text.Length; i++)
    {
        newArray[i] = Convert.ToInt32(text[i]);
    }
    return newArray;
}

string IsThereNumber(int[] array, int number)
{
    int count = 0;
    foreach (int item in array) 
    {
        if (number == item) count++;
    }
    return (count == 0)?"нет":"да";
}

void Main()
{ 
    System.Console.Write("Введите искомое число: ");
    int checkNumber = int.Parse(Console.ReadLine()!);
    int [] randomArray = arrayUser();
    Console.WriteLine($"Массив: [{string.Join(", ", randomArray)}]");
    string prove = IsThereNumber(randomArray, checkNumber);
    Console.WriteLine(prove);
    Console.WriteLine((Array.Exists(randomArray, element => element == checkNumber))?
                       "Есть такое":"Нет такого");
}

Main();
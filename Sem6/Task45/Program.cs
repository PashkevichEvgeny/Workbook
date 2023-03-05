// Задача 45: 
// Напишите программу, которая будет создавать копию заданного массива 
// с помощью поэлементного копирования.


int[] CopyArray(int[] array)
{
    int[] newArray = new int[array.Length];
    for (int i = 0; i < array.Length; i++)
    {
        newArray[i] = array[i];
    }
    return newArray;
}
int[] a = {1, 2, 3, 4};
int[] a1 = CopyArray(a);
a[0] = 10;
System.Console.WriteLine($"{String.Join(" ", a)} ");
System.Console.WriteLine($"{String.Join(" ", a1)} ");

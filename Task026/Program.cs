using System;
using static System.Console;

Clear();

Write("Введите длину массива: ");
int n = int.Parse(ReadLine());

int[] array1 = GetArray(n, 0, 20);
int[] array2 = ArrayReverse(array1);

WriteLine(String.Join(" ", array1));
WriteLine(String.Join(" ", array2));

int[] GetArray(int size, int min, int max)
{
    int[] result = new int[size];

    for (int i = 0; i < result.Length; i++)
    {
        result[i] = new Random().Next(min, max + 1);
    }
    return result;
}

int[] ArrayReverse(int[] inArray)
{
    int[] result = new int[inArray.Length];
    for(int i = 0; i < inArray.Length; i++)
    {
        result[i] = inArray[inArray.Length - 1 - i];
    }
    return result;
}
using System;
using static System.Console;

Clear();

int[] array = GetArray(6, -9, 10);

int[] GetArray(int size, int min, int max)
{
    int[] result = new int[size];
    for (int i = 0; i < size; i++)
    {
        result[i] = new Random().Next(min, max + 1);
    }
    return result;
}

void InverseArray(int[] inArray)
{
    for(int i = 0; i < inArray.Length; i++)
    {
        inArray[i] *= -1;
    }
}

Write(String.Join(",", array));
InverseArray(array);
WriteLine();
Write(String.Join(",", array));

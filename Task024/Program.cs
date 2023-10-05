using System;
using static System.Console;

Clear();

int[] array = GetArray(20, 1, 100);    

int count = GetCount(array);

WriteLine($"Количество четных числе: {count}");

int[] GetArray(int size, int min, int max)
{
    int[] result = new int[size];
    for (int i = 0; i < size; i++)
    {
        result[i] = new Random().Next(min, max + 1);
    }
    return result;
}

int GetCount(int[] array)
{   
    int result = 0;

    foreach(var item in array)
    {
        if(item % 2 != 0) result++;
    }
    return result;
}
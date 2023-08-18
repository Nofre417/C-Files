using System;
using static System.Console;

Clear();

int[] array = GetArray(123, 0, 200);

int count = 0;

WriteLine(FindFitNums(array, count));

int[] GetArray(int size, int min, int max)
{
    int[] result = new int[size];
    for (int i = 0; i < size; i++)
    {
        result[i] = new Random().Next(min, max + 1);
    }
    return result;
}

int FindFitNums(int[] array, int count)
{
    foreach(var item in array)
    {
        if(item >= 10 && item <= 99) 
        {
            Write(item +",");
            count++;
        }
    }
    WriteLine();
    return count;
}
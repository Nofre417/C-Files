using System;
using static System.Console;

Clear();

int[] array = GetArray(10, 1, 100);

int[] GetArray(int size, int min, int max)
{
    int[] result = new int[size];
    for (int i = 0; i < size; i++)
    {
        result[i] = new Random().Next(min, max + 1);
    }
    return result;
}

void SelectionSort(int[] array)
{
    for (int i = 0; i < array.Length - 1; i++)
    {
        int minPosition = i;

        for(int j = i + 1; j < array.Length; j++)
        {
            if(array[j] < array[minPosition]) minPosition = j;
        }

        int temporary = array[i];
        array[i] = array[minPosition];
        array[minPosition] = temporary;
    }
}

SelectionSort(array);

void GetDiffrenbce(int[] array)
{   
    int minNum = array[0];
    int maxNum = array[array.Length - 1];
    int result = maxNum - minNum;

    Console.WriteLine($"{maxNum} - {minNum} = {result}");
}

GetDiffrenbce(array);

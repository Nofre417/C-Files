using System;
using System.Drawing;
using static System.Console;

Clear();

Write("Введите размер массива: ");
int size = int.Parse(ReadLine());

int[] array1 = GetArray(0, 100, size);
Write("Старый массив: " + String.Join(" ", array1));

WriteLine();

int[] array2 = CopyArray(array1, size);
Write("Новый массив: " + String.Join(" ", array2));


int[] GetArray(int min, int max, int size)
{
    int[] result = new int[size];

    for(int i = 0; i < size; i++)
    {
        result[i] = new Random().Next(min, max);
    }
    return result;
}

int[] CopyArray(int[] oldArray, int size)
{
    int[] newArray = new int[size];

    for(int i = 0; i < size; i++)
    {
        newArray[i] = oldArray[i];
    }
    return newArray;
}
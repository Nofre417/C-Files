using System;
using static System.Console;

Clear();

int[,] array = GetArray(4, 4, 0, 9);
PrintArray(array);

WriteLine();

int[] index = GetMinIndex(array);
int[,] newArray = GetResultArray(array, index);
PrintArray(newArray);

int[,] GetArray(int rows, int colons, int min, int max)
{
    int[,] result = new int[rows, colons];

    for (int i = 0; i < result.GetLength(0); i++)
    {
        for (int j = 0; j < result.GetLength(1); j++)
        {
            result[i, j] = new Random().Next(min, max + 1);
        }
    }
    return result;
}

int[,] GetResultArray(int[,] inArray, int[] index)
{
    int[,] result = new int[inArray.GetLength(0) - 1, inArray.GetLength(1) - 1];
    int countRows = 0;
    int countColons = 0;

    for (int i = 0; i < inArray.GetLength(0); i++)
    {
        if (i == index[0]) continue;
        for (int j = 0; j < inArray.GetLength(1); j++)
        {
            if (j == index[0]) continue;
            result[countRows, countColons] = inArray[i, j];
            countColons++;
        }
        countRows++;
        countColons = 0;
    }
    return result;
}

int[] GetMinIndex(int[,] inArray)
{
    int[] result = new int[] { 0, 0 };
    int min = inArray[0, 0];

    for (int i = 0; i < inArray.GetLength(0); i++)
    {
        for (int j = 0; j < inArray.GetLength(1); j++)
        {
            if (min > inArray[i, j])
            {
                min = inArray[i, j];
                result[0] = i;
                result[1] = j;
            }
        }
    }
    return result;
}

void PrintArray(int[,] inArray)
{
    for (int i = 0; i < inArray.GetLength(0); i++)
    {
        for (int j = 0; j < inArray.GetLength(1); j++)
        {
            Write($" {inArray[i, j]} ");
        }
        WriteLine();
    }
}
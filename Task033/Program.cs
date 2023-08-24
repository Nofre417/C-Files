using System;
using static System.Console;

Clear();

Write("Введите количество строк массива: ");
int rows = int.Parse(ReadLine());
Write("Введите количество стобцов массива: ");
int colons = int.Parse(ReadLine());

int[,] array = GetArray(rows, colons);
PrintArray(array);

int[,] GetArray(int rows, int colons)
{
    int[,] result = new int[rows, colons];

    for (int i = 0; i < rows; i++)
    {
        for (int j = 0; j < colons; j++)
        {
            result[i, j] = i + j;
        }
    }
    return result;
}

void PrintArray(int[,] array)
{
    for (int i = 0; i < rows; i++)
    {
        for (int j = 0; j < colons; j++)
        {
            Write($"{array[i, j]} ");
        }
        WriteLine(" ");
    }
}
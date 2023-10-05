using System;
using static System.Console;

Clear();

Write("Введите количество строк массива: ");
int m = int.Parse(ReadLine());
Write("Введите количество стобцов массива: ");
int n = int.Parse(ReadLine());

int[,] array = GetArray(m, n);
PrintArray(array);

int[,] GetArray(int n, int m)
{
    int[,] result = new int[n, m];

    for (int i = 0; i < n; i++)
    {
        for (int j = 0; j < m; j++)
        {
            result[i, j] = new Random().Next(-100, 100);
        }
    }
    return result;
}

void PrintArray(int[,] array)
{
    for (int i = 0; i < m; i++)
    {
        for (int j = 0; j < n; j++)
        {
            Write($"{array[i, j]} ");
        }
        WriteLine(" ");
    }
}
using System;
using System.Xml.XPath;
using static System.Console;

Clear();

Write("Введите количество строк массива: ");
int rows = int.Parse(ReadLine());
Write("Введите количество стобцов массива: ");
int colons = int.Parse(ReadLine());

int[,] array = GetArray(rows, colons);

WriteLine("Созданный массив: ");
PrintArray(array);

int[,] newArray = ToSquareArray(array);
WriteLine("Новый массив: ");
PrintArray(newArray);

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
int[,] GetArray(int rows, int colons)
{
    int[,] result = new int[rows, colons];

    for (int i = 0; i < rows; i++)
    {
        for (int j = 0; j < colons; j++)
        {
            result[i, j] = new Random().Next(1, 10);
        }
    }
    return result;
}

int[,] ToSquareArray(int[,] array)
{
    int[,] result = array;

    for (int i = 0; i < colons; i++)
    {
        for (int j = 0; j < rows; j++)
        {
            if (i > 0 && j > 0)
            {
                if ((i % 2) == 0 && (j % 2) == 0) result[i, j] = result[i, j] * 2;
            }
        }
    }
    return result;
}
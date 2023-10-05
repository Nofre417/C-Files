using System;
using static System.Console;

Clear();

Write("Введите количество строк массива: ");
int rows = int.Parse(ReadLine());
Write("Введите количество стобцов массива: ");
int colons = int.Parse(ReadLine());

int[,] array = GetArray(rows, colons);
PrintArray(array);

WriteLine();

int[] newRow = GetAmountOfElementArray(array);
SortArray(newRow);
WriteLine(String.Join(" ", newRow));
WriteLine();

PrintData(newRow);


int[,] GetArray(int rows, int colons)
{
    int[,] result = new int[rows, colons];

    for (int i = 0; i < rows; i++)
    {
        for (int j = 0; j < colons; j++)
        {
            result[i, j] = new Random().Next(0, 9);
        }
    }
    return result;
}

int[] GetAmountOfElementArray(int[,] array)
{
    int[] newArray = new int[array.GetLength(0) * array.GetLength(1)];
    int index = 0;

    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            newArray[index] = array[i, j];
            index++;
        }
    }
    return newArray;


}

void SortArray(int[] newArray)
{
    for (int i = 0; i < newArray.Length; i++)
    {
        for (int j = i + 1; j < newArray.Length; j++)
        {
            if (newArray[i] > newArray[j])
            {
                int temp = newArray[i];
                newArray[i] = newArray[j];
                newArray[j] = temp;
            }
        }
    }
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

void PrintData(int[] newArray)
{
    int element = newArray[0];
    int count = 1;

    for (int i = 1; i < newArray.Length; i++)
    {
        if (newArray[i] != element)
        {
            WriteLine($"{element} встречается {count} раз");
            element = newArray[i];
            count = 1;
        }
        else count++;
    }
    WriteLine($"{element} встречается {count} раз");
}
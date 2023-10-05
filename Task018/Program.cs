using System;

Console.Clear();

int[] array = GetArray(12, -9, 9);
int positiveSum = 0;
int negativeSum = 0;


    foreach (var item in array)
    {
        if(item > 0) positiveSum += item;
        else negativeSum += item;
    }

int[] GetArray(int size, int min, int max)
{
    int[] result = new int[size];
    for (int i = 0; i < size; i++)
    {
        result[i] = new Random().Next(min, max + 1);
    }
    return result;
}

Console.WriteLine(String.Join(",", array));
Console.WriteLine($"Сумма позитивных чисел: {positiveSum}, сумма негативных чисел: {negativeSum}");
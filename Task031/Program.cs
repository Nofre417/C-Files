using System;
using static System.Console;

Clear();

WriteLine("Введите через пробел элемерты масива: ");
int[] array = GetArrayFromString(ReadLine());
GetAmontPositive(array);


int[] GetArrayFromString(string stringArray)
{
    string[] num = stringArray.Split(' ', StringSplitOptions.RemoveEmptyEntries);
    int[] result = new int[num.Length];
    for (int i = 0; i < result.Length; i++)
    {
        result[i] = int.Parse(num[i]);
    }
    return result;
}

void GetAmontPositive(int[] array)
{
    int result = 0;
    foreach (var item in array)
    {
        if (item > 0) result++;
    }
    WriteLine($"Количество положительных числе: {result}");
}
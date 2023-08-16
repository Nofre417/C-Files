using System;

Console.Clear();

Console.WriteLine(String.Join(".", GetNumsForArray(8)));

//String.Join - Позволяет вывести строку с заданым сеператором ( знаком ).

int[] GetNumsForArray(int size)
{
    int[] result = new int[size];
    for(int j = 0; j < size; j++)
    {
        result[j] = new Random().Next(0,2);
    }
    return result;
}


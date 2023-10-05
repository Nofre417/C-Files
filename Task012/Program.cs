using System;

Console.Clear();

Console.Write("Введите число: ");
int N = int.Parse(Console.ReadLine());
int result = GetAmountOfSing(N);
Console.WriteLine($"Количество знаков в заданном числе: {result}");

int GetAmountOfSing(int number)
{
    int count = 0;

    while (number > 0)
    {
        count++;
        number/=10;
        
    }
    return count;
}
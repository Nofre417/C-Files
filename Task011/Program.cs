using System;

Console.Clear();

Console.Write("Введите число N: ");
int N = int.Parse(Console.ReadLine());
int summa = GetSumOfNumber(N);
Console.WriteLine($"Сумма чисел от 0 до N: {summa}");

int GetSumOfNumber(int number)
{
    int sum = 0;

    for (int i = 0; i <= number; i++)
    {
        sum+=i;
    }
    return sum;
}
using System;

Console.Clear();

Console.Write("Введите число: ");
Console.WriteLine($"Факториал числа равен {GetFactorialOfNumber(int.Parse(Console.ReadLine()))}");

int GetFactorialOfNumber (int number)
{
    int sum = 1;

    for(int i = 1; i <= number; i++)
    {
        sum = sum * i;
    }
    return sum;
}
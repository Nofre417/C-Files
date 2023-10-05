using System;

Console.Clear();

Console.Write("Введите число: ");
int number = int.Parse(Console.ReadLine());
Console.WriteLine($"Сумма чисел числа равна: {GetSumOfNumber(number)}");


int GetSumOfNumber(int number)
{
    int result = 0;

    while(number > 0)
    {
        result += number % 10;
        number = number / 10;
    }
    return result;
}
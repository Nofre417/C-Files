using System;

Console.Clear();

Console.Write("Введите число: ");
int number1 = int.Parse(Console.ReadLine());
Console.Write("Введите степень: ");
int number2 = int.Parse(Console.ReadLine());

Console.WriteLine($"Результат:{GetNumber(number1, number2)}");

int GetNumber(int num1, int num2)
{
    int result = 1;

    for (int i = 0; i < num2; i++)
    {
        result *= num1;
    }
    return result;
}
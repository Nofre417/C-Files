using System;
using static System.Console;

Clear();

Write("Введите количество строк: ");
int rows = int.Parse(ReadLine());

PrintTriangle(rows);

void PrintTriangle(int value)
{
    for (int i = 0; i < value; i++)
    {
        for (int c = 0; c <= (value - i); c++)
        {
            Write(" ");
        }
        for (int c = 0; c <= i; c++)
        {
            Write(" ");
            Write(Factorial(i) / (Factorial(c) * Factorial(i - c)));
        }
        WriteLine();
    }
}

int Factorial(int number)
{
    int factorial = 1;

    for (int i = 1; i <= number; i++)
    {
        factorial *= i;
    }
    return factorial;
}
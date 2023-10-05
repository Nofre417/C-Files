using System;
using static System.Console;

Clear();

Write("Введите N: ");
int n = int.Parse(ReadLine());

PrintNumber(0, 1, n);


void PrintNumber(int a1, int a2, int size)
{
    Write($"{a1} {a2} ");
    for(int i = 0; i < size - 2; i++)
    {
        Write($"{a1 + a2} ");

        int k = a1 + a2;
        a1 = a2;
        a2 = k;
    }
}
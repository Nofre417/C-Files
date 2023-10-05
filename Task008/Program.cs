using System;

Console.Clear();

Console.Write("Введите ваше число: ");
int number = int.Parse(Console.ReadLine());
int count = 1;

while (count <= number)
{
    double value = Math.Pow(count, 3);
    Console.Write($"{value} ");
    count++;
}
using System;

Console.Clear();

Console.Write("Введите число: ");
Console.WriteLine($"Факториал числа равен {GetFactorialOfNumber(int.Parse(Console.ReadLine()))}");

<<<<<<< HEAD
int GetFactorialOfNumber(int number)
{
    int sum = 1;

    for (int i = 1; i <= number; i++)
=======
int GetFactorialOfNumber (int number)
{
    int sum = 1;

    for(int i = 1; i <= number; i++)
>>>>>>> 40fd661f659e87653741f1afe92d20370bd145e1
    {
        sum = sum * i;
    }
    return sum;
}
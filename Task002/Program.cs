using System;
using static System.Console;

Clear();

int Message (string message)
{
    Write(message);
    string value = ReadLine();
    int result = Convert.ToInt32(value);
    return result;
} 

int number = Message("Введите число > ");
if (number < 100)
{
    WriteLine("Третьей цифры нет");
    return;
}
WriteLine($"Введеное число = {number}");

int ThirdNum (int number)
{
    while (number > 999)
    {
        number /= 10;
    }
    return number % 10;
}

WriteLine($"Вторая цифра числа = " + ThirdNum(number));

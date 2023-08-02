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

int number = Message("Введите трехзначное число > ");
if (number < 100 || number > 1000)
{
    WriteLine("Вы ввели неверно число");
    return;
}
WriteLine($"Введеное число = {number}");
int secondnum = number / 10 % 10;
WriteLine($"Вторая цифра числа = {secondnum}");

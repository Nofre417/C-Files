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

bool IsWeekend(int Day)
{
    if (Day > 5) return true;
    return false;
}

bool IsValid(int number) 
{
    if (number > 0 && number < 8)
    {
        return true;
    }
    WriteLine("Это не день недели");
    return false;
}

int Day = Message("Введите день недели > ");
if (IsValid(Day))
{
    if (IsWeekend(Day))
    {
        WriteLine("Это выходной !");
    }
    else
    {
        WriteLine("Это рабочи день !");
    }
}
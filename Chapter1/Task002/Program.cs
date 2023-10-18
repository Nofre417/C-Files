using System;
using static System.Console;

Clear();

Person David = new();
David.birthDate = new(2002, 11, 19);

WriteLine($"Date of birth {nameof(David)} is {David.birthDate}.");

class Person
{
    public DateTime birthDate;
}
using System;
using static System.Console;

Clear();

/*
Write("Введите значение: ");
int number = int.Parse(ReadLine());

WriteLine(PrintNumbers(1, number));

string PrintNumbers(int start, int end)
{
    if (start == end) return start.ToString();
    return (start + " " + PrintNumbers(start + 1, end));
}
*/

/*
Write("Введите первое значение: ");
int first = int.Parse(ReadLine());

Write("Введите второе значение: ");
int last = int.Parse(ReadLine());

WriteLine(PrintNumbersDiaposon(first, last));

string PrintNumbersDiaposon(int first, int last)
{
    if (first == last) return first.ToString();
    return ((first++) + " " + PrintNumbers(first + 1, last));
}
*/

/*
Write("Введите значение: ");
int number = int.Parse(ReadLine());

WriteLine(Sum(number));

int Sum(int number)
{
    if (number == 0) return 0;
    return (number % 10 + Sum(number / 10));
}
*/

Write("Введите счисло: ");
int num = int.Parse(ReadLine());

Write("Введите степень: ");
int st = int.Parse(ReadLine());

WriteLine(Pow(num, st));

int Pow(int num, int st)
{
    if (st == 0) return 1;
    if (st == 1) return num;
    return (num * Pow(num, st - 1));
}
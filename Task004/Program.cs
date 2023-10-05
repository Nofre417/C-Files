using System;

Console.Clear();

Console.Write("Введите кординату X:");
int x = int.Parse(Console.ReadLine());
Console.Write("Введите кординату Y:");
int y = int.Parse(Console.ReadLine());

if (x > 0 && y > 0) Console.WriteLine("Первая четверть");
if (x < 0 && y > 0) Console.WriteLine("Вторая четверть");
if (x < 0 && y < 0) Console.WriteLine("Третья четверть");
if (x > 0 && y < 0) Console.WriteLine("Четвертая четверть");
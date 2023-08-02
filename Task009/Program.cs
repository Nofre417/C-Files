using System;

Console.Clear();

Console.Write("Введите значение X1: ");
int x1 = int.Parse(Console.ReadLine());
Console.Write("Введите значение Y1: ");
int y1 = int.Parse(Console.ReadLine());
Console.Write("Введите значение Z1: ");
int z1 = int.Parse(Console.ReadLine());

Console.Write("Введите значение X2: ");
int x2 = int.Parse(Console.ReadLine());
Console.Write("Введите значение Y2: ");
int y2 = int.Parse(Console.ReadLine());
Console.Write("Введите значение Z2: ");
int z2 = int.Parse(Console.ReadLine());


double d = Math.Sqrt(Math.Pow(x1 - x2, 2) + Math.Pow(y1 - y2, 2) + Math.Pow(z1 - z2, 2));

Console.WriteLine($"Длина отрезка равна {d:f2}");
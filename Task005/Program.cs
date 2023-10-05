using System;

Console.Clear();

Console.Write("Введите номер четверти: ");
int num = int.Parse(Console.ReadLine());

switch (num)
{
    case 1: {
        Console.WriteLine("x > 0, y > 0");
        break;
    }
    case 2: {
        Console.WriteLine("x < 0, y > 0");
        break;
    }
    case 3: {
        Console.WriteLine("x < 0, y < 0");
        break;
    }
    case 4: {
        Console.WriteLine("x > 0, y < 0");
        break;
    }
    default :{
        Console.WriteLine("Неверные данные");
        break;
    }
}
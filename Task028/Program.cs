using System;
using System.Runtime.InteropServices;
using static System.Console;

Clear();

Write("Введите число: ");
int n = int.Parse(ReadLine());
Write("Введите систему числения: ");
int sys = int.Parse(ReadLine());

string s2 = DecToNuns(n, sys);
WriteLine("Вывод: " + s2);

string DecToNuns(int number, int sys)
{
    string result = "";
    string chars = "0123456789ABCDEF";

    while (number > 0)
    {
        int k = number / sys;
        int ost = number - k * sys;
        result = chars[ost].ToString() + result;
        number /= sys;
    }
    return result;
}

/*
Write("Введите число: ");
int number = int.Parse(ReadLine());

int[] array = Conversion(number);

Write("Число в двоичном коде: " + String.Join(" ", array));



int[] Conversion(int number)
{
    int[] result = new int[]{};
    int index = 0;
    while(number > 0)
    {
        if((number / 2) == 0)
        {
            result[index] = 1;
            index++;
            number = number / 2; 
        }   
        else if ((number / 2) != 0)
        {
            result[index] = 0;
            index++;
            number = number - 1;
        }
        else if (number == 1)
        {   
            result[index] = 1;
        }
    }
    return result;
}
*/


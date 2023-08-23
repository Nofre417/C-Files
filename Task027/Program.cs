using System;
using static System.Console;

Clear();

Write("Введите сторону A: ");
int a = int.Parse(ReadLine());
Write("Введите сторону B: ");
int b = int.Parse(ReadLine());
Write("Введите сторону C: ");
int c = int.Parse(ReadLine());

if(FindTriangle(a, b, c)) WriteLine("Ответ: Истина!");
else WriteLine("Ответ: Ложь!"); 


bool FindTriangle(int A, int B, int C)
{
    bool result = false;

    if(A + B > C && A + C > B && B + C > A) result = true;
    else result = false;

    return result;
}
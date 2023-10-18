/*
Написать программу которая перечисляет числа от 0 до 100
если число делиться на 3 то выводим Fizz 
если число делиться на 5 то выводим Buzz
если число делиться и на 3 и на 5 то выводим FizzBuzz
сделать локаничный вывод
*/

using System;
using static System.Console;

Clear();

FizzBuzzGame();

void FizzBuzzGame() 
{
    for(int count = 1; count <= 100; count++) 
    {
        if(count % 3 == 0 && count % 5 == 0) 
        {
            Write("FizzBuzz, ");
        }
        else if(count % 3 == 0)
        {
            Write("Fizz, ");
        }
        else if(count % 5 == 0)
        {
            Write("Buzz, ");
        }
        else
        {
            Write($"{count}, ");
        }

        if(count % 10 == 0)
        {
            WriteLine();
        }
    }
}
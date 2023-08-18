using System;
using static System.Console;

Clear();

WriteLine("Введите через пробел элемерты масива: ");
int[] array = GetArrayFromString(ReadLine());

Write("Введите элемент для поиска: ");
int element = int.Parse(ReadLine());

if(FindElement(array, element))
{
    WriteLine("Да");
}
else
{
    WriteLine("Нет");   
}

int[] GetArrayFromString(string stringArray)
{
    string[] numS = stringArray.Split(' ', StringSplitOptions.RemoveEmptyEntries);
    int[] result = new int[numS.Length];
    for(int i = 0; i <result.Length; i++) 
    {
        result[i] = int.Parse(numS[i]);
    }
    return result;
}

bool FindElement(int[] inArray, int element)
{
    foreach(var item in inArray)
    {
        if(item == element) return true;
    }
    return false;
}
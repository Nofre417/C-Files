using System;
using static System.Console;

Clear();

WriteLine("Введите через пробел элемерты масива: ");
int[] array = GetArrayFromString(ReadLine());

Write(String.Join(", ", GetNewArray(array)));

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

int[] GetNewArray(int[] array)
{
    int size = array.Length / 2;
    if(array.Length % 2 == 1) size++;

    int[] temp = new int[size];

    for(int i = 0; i < array.Length /2; i++)
    {
        temp[i] = array[i] * array[array.Length - 1 - i];
    }

    if(array.Length % 2 == 1) temp[size - 1] = array[array.Length / 2];
    
   return temp;
}
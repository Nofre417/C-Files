using System;
using static System.Console;

Clear();

WriteLine("Введите через пробел элемерты масива: ");
int[] array = GetArrayFromString(ReadLine());
GetAmontPositive(array);


int[] GetArrayFromString(string stringArray)
{
    string[] num = stringArray.Split(' ', StringSplitOptions.RemoveEmptyEntries);
    int[] result = new int[num.Length];
<<<<<<< HEAD
    for (int i = 0; i < result.Length; i++)
=======
    for(int i = 0; i <result.Length; i++) 
>>>>>>> 40fd661f659e87653741f1afe92d20370bd145e1
    {
        result[i] = int.Parse(num[i]);
    }
    return result;
}

void GetAmontPositive(int[] array)
{
    int result = 0;
<<<<<<< HEAD
    foreach (var item in array)
    {
        if (item > 0) result++;
=======
    foreach(var item in array)
    {
        if(item > 0) result++;
>>>>>>> 40fd661f659e87653741f1afe92d20370bd145e1
    }
    WriteLine($"Количество положительных числе: {result}");
}
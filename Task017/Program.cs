using System;

Console.Clear();

int length = Message("Длина массива: ");
int minValue = Message("Минимальное значение: ");
int maxValue = Message("Максимальное значение: ");

Console.WriteLine(String.Join(",", GetNewArray(length, minValue, maxValue)));

int Message(string message)
{
    Console.Write(message);
    string ReadLine = Console.ReadLine();
    int result = int.Parse(ReadLine);
    return result;
}

int[] GetNewArray(int Length, int minNum, int maxNum)
{
    int[] array = new int[Length];
    Random random = new Random();

    for(int i = 0; i < Length; i++)
    {
        array[i] = random.Next(minNum, maxNum + 1);
    }
    return array;
}


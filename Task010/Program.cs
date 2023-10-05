using System;

Console.Clear();

<<<<<<< HEAD
int[] arr = { 1, 6, 3, 2, 7, 8, 4, 5, 9 };

void PrintArray(int[] array)
{
    int count = array.Length;
=======
int[] arr = {1, 6, 3, 2, 7, 8, 4, 5, 9};

void PrintArray(int[] array)
{
    int count  = array.Length;
>>>>>>> 40fd661f659e87653741f1afe92d20370bd145e1

    for (int i = 0; i < count; i++)
    {
        Console.Write($"{array[i]} ");
    }
    Console.WriteLine();
}

void SelectionSort(int[] array)
{
    for (int i = 0; i < array.Length - 1; i++)
    {
        int minPosition = i;

<<<<<<< HEAD
        for (int j = i + 1; j < array.Length; j++)
        {
            if (array[j] < array[minPosition]) minPosition = j;
=======
        for(int j = i + 1; j < array.Length; j++)
        {
            if(array[j] < array[minPosition]) minPosition = j;
>>>>>>> 40fd661f659e87653741f1afe92d20370bd145e1
        }

        int temporary = array[i];
        array[i] = array[minPosition];
        array[minPosition] = temporary;
    }
}


PrintArray(arr);

SelectionSort(arr);
<<<<<<< HEAD
PrintArray(arr);
=======
PrintArray(arr); 
>>>>>>> 40fd661f659e87653741f1afe92d20370bd145e1

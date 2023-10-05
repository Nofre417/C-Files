using System;
using System.Diagnostics.Tracing;
using static System.Console;

// Написать программу которая будет генерировать слова без смысла
// Количество знаков будет зависит от вода пользователя 

Clear();

// Ввод пользователя количество занков 
Write("Введите количество символов: ");
int symbols = int.Parse(ReadLine());

// Массив хранящий все возможные знаки
string chars = "abcdefghijklmnopqrstuvwxyz";

// Специальные символы
string space = " ";
string dot = ".";

//Пустая строка для вывода результата
//Вывод результата строки в консоль
string[] result = Generetic(symbols, chars);
//Write(String.Join("", result));

// WriteLine();
ForegroundColor = ConsoleColor.Green;
FormatingString(result, space, dot);
Write(String.Join("", result));
ForegroundColor = ConsoleColor.White;

//Функция генерации рандомных символов для заполнения результата
string[] Generetic(int symbols, string chars)
{
    string[] result = new string[symbols];

    for (int i = 0; i < symbols; i++)
    {
        Random random = new Random();
        int index = random.Next(0, chars.Length);

        result[i] = Convert.ToString(chars[index]);
    }

    return result;
}

//Функция форматирования уже готового результата (пробелы + точка + заглавная буква)
void FormatingString(string[] result1, string space, string dot)
{
    string[] result = result1;
    int index = GenereticRandomNum();
    int count = 0;

    while (count < result.Length - 2 && index < result.Length - 2)
    {
        result[index] = space;
        index += GenereticRandomNum();
        count++;
    }
    result[0] = result[0].ToUpper();
    result[result1.Length - 1] = dot;
}


//Функция генерации числа от 3 до 9 для построение слова
int GenereticRandomNum()
{
    Random random = new Random();
    int num = random.Next(3, 9);
    return num;
}

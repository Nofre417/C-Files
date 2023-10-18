//Написать программу которая запрашивает ввод с кансоли два числа 
//в промежутке от 0 до 255 и делит их друг на друга
//написать блок try-catch который будет отслеживать ошибки

using static System.Console;


Write("Enter first number (0 - 255): ");
string? firstNumber = ReadLine();
WriteLine();
Write("Enter second number (0 - 255): ");
string? secondNumber = ReadLine();

try
{
    byte a = byte.Parse(firstNumber);
    byte b = byte.Parse(secondNumber);
    WriteLine($"Result is: {a / b}");
}
catch(OverflowException)
{
    WriteLine("You entered number to big or to small !");
}
catch (FormatException)
{
    WriteLine("You entered wrong digits !");
}

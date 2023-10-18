using static System.Console;

Clear();

while (true)
{
    Write("Enter amount: ");
    string? amont = ReadLine();

    try
    {
        decimal amontValue = decimal.Parse(amont);
    }
    catch (FormatException) when (amont.Contains("$"))
    {
        WriteLine("You cannot use ($) sign !");
    }
    catch (FormatException)
    {
        WriteLine("You entered wrong digits !");
    }
}

ReadLine();
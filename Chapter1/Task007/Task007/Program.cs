//Написать программу которая будет считать НДС в зависимости от стран.
//Буду использовать код страны: RU, UA, CH, AM, DK, FR

using static System.Console;

Write("Enter amount: ");
decimal moneyAmont = decimal.Parse(ReadLine());

WriteLine("Region codes: RU, UA, CH, AM, DK, FR");
Write("Enter region code: ");
string regionCode = ReadLine();

decimal amountAfterTax =  CalculateTax(moneyAmont, regionCode);
WriteLine($"Amount before tax: {moneyAmont}$ \nAmount after tax: {amountAfterTax}$");


/// <summary>
/// Method to calculate entered amount after tax with depends of region code.
/// <param name="moneyBefore">Amount of money for calculation</param>
/// <param name="regionCode">Code for switch function</param>
/// </summary>
static decimal CalculateTax(decimal moneyBefore, string regionCode)
{
    decimal rate = 0.00M;

    switch (regionCode)
    {
        case "RU":
            rate = 0.12M;
            break;
        case "UA":
            rate = 0.087M;
            break;
        case "CH":
            rate = 0.072M;
            break;
        case "AM":
            rate = 0.0128M;
            break;
        case "DK":
            rate = 0.276M;
            break;
        case "FR":
            rate = 0.1433M;
            break;
        default:
            WriteLine("Please check entered amount and code again !");
            break;

        
    }
    return (moneyBefore) -  (moneyBefore * rate);
}
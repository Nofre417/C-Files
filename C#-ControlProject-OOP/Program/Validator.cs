using System.Text.RegularExpressions;

namespace Calculator
{
    public class Validator : IValidation
    {
        public bool isValidNumber(string message)
        {     
            return Regex.IsMatch(message, @"^[1-9]\d*$");
        }

        public bool isValidSing(string message)
        {
            return Regex.IsMatch(message, @"^[+=/*YyNn]$");
        }
    }
}

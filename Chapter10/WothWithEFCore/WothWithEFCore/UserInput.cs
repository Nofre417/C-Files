using static System.Console;

namespace WothWithEFCore
{
    public class UserInput
    {
        public int inputInt(string line)
        {
            int number;
            do
            {
                Write($"{line} ");
            }
            while (!int.TryParse(ReadLine(), out number));

            return number;
        }

        public decimal inputDecimal(string line)
        {
            decimal value;
            do
            {
                Write($"{line} ");
            }
            while (!decimal.TryParse(ReadLine(), out value));

            return value;

        }

        public string inputString(string line)
        {
            Write($"{line} ");
            return ReadLine();
        }
    }
}
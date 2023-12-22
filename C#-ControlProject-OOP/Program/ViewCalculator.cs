using static System.Console;

namespace Calculator
{
    public class ViewCalculator
    {
        private ICalculableFactory calculableFactory;
        Validator validator = new();

        public ViewCalculator(ICalculableFactory calculableFactory)
        {
            this.calculableFactory = calculableFactory;
        }

        public void Run()
        {
            while (true)
            {
                PaintConsole(reset: true);
                int primaryArg = inputInt("Enter argument: ");
                ICalculable calculator = calculableFactory.create(primaryArg, true);
                while (true)
                {
                    string command = input("Choose sign (*, +, /, =): ");
                    if (command == "*")
                    {
                        int arg = inputInt("Enter argument: ");
                        calculator.multiply(arg);
                        continue;
                    }
                    if (command == "+")
                    {
                        int arg = inputInt("Enter argument: ");
                        calculator.sum(arg);
                        continue;
                    }
                    if (command == "/")
                    {
                        int arg = inputInt("Enter argument: ");
                        calculator.divide(arg);
                        continue;
                    }
                    if (command == "=")
                    {
                        int result = calculator.getResult();
                        calculator.saveToList(result);
                        calculator.printLogFile();
                        PaintConsole(ConsoleColor.Yellow);
                        WriteLine("\n=========================\n");
                        WriteLine("\u001b[1mRESULT: " + result);
                        PaintConsole(reset: true);
                        break;
                    }
                }
                PaintConsole(ConsoleColor.Cyan);
                string cmd = input("\nCalculate more (Y/N)? ", check: false);
                PaintConsole(reset: true);
                if (cmd.ToUpper() == "Y")
                {
                    Clear();
                    continue;
                }
                break;              
            }
        }

        private string input(string message, bool check = true)
        {
            Write(message);
            string inputLine = ReadLine();
            string sing = "";

            if (!check) return inputLine;

            if (validator.isValidSing(inputLine))
            {
                sing = inputLine;
            }
            else
            {
                PaintConsole(ConsoleColor.Red);
                WriteLine($"Input is not correct !");
                PaintConsole(reset: true);
            }
            return sing;
        }
            
        

        private int inputInt(string message)
        {
            Write(message);
            string inputLine = ReadLine();
            int number = 0;

            if (validator.isValidNumber(inputLine))
            {
                number = int.Parse(inputLine);
            }
            else
            {
                PaintConsole(ConsoleColor.Red);
                WriteLine($"Input is not correct !");
                PaintConsole(reset: true);
            }
            return number;
        }

        private void PaintConsole(ConsoleColor color = ConsoleColor.White)
        {
            ForegroundColor = color;
        }

        private void PaintConsole(bool reset)
        {
            if (reset)
            {
                ForegroundColor = ConsoleColor.White;
            }
        }
    }
}

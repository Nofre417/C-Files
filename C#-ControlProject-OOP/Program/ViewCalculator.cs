using System.Collections.Generic;
using System.Data;
using System.Diagnostics.Metrics;
using System.Runtime.CompilerServices;
using static System.Console;

namespace Calculator
{
    public class ViewCalculator
    {
        private ICalculableFactory calculableFactory;

        public ViewCalculator(ICalculableFactory calculableFactory)
        {
            this.calculableFactory = calculableFactory;
        }

        public void Run()
        {
            while (true)
            {
                int primaryArg = inputInt("Enter argument: ");
                ICalculable calculator = calculableFactory.create(primaryArg, true);
                while (true)
                {
                    string command = input("Choose sign (*, +, /, =) : ");
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
                        ForegroundColor = ConsoleColor.Yellow;
                        WriteLine("\u001b[1mRESULT: " + result);
                        ForegroundColor = ConsoleColor.White;
                        break;
                    }
                }
                ForegroundColor = ConsoleColor.Cyan;
                string cmd = input("Calculate more (Y/N)? ");
                ForegroundColor = ConsoleColor.White;
                if (cmd.ToUpper() == "Y")
                {
                    continue;
                }
                break;
            }
        }

        private string input(string message)
        {
            Write(message);
            return ReadLine();
        }

        private int inputInt(string message)
        {
            Write(message);
            return int.Parse(ReadLine());
        }
    }
}

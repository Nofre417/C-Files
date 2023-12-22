using static System.IO.Path;
using static System.IO.Directory;
using static System.Console;
using static System.Environment;

namespace Calculator
{
    public class Repository : IRepository, IRepositoryService
    {

        string path = Combine(CurrentDirectory, "CalculatorLog.txt");

        public void createLogFile()
        {
            using(StreamWriter writer = new StreamWriter(path, false)) { }
        }

        

        public void readFromFile()
        {
            if (!File.Exists(path)) createLogFile();

            using (StreamReader reader = File.OpenText(path))
            {
                ForegroundColor = ConsoleColor.DarkGray;
                int operations = 3;
                Write($"\n* Last {operations} operations:\n");

                string[] allLines = File.ReadAllLines(path);
                string[] lastOperations = allLines.Skip(allLines.Length  - (operations * 2)).ToArray();

                foreach (string line in lastOperations)
                {
                    WriteLine("\t" + line);
                }
                ForegroundColor = ConsoleColor.White;
            }
        }

        public void saveToFile(List<string> items)
        {
            if (!File.Exists(path)) createLogFile();

            clearAllFileText();

            using (StreamWriter writer = new StreamWriter(path, true))
            {
                writer.Write("Operation: ");
                foreach (string item in items)
                {
                    writer.Write(item);
                }
                writer.WriteLine("\nTime: " + DateTime.Now);
            }
        }

        public void clearAllFileText()
        {
            if (File.Exists(path))
            {
                string[] lines = File.ReadAllLines(path);
                int linesAmount = lines.Length / 2;
                if (linesAmount >= 10) createLogFile();
            }
        }
    }
}

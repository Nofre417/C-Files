using static System.IO.Path;
using static System.IO.Directory;
using static System.Console;
using static System.Environment;

namespace Calculator
{
    public class Repository : IRepository
    {
        public Repository() { }

        string path = Combine(CurrentDirectory, "CalculatorLog.txt");
        public void createLogFile()
        {
            using(StreamWriter writer = new StreamWriter(path, true)) { }
        }

        

        public void readFromFile()
        {
            using (StreamReader reader = new StreamReader(path))
            {
                ForegroundColor = ConsoleColor.DarkGray;
                Write("Log list:\n");
                string line = reader.ReadLine();
                ForegroundColor = ConsoleColor.White;
            }
        }

        public void saveToFile(string line)
        {
            using (StreamWriter writer = new StreamWriter(path, true))
            {
                writer.WriteLine(line);
            }
            
        }

        public void clearAllFile()
        {
            using (StreamWriter writer = new StreamWriter(path, true)) { }
        }
    }
}

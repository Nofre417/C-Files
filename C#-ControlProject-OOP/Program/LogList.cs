namespace Calculator
{
    public class LogList : ILogList
    {
        List<string> logList = new();

        public LogList() { }

        public void appendItem(string line)
        {
            logList.Add(line);
        }

        public List<string> getList()
        {
            return logList;
        }

        public void PrintList()
        {
            foreach (var item in getList())
            {
                Console.Write(item);
            }
            Console.WriteLine();
        }
    }
}

namespace Calculator
{
    public class Calculator : ICalculable
    {
        private int primaryArg;

        LogList logList = new();
        Repository repository = new(); 
        
        public Calculator(int primaryArg)
        {
            this.primaryArg = primaryArg;
            logList.appendItem(Convert.ToString(primaryArg));
        }

        public ICalculable divide(int arg)
        {
            primaryArg /= arg;
            logList.appendItem(Convert.ToString(" / " + arg));
            return this;
        }

        

        public ICalculable multiply(int arg)
        {
            primaryArg *= arg;
            logList.appendItem(Convert.ToString(" * " + arg));
            return this;
        }

        public ICalculable sum(int arg)
        {
            primaryArg += arg;
            logList.appendItem(Convert.ToString(" + " + arg));
            return this;
        }

        public int getResult()
        {
            return primaryArg;
        }

        public void saveToList(int result)
        {
            logList.appendItem(Convert.ToString(" = " + result));
            repository.saveToFile(logList.getList());
            logList.PrintList();
        }

        public void printLogFile()
        {
            repository.readFromFile();
        }
    }
}

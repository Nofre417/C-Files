using static System.Console;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Logging;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.ChangeTracking;
using Microsoft.EntityFrameworkCore.Metadata.Internal;

namespace WothWithEFCore
{

    public class UserUI
    {
        Services services = new();
        UserInput userInput = new();
        DBServices dBServices = new();
        ListProducts listProducts = new();

        bool Flag = false;
        int command;

        public void Run()
        {
            services.StarProgram();
            PrintList();
            command = userInput.inputInt("Choose action:");
            Actions(command);
            Continue();
            Run();
        }

        void PrintList()
        {
            WriteLine("Action List");
            WriteLine("> 1 - Print products list" +
            "\n> 2 - Add new product" +
            "\n> 3 - Increase product price" +
            "\n> 4 - Update product price" +
            "\n> 5 - Delete product" +
            "\n> 6 - Print actions list" +
            "\n> 0 - Finish program");
        }

        void Actions(int command)
        {
            if (command == 0) Environment.Exit(0);
            if (command == 1) listProducts.GetListProducts();
            if (command == 2) dBServices.AddProduct();
            if (command == 3) dBServices.IncreasePrice();
            if (command == 4) dBServices.UpdatePrice();
            if (command == 5) dBServices.DeleteProduct();
            if (command == 6) Run();
        }
        void Continue()
        {
            ConsoleKeyInfo keyInfo;
            WriteLine("\nPRESS ENTER TO CONTINUE\n");
            do
            {
                keyInfo = ReadKey();
            }
            while (!(keyInfo.Key == ConsoleKey.Enter));
        }
    }
}
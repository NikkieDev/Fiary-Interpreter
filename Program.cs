using System;

namespace Fiary
{
    class Program
    {
        async static Task Main(String[] args)
        {
            String[] ConfirmedArgs = args;

            FileHandler FileHandlerObj = new FileHandler();
            Files FilesObj = new Files();

            await FilesObj.Initialize();

            if (ConfirmedArgs == null)
            {
                Console.WriteLine("No file selected");
                return;
            }

            FileHandlerObj.ParseFile(ConfirmedArgs[0]);
        }
    }
}
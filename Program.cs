using System;

namespace Fiary
{
    class Program
    {
        static void Main(String[] args)
        {
            FileHandler FileHandlerObj = new FileHandler();
            Files FilesObj = new Files();

            FilesObj.Initialize();

            if (args[0] == null)
            {
                Console.WriteLine("No file selected");
                return;
            }

            FileHandlerObj.ParseFile(args[0]);
        }
    }
}
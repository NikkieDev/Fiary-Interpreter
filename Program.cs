using System;

namespace Fiary
{
    class Program
    {
        async static Task Main(String[] args)
        {
            Console.Clear();
            ErrorHandler ErrorHandlerObj = new ErrorHandler();
            FileHandler FileHandlerObj = new FileHandler();
            Files FilesObj = new Files();

            await FilesObj.Initialize();

            try
            {
                await FileHandlerObj.ParseFile(args[0]);
            }
            catch (Exception e)
            {
                await ErrorHandlerObj.AddErr(e);
                Console.WriteLine(ErrorHandlerObj.CreateErrLog());
            }
        }
    }
}
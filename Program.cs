using System;

namespace Fiary
{
    class Program
    {
        static void Main(String[] args)
        {
            Handler handler = new Handler();

            if (args[0] == null)
            {
                Console.WriteLine("No file selected");
                return;
            }

            handler.ParseFile(args[0]);
        }
    }
}
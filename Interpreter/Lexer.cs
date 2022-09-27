using System;

namespace Fiary
{
    class Lexer
    {
        internal List<String> Interpret(String[] Data)
        {
            List<String> InterpretedData = new List<String>();
            
            foreach (String line in Data)
            {
                Console.WriteLine(line[0]);
            }

            return InterpretedData;
        }
    }
}
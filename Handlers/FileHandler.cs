using System.Text.Json;
using System.IO;

namespace Fiary
{
    class FileHandler
    {
        private static ErrorHandler ErrHandler = new ErrorHandler();
        async internal Task ParseFile(String FileName) // Possible filetype later
        {
            Lexer LexerObj = new Lexer();
            List<String> FileData = new List<String>();

            try
            {
                String[] DataArray = File.ReadAllLines(FileName);
                for (int i = 0; i < DataArray.Length; i++)
                    FileData.Add(DataArray[i]);
            } catch (FileNotFoundException e)
            {
                Console.WriteLine($"File: \"{FileName}\" couldn't be found.");
                await ErrHandler.AddErr(e);
            }
            
            if (FileData == null)
            {
                Console.WriteLine($"File: \"{FileName}\" does not contain any data.");
                return;
            }

            List<String> FileDataList = new List<String>();

            LexerObj.Interpret(FileData.ToArray());
        }
    }
}
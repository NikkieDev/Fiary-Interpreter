using System.Text.Json;
using System.IO;

namespace Fiary
{
    class Handler
    {
        internal void ParseFile(String FileName) // Possible filetype later
        {
            String FileData = "";
            Lexer LexerObj = new Lexer();

            try
            {
                FileData = File.ReadAllText(FileName);
            } catch (FileNotFoundException e)
            {
                Console.WriteLine($"File: \"{FileName}\" couldn't be found.");
                ErrHandler.AddErr(e);
            }
            
            if (FileData == "")
            {
                Console.WriteLine($"File: \"{FileName}\" does not contain any data.");
                return;
            }

            List<String> FileDataList = new List<String>();

            for (int i = 0; i < FileData.Length; i++)
            {
                FileDataList.Add(FileData[i].ToString());
            }

            String[] FileDataArray = FileDataList.ToArray();
            LexerObj.Interpret(FileDataArray);
        }
    }
}
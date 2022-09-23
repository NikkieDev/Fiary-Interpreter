using System.Text.Json;
using System.IO;

namespace Fiary
{
    class Handler
    {
        internal void ParseFile(String FileName) // Possible filetype later
        {
            String FileData = "";

            try
            {
                FileData = File.ReadAllText(FileName);
            } catch (FileNotFoundException e)
            {
                Console.WriteLine($"File: \"{FileName}\" couldn't be found.");
            }
            
            if (FileData == "")
            {
                Console.WriteLine($"File: \"{FileName}\" does not contain any data.");
                return;
            }
        }
    }
}
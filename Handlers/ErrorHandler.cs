using System.IO;

namespace Fiary
{
    class ErrorHandler
    {
        private static List<dynamic> ErrorList = new List<dynamic>();
        internal void AddErr(dynamic Error)
        {
            ErrorList.Add(Error);
        }
        async internal Task CreateErrLog()
        {
            String Dir = Environment.GetFolderPath(Environment.SpecialFolder.ApplicationData) + "/NikkieDev Software/FSF/errors";
            int i = 0;
            int FileAmount = Directory.GetFiles(Dir).Count();

            while (i < FileAmount)
            {
                i++;
            }

            var _File = File.Create($"errorlog{i}.txt");
            _File.Close();
            
            for (int j = 0; j < ErrorList.Count; j++)
            {
                await File.AppendAllTextAsync($"{Dir}/errorlog{i}.txt", ErrorList[i]);
            }
        }

        // loop through amount of files. add i to filename
    }
}
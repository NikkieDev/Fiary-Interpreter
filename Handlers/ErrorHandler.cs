using System.IO;

namespace Fiary
{
    class ErrorHandler
    {
        private static List<String> ErrorList = new List<String>();
        async internal Task AddErr(Exception Error)
        {
            await Task.Run(() => ErrorList.Add(Error.ToString()));
            return;
        }
        internal String CreateErrLog()
        {
            String Dir = Environment.GetFolderPath(Environment.SpecialFolder.ApplicationData) + "/NikkieDev Software/FSF/errors";
            int i = 0;
            int FileAmount = Directory.GetFiles(Dir).Count();

            while (i < FileAmount)
            {
                i++;
            }

            var _File = File.Create($"{Dir}/errorlog{i}.txt");
            _File.Close();
            
            for (int j = 0; j < ErrorList.Count; j++)
            {
                File.AppendAllText($"{Dir}/errorlog{i}.txt", ErrorList[j]);
            }
            return $"Created error log file at: \"{Dir}/errorlog{i}.txt\"";
        }

        // loop through amount of files. add i to filename
    }
}
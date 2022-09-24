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
            int i = 0;
            int FileAmount = Directory.GetFiles(Environment.GetFolderPath(Environment.SpecialFolder.ApplicationData) + "/NikkieDev Software/FSF/errors").Count();
            while (i < FileAmount)
            {
                i++;
            }
        }

        // loop through amount of files. add i to filename
    }
}
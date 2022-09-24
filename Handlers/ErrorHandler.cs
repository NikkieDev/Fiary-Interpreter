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

        }

        // loop through amount of files. add i to filename
    }
}
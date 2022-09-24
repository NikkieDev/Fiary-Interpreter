using System.IO;
using ND_AppData;

namespace Fiary
{
    class Files
    {
        async internal Task Initialize()
        {
            String[] Folders = {"FSF", "FSF/errors"};
            await AppDataFolders.Initialize(Folders);
        }
    }
}
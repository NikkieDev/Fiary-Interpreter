using System.IO;
using ND_Data;

namespace Fiary
{
    class Files
    {
        async internal Task Initialize()
        {
            String[] Folders = {"FSF", "FSF/errors"};
            await AppDataFolder.Initialize(Folders);
        }
    }
}
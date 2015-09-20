using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FolderCleanup
{
    class Controller
    {
        Functions functions = new Functions();
        Whitelist whitelist = new Whitelist();

        public string[] getWhitelist()
        {
            return whitelist.getWhitelist();
        }

        public void moveFile(string pathOriginal, string pathBackup)
        {
            functions.moveFile(pathOriginal, pathBackup);
        }

        public string[] getFiles(string pathOriginal)
        {
            return functions.getFiles(pathOriginal);
        }

        public string[] getRpfFiles(string pathOriginal)
        {
            return functions.getRpfFiles(pathOriginal);
        }

        public void moveFilesBack(string pathOriginal, string pathBackup)
        {
            functions.moveFilesBack(pathOriginal, pathBackup);
        }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace FolderCleanup
{
    class Functions
    {
        public void moveFile(string pathOriginal, string pathBackup)
        {
            if (!File.Exists(pathBackup))
            {
                System.IO.File.Move(pathOriginal, pathBackup);
            }
            else
            {
                Console.WriteLine("File derping in destination folder");
            }
         
        }

        public void backupFiles(string pathOriginal, string pathBackup)
        {
            if (!File.Exists(pathBackup))
            {
                System.IO.File.Copy(pathOriginal, pathBackup);
            }
            else
            {
                Console.WriteLine("File derping in destination folder");
            }
        }

        public string[] getFiles(string pathOriginal)
        {
            string[] path = Directory.GetFiles(pathOriginal, "*", SearchOption.AllDirectories);         
            return path;
        }

        public string[] getRpfFiles(string pathOriginal)
        {
            string[] path = Directory.GetFiles(pathOriginal, "*.Rpf", SearchOption.AllDirectories);

            string[] newPath = new string[path.Length];

            for (int i = 0; i < path.Length; i++)
            {
                newPath[i] = path[i].Replace(pathOriginal, "");
            }

            return newPath;
        }

        public void moveFilesBack(string pathOriginal, string pathBackup)
        {

        }
           
    }
}

using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;

namespace FolderCleanup
{
    public partial class MainWindow : Form
    {
        Controller controller = new Controller();
        public MainWindow()
        {
            InitializeComponent();
   
        }

        private void buttonMods_Click(object sender, EventArgs e)
        {
            string pathOriginal = textBoxPathOriginal.Text;
            string[] allFiles = controller.getFiles(pathOriginal);
            string[] allRpfFiles = controller.getRpfFiles(pathOriginal);

            foreach (var item in allRpfFiles)
            {
                Console.WriteLine(item.ToString());      
            }

            checkedListBoxRpfFiles.Items.AddRange(controller.getRpfFiles(pathOriginal));
        }

        private void buttonNoMods_Click(object sender, EventArgs e)
        {
            string pathOriginal = textBoxPathOriginal.Text;
            string pathBackup = @"C:\Users\Jonas\Desktop\testmapp1";
            string[] files = controller.getFiles(pathOriginal);
            string[] whitelist = controller.getWhitelist();

            foreach (var item in files)
            {
                if (whitelist.Contains(Path.GetFileName(item)))
                {
                    Console.WriteLine(item.ToString() + " = original file");
                }
                else
                {
                    Console.WriteLine(item.ToString() + " = mod file");
                    Console.WriteLine("Moving file");

                    DirectoryInfo di = Directory.CreateDirectory(pathBackup + Path.GetDirectoryName(item).Replace(pathOriginal, ""));

                    string pathBackupTemp = pathBackup + Path.GetDirectoryName(item).Replace(pathOriginal, "") +"/" + Path.GetFileName(item);
                    controller.moveFile(item.ToString(), pathBackupTemp);
                    Console.WriteLine("File moved to " + pathBackupTemp);
                }

            }
        }

        private void textBoxPath_TextChanged(object sender, EventArgs e)
        {

        }

        private void buttonBackup_Click(object sender, EventArgs e)
        {

        }
    }
}

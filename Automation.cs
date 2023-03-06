using System;
using System.Collections.Generic;
using System.Text;

namespace Automate
{
    public class Automation
    {
        public void DeleteAllTempFiles(string path)
        {
            DirectoryInfo directoryInfo = new DirectoryInfo(path);
            FileInfo[] s = directoryInfo.GetFiles();
            for (int i = 0; i < s.Length; i++)
            {
                if (!fileIsOpened(s[i].FullName))
                {
                    File.Delete(s[i].FullName);
                }
            }
            System.Console.WriteLine("All Temp Files is Deleted from this path {0}", path);
        }

        private bool fileIsOpened(string path)
        {
            try
            {
                FileStream fs = new FileStream(path, FileMode.OpenOrCreate, FileAccess.Read);
                fs.Close();
                return false;
            }
            catch (IOException ex)
            {
                return true;
            }
        }

        public void DeleteAllTempDirectories(string path)
        {
            DirectoryInfo d = new DirectoryInfo(path);
            DirectoryInfo[] v = d.GetDirectories();
            for (int i = 0; i < v.Length; i++)
            {
                DeleteDirectory(v[i].FullName);
            }

            System.Console.WriteLine("All Temp Directories is Deleted from this path {0}", path);
        }

        private void DeleteDirectory(string path)
        {
            try
            {
                Directory.Delete(path);
            }
            catch (IOException ex)
            {
                return;
            }
        }
    }
}
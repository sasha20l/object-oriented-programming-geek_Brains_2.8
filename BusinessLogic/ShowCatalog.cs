using System;
using System.Collections.Generic;
using System.IO;
using System.Text;

namespace BusinessLogic
{
    public class ShowCatalog
    {

        public IEnumerable<string> ShowAllFilesInCatalog(string path)
        {

            if (Directory.Exists(path))
            {
                Console.WriteLine("Подкаталоги:");
                string[] dirs = Directory.GetDirectories(path);
                foreach (string s in dirs)
                {
                    Console.WriteLine(s);
                }
                Console.WriteLine();
                Console.WriteLine("Файлы:");
                string[] files = Directory.GetFiles(path);
                foreach (string s in files)
                {
                    Console.WriteLine(s);
                }
            }

            return null;
        }
    }
}

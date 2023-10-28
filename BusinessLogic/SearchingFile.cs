using System;
using System.Collections.Generic;
using System.IO;
using System.Text;

namespace BusinessLogic
{
    public class SearchingFile
    {
        string[] result;

        public void searchOfTheFile(string path, string nameFile)
        {
            result = Directory.GetFiles(path, nameFile);
            show();
        }

        public void findingFolder(string path, string nameFile)
        {
            result = Directory.GetDirectories(path, nameFile);
            show();
        }

        void show()
        {
            if (result != null)
            {
                Console.WriteLine("Найдено:");
                foreach (string s in result)
                {
                    Console.WriteLine(s);
                }
                Console.WriteLine();
            }

        }


    }
}

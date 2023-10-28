
using System;
using System.Collections.Generic;
using System.IO;
using System.Text;

namespace BusinessLogic
{
    public class Delete
    {

        DirectoryInfo dirInfo;


        public void DeleteCatalog(string path)
        {
            dirInfo = new DirectoryInfo(path);
            if (dirInfo.Exists)
            {
                dirInfo.Delete(true);
                Console.WriteLine("Каталог удален");
            }
            else
            {
                Console.WriteLine("Каталог не существует");
            }
        }

        public void DeleteFile(string path)
        {
            FileInfo fileInf = new FileInfo(path);
            if (fileInf.Exists)
            {
                fileInf.Delete();
                Console.WriteLine("Файл удален");
            }
            else
            {
                Console.WriteLine("Файл не существует");
            }
        }



    }
}

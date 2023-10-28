using System;
using System.Collections.Generic;
using System.IO;
using System.Text;

namespace BusinessLogic
{
    public class Create
    {

        public void CreateCatalog(string path, string subpath)
        {
            if (!Directory.Exists(path))
            {
                Directory.CreateDirectory(path);
            }
            Directory.CreateDirectory($"{path}/{subpath}");
        }

        public void CreateFile(string path)
        {
            File.Create(path);
        }
    }
}

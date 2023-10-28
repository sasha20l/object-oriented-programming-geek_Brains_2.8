using System;
using System.Collections;
using System.Collections.Generic;
using System.IO;
using System.Text;

namespace BusinessLogic
{
    public class СalculateSize
    {
        public void SizeFile(string path)
        {
            Console.WriteLine(new FileInfo(path).Length);
        }

        public void SizeCatalog(string path)
        {
            IEnumerable dirSize = SafeEnumerateFiles(path, "*.*", SearchOption.AllDirectories);
            long sum = 0;
            foreach (string a in dirSize)
            {
                sum += new FileInfo(a).Length;
            }
            Console.WriteLine(sum);
        }


        private static IEnumerable SafeEnumerateFiles(string path, string searchPattern = ".", SearchOption searchOption = SearchOption.TopDirectoryOnly)
        {
            var dirs = new Stack(); dirs.Push(path);
            while (dirs.Count > 0)
            {
                string currentDirPath = (string)dirs.Pop();
                if (searchOption == SearchOption.AllDirectories)
                {
                    try
                    {
                        string[] subDirs = Directory.GetDirectories(currentDirPath);
                        foreach (string subDirPath in subDirs)
                        {
                            dirs.Push(subDirPath);
                        }
                    }
                    catch (UnauthorizedAccessException)
                    {
                        continue;
                    }
                    catch (DirectoryNotFoundException)
                    {
                        continue;
                    }
                }

                string[] files = null;
                try
                {
                    files = Directory.GetFiles(currentDirPath, searchPattern);
                }
                catch (UnauthorizedAccessException)
                {
                    continue;
                }
                catch (DirectoryNotFoundException)
                {
                    continue;
                }

                foreach (string filePath in files)
                {
                    yield return filePath;
                }
            }
        }
    }
}

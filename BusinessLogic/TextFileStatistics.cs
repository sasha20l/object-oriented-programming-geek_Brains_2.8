using System;
using System.Collections.Generic;
using System.IO;
using System.Text;

namespace BusinessLogic
{
    public class TextFileStatistics
    {
        async public void Staics(string path)
        {
            int strings = 0;

            using (StreamReader reader = new StreamReader(path))
            {
                string line;
                while ((line = await reader.ReadLineAsync()) != null)
                {
                    strings++;
                }
                Console.WriteLine("Количество строк в вайле " + strings);
            }


        }
    }
}
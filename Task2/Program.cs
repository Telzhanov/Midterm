using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task2
{
    class Program
    {
        static void Main(string[] args)
        {
            string text;
            string directory;
            directory = Console.ReadLine();
            DirectoryInfo di = new DirectoryInfo(@"" + directory);
            FileSystemInfo[] files = di.GetFileSystemInfos();
            for (int i = 0; i < files.Length; i++)
            {
                using (FileStream fs = new FileStream(files[i].FullName, FileMode.Open, FileAccess.Read))
                {
                    using (StreamReader sr = new StreamReader(fs))
                    {
                        while ((text = sr.ReadLine()) != null)
                        {
                            for (int j = 0; j < text.Length; j++)
                            {
                                if (text[j] == 'a' && text[j + 1] == 'b' && text[j + 2] == 'c' && text[j + 3] == 'd')
                                {
                                    Console.WriteLine(files[i].Name);
                                }
                            }

                        }

                    }
                }
            }
            Console.ReadKey();
        }
    }
}

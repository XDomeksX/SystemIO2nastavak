using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace SystemIO_2
{
    internal class KlasaInfo
    {
        static void Main(string[] args)
        {
            DirectoryInfo di = new DirectoryInfo(@"D:\Visual Studio\C#\SystemIO_2");

            Console.WriteLine("\n Poddirektoriji: ");

            foreach(DirectoryInfo diInfo in di.GetDirectories())
            {
                Console.WriteLine("{0}\t{1}\t{2}", diInfo.Name, diInfo.CreationTime, diInfo.LastAccessTime);
            }

            foreach(FileInfo fiInfo in di.GetFiles())
            {
                Console.WriteLine("{0}\t{1}\t{2}", fiInfo.Name, fiInfo.CreationTime, fiInfo.LastAccessTime);
            }

            Console.ReadKey();
        }
    }
}

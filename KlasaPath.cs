using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace SystemIO_2
{
    internal class KlasaPath
    {
        static void Main(string[] args)
        {
            string prviDirektorij = @"D:\Visual Studio\C#\SystemIO_2\prviDir";  //ili @ ili \\ da prepozna da je u pitanju backslash
            string drugiDirektorij = @"D:\Visual Studio\C#\SystemIO_2\drugiDir";

            if (!Directory.Exists(prviDirektorij))
            {
                Directory.CreateDirectory(prviDirektorij);
            }
            if (!Directory.Exists(drugiDirektorij))
            {
                Directory.CreateDirectory(drugiDirektorij);
            }

            string[] nazivi = new string[5];

            for(int i = 0; i < 5; i++)
            {
                nazivi[i] = "Datoteka" + i;
                if (!File.Exists(@"D:\Visual Studio\C#\SystemIO_2\prviDir\" + nazivi[i]))
                {
                    File.Create(@"D:\Visual Studio\C#\SystemIO_2\prviDir\" + nazivi[i]);
                }
            }

            try
            {
                foreach (string datoteka in Directory.GetFiles(prviDirektorij))
                {
                    string imeDatoteke = Path.GetFileName(datoteka);
                    string ciljanaDatoteka = Path.Combine(drugiDirektorij, imeDatoteke);

                    File.Copy(datoteka, ciljanaDatoteka, true);
                }

                Console.WriteLine("Gotovo!");
            }
            catch (Exception greska)
            {
                Console.WriteLine("Greška: {0}", greska.Message);
            }

            Console.ReadKey();
        }
    }
}

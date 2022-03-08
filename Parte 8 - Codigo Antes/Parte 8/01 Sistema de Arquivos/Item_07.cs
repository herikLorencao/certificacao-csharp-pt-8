using System;
using System.IO;

namespace Listings
{
    class Item_07 //Informações do drive
    {
        static void XMain(string[] args)
        {
            //TAREFA:
            //=======
            //Nome do drive
            //Verificar se o drive está pronto
            //Tipo do drive
            //Formato do drive
            //Espaço livre, em bytes, MB, GB e TB

            var drivers = DriveInfo.GetDrives();

            foreach (var driver in drivers)
            {
                Console.WriteLine("Nome: {0}", driver.Name);
                const double KILOBYTE = 1024;

                if (!driver.IsReady)
                {
                    Console.WriteLine("O driver não está pronto!");
                    continue;
                }

                Console.WriteLine("Tipo: {0}", driver.DriveType);
                Console.WriteLine("Formato: {0}", driver.DriveFormat);

                Console.WriteLine("Espaço livre:");
                long bytes = driver.TotalFreeSpace;
                Console.WriteLine("{0} bytes", bytes);

                var kb = (double)(bytes / KILOBYTE);
                Console.WriteLine("{0:N2} KB", kb);

                var mb = kb / KILOBYTE;
                Console.WriteLine("{0:N2} MB", mb);

                var gb = mb / KILOBYTE;
                Console.WriteLine("{0:N2} GB", gb);

                var tb = gb / KILOBYTE;
                Console.WriteLine("{0:N2} TB", tb);
                
                Console.WriteLine();
            }
        }
    }
}

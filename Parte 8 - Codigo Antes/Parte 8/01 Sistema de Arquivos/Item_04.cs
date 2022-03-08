using System;
using System.Collections.Generic;
using System.IO;
using System.IO.Compression;
using System.Text;

namespace Listings
{
    class Item_04 //Trabalhando com arquivos comprimidos
    {
        static void Main(string[] args)
        {
            using (var fluxoEntrada = new FileStream("ArquivoSaida.txt", FileMode.OpenOrCreate, FileAccess.Write))
            {
                using (GZipStream gZipStream = new GZipStream(fluxoEntrada, CompressionMode.Compress))
                {
                    using (StreamWriter gravadorFluxo = new StreamWriter(gZipStream))
                    {
                        gravadorFluxo.Write("Olá, Alura! (gravado com StreamWriter)");
                    }       
                }
            }

            using (var fluxoLeitura = new FileStream("ArquivoSaida.txt", FileMode.Open, FileAccess.Read))
            {
                using (GZipStream gZipStream = new GZipStream(fluxoLeitura, CompressionMode.Decompress))
                {
                    using (StreamReader leitorFluxo = new StreamReader(gZipStream))
                    {
                        string textoLido = leitorFluxo.ReadToEnd();
                        Console.WriteLine("Texto lido: {0}", textoLido);
                    }       
                }
            }
        }
    }
}

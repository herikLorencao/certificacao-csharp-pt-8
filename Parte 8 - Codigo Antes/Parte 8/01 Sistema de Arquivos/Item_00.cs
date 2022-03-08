using System;
using System.IO;

namespace Listings
{
    class Item_00 //Streams
    {
        static void XMain(string[] args)
        {
            //TAREFAS:
            //1. ABRIR O ARQUIVO Diretores.txt
            //2. LER 10 BYTES DO ARQUIVO
            //3. IMPRIMIR ESSES BYTES NO CONSOLE
            FileStream fileStream = new FileStream("Diretores.txt", FileMode.Open, FileAccess.Read);

            byte[] array = new byte[10];
            int posicao = 0;
            int tamanho = 10;

            fileStream.Read(array, posicao, tamanho);

            foreach (var caracter in array)
            {
                Console.Write((char)caracter);
            }

            // fileStream.Seek(5, SeekOrigin.Current);
            fileStream.Position = 3;
            
            fileStream.Read(array, posicao, tamanho);
            
            foreach (var caracter in array)
            {
                Console.Write((char)caracter);
            }
        }
    }
}
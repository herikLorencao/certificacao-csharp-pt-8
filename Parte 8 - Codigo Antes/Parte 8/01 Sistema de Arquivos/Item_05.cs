using System;
using System.Collections.Generic;
using System.IO;
using System.Text;

namespace Listings
{
    class Item_05 //A classe File
    {
        static void XMain(string[] args)
        {
            //TAREFAS: GRAVAR E LER DADOS DE UM ARQUIVO USANDO A CLASSE File
            string conteudoInicial = "Conteúdo Inicial do arquivo";
            string conteudoAdicional = "\nConteúdo adicional do arquivo";
            
            File.WriteAllText("Arquivo.txt", conteudoInicial);
            File.AppendAllText("Arquivo.txt", conteudoAdicional);
            
            if (File.Exists("Arquivo.txt"))
                Console.WriteLine("O Arquivo.txt já existe!");

            string conteudo = File.ReadAllText("Arquivo.txt");
            Console.WriteLine("Conteúdo do arquivo: {0}", conteudo);

            File.Copy("Arquivo.txt", "CopiaArquivo.txt", true);

            using (var leitor = File.OpenText("CopiaArquivo.txt"))
            {
                Console.WriteLine("Texto da cópia do arquivo: {0}", leitor.ReadToEnd());
            }
        }
    }
}

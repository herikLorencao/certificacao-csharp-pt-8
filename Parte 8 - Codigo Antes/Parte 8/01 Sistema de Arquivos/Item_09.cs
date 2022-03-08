using System;
using System.Collections.Generic;
using System.IO;
using System.Text;

namespace Listings
{
    class Item_09 //A Classe Directory
    {
        static void XMain(string[] args)
        {
            //TAREFA:
            //Criar um novo diretório
            //Verificar se ele foi criado
            //Apagar o diretório que foi criado
            const string diretorio = "NovoDiretorio";
            Directory.CreateDirectory(diretorio);
            if (Directory.Exists(diretorio))
            {
                Console.WriteLine("Diretório criado com sucesso");
            }
            Directory.Delete(diretorio);
            if (!Directory.Exists(diretorio))
            {
                Console.WriteLine("Diretório removido com sucesso");
            }
        }
    }
}

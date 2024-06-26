﻿using System;
using System.Collections.Generic;
using System.IO;
using System.Text;

namespace Listings
{
    class Item_06 //Stream exceptions
    {
        static void XMain(string[] args)
        {
            try
            {
                string conteudo = File.ReadAllText("ArquivoInexistente.txt");
                Console.WriteLine("O conteúdo é: {0}", conteudo);
            }
            catch (FileNotFoundException e)
            {
                Console.WriteLine("Arquivo não encontrado");
                Console.WriteLine(e.Message);
            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message);
            }
        }
    }
}

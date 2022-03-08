using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Net.Http;
using System.Text;
using System.Threading.Tasks;

namespace Listings
{
    class Item_25 //Json
    {
        static async Task XMain(string[] args)
        {
            //TAREFA:
            //CONSULTAR OS DADOS DO CEP 04101-300
            //NO SERVIÇO DA http://viacep.com.br
            //E EXIBIR SEUS DADOS

            string cep = "04101300";
            string url = $"http://viacep.com.br/ws/{cep}/json/";

            using (var cliente = new HttpClient())
            {
                var json = await cliente.GetStringAsync(url);
                var endereco = JsonConvert.DeserializeObject<Endereco>(json);
                
                Console.WriteLine(
                    $"Logradouro: {endereco.Logradouro}" +
                    $"\nBairro: {endereco.Bairro}" +
                    $"\nMunicípio: {endereco.Localidade}" +
                    $"\nUF: {endereco.Uf}" +
                    $"\nCEP: {endereco.Cep}");
            }

            Console.ReadKey();
        }
    }

    class Endereco
    {
        public string Cep { get; set; }
        public string Logradouro { get; set; }
        public string Bairro { get; set; }
        public string Localidade { get; set; }
        public string Uf { get; set; }
    }
}

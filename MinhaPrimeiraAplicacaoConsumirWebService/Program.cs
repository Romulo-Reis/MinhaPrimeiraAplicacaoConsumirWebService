using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MinhaPrimeiraAplicacaoConsumirWebService
{
    class Program
    {
        static void Main(string[] args)
        {
            string cep;
            Console.WriteLine("Bem vindo!");
            Console.WriteLine("Favor, informe o CEP:");
            cep = Console.ReadLine();
            var correios = new Correios.AtendeClienteClient();
            var consulta = correios.consultaCEP(cep.Replace("-",""));
            Endereco endereco = new Endereco();
            endereco.Descricao = consulta.end;
            endereco.Complemento = consulta.complemento2;
            endereco.Cidade = consulta.cidade;
            endereco.Bairro = consulta.bairro;
            endereco.Uf = consulta.uf;
            Console.WriteLine("=================Endereço======================");
            Console.WriteLine("Descricao:"+endereco.Descricao);
            Console.WriteLine("Complemento:"+endereco.Complemento);
            Console.WriteLine("Cidade:"+endereco.Cidade);
            Console.WriteLine("Bairro:"+endereco.Bairro);
            Console.WriteLine("UF:"+endereco.Uf);
            Console.WriteLine("==============================================");
            Console.ReadKey();

        }
    }
}

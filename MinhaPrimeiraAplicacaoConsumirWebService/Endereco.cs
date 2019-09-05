using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
//Aqui fica o namespace
namespace MinhaPrimeiraAplicacaoConsumirWebService
{
    class Endereco
    {
        private string descricao;
        private string complemento;
        private string bairro;
        private string cidade;
        private string uf;

        public string Descricao
        {
            get;
            set;
        }

        public string Complemento
        {
            get;
            set;
        }

        public string Bairro
        {
            get;
            set;
        }
        public string Cidade
        {
            get;
            set;
        }
        public string Uf
        {
            get;
            set;
        }

    }
}

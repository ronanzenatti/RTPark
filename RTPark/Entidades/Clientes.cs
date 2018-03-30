using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RTPark.Entidades
{
    class Clientes
    {
        private int idcliente;       
        private String nome;
        private char tipo_pessoa;
        private String doc_fed;
        private String doc_est;
        private String dt_nasc;
        private String rua;
        private String numero;
        private String bairro;
        private String cidade;
        private String estado;
        private String cep;
        private String telefones;
        private String email;

        public int Idcliente { get => idcliente; set => idcliente = value; }
        public string Nome { get => nome; set => nome = value; }
        public char Tipo_pessoa { get => tipo_pessoa; set => tipo_pessoa = value; }
        public string Doc_fed { get => doc_fed; set => doc_fed = value; }
        public string Doc_est { get => doc_est; set => doc_est = value; }
        public string Dt_nasc { get => dt_nasc; set => dt_nasc = value; }
        public string Rua { get => rua; set => rua = value; }
        public string Numero { get => numero; set => numero = value; }
        public string Bairro { get => bairro; set => bairro = value; }
        public string Cidade { get => cidade; set => cidade = value; }
        public string Estado { get => estado; set => estado = value; }
        public string Cep { get => cep; set => cep = value; }
        public string Telefones { get => telefones; set => telefones = value; }
        public string Email { get => email; set => email = value; }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RTPark.Entidades
{
    class Funcionarios
    {
        private int idfuncionario;
        private String nome;
        private String cpf;
        private String rg;
        private String dt_nasc;
        private String rua;
        private String numero;
        private String bairro;
        private String cidade;
        private String estado;
        private String cep;
        private String telefones;
        private String email;
        private Decimal salario;
        private String usuario;
        private String senha;
        private char tipo;
        private int ativo;

        public int Idfuncionario { get => idfuncionario; set => idfuncionario = value; }
        public string Nome { get => nome; set => nome = value; }
        public string Cpf { get => cpf; set => cpf = value; }
        public string Rg { get => rg; set => rg = value; }
        public string Dt_nasc { get => dt_nasc; set => dt_nasc = value; }
        public string Rua { get => rua; set => rua = value; }
        public string Numero { get => numero; set => numero = value; }
        public string Bairro { get => bairro; set => bairro = value; }
        public string Cidade { get => cidade; set => cidade = value; }
        public string Estado { get => estado; set => estado = value; }
        public string Cep { get => cep; set => cep = value; }
        public string Telefones { get => telefones; set => telefones = value; }
        public string Email { get => email; set => email = value; }
        public decimal Salario { get => salario; set => salario = value; }
        public string Usuario { get => usuario; set => usuario = value; }
        public string Senha { get => senha; set => senha = value; }
        public char Tipo { get => tipo; set => tipo = value; }
        public int Ativo { get => ativo; set => ativo = value; }
    }
}

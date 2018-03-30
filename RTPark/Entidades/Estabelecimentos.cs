using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RTPark.Entidades
{
    class Estabelecimentos
    {
        int idestabelecimento;
        String nome;
        String cnpj;
        String rua;
        String numero;
        String complemento;
        String bairro;
        String cidade;
        String estado;
        String cep;
        String telefones;
        String email;
        int vagas_carro; 
        int vagas_moto; 
        int vagas_outros;

        public int Idestabelecimento { get => idestabelecimento; set => idestabelecimento = value; }
        public string Nome { get => nome; set => nome = value; }
        public string Cnpj { get => cnpj; set => cnpj = value; }
        public string Rua { get => rua; set => rua = value; }
        public string Numero { get => numero; set => numero = value; }
        public string Complemento { get => complemento; set => complemento = value; }
        public string Bairro { get => bairro; set => bairro = value; }
        public string Cidade { get => cidade; set => cidade = value; }
        public string Estado { get => estado; set => estado = value; }
        public string Cep { get => cep; set => cep = value; }
        public string Telefones { get => telefones; set => telefones = value; }
        public string Email { get => email; set => email = value; }
        public int Vagas_carro { get => vagas_carro; set => vagas_carro = value; }
        public int Vagas_moto { get => vagas_moto; set => vagas_moto = value; }
        public int Vagas_outros { get => vagas_outros; set => vagas_outros = value; }
    }
}

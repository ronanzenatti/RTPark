using System;

namespace RTPark.Entidades
{
    public class Estabelecimentos
    {
        private int idestabelecimento;
        private String nome;
        private String cnpj;
        private String rua;
        private String numero;
        private String complemento;
        private String bairro;
        private String cidade;
        private String estado;
        private String cep;
        private String telefones;
        private String email;
        private int vagas_carro;
        private int vagas_moto;
        private int vagas_outros;

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

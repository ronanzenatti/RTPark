using System;

namespace RTPark.Entidades
{
    public class VeiculosClientes
    {
        private int idvc;
        private int idcliente;
        private String placa;
        private String veiculo;
        private char tipo;
        private int ativo;

        public int Idvc { get => idvc; set => idvc = value; }
        public int Idcliente { get => idcliente; set => idcliente = value; }
        public string Placa { get => placa; set => placa = value; }
        public string Veiculo { get => veiculo; set => veiculo = value; }
        public char Tipo { get => tipo; set => tipo = value; }
        public int Ativo { get => ativo; set => ativo = value; }
    }
}

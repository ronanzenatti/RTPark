using System;
namespace RTPark.Entidades
{
    public class Contratos
    {
        private int idcontrato;
        private String descricao;
        private int idcliente;
        private int idservico;
        private char tipoPagamento;
        private int vencimento;
        private String dtInicio;
        private String dtTermino;

        public int Idcontrato { get => idcontrato; set => idcontrato = value; }
        public string Descricao { get => descricao; set => descricao = value; }
        public int Idcliente { get => idcliente; set => idcliente = value; }
        public int Idservico { get => idservico; set => idservico = value; }
        public char TipoPagamento { get => tipoPagamento; set => tipoPagamento = value; }
        public int Vencimento { get => vencimento; set => vencimento = value; }
        public string DtInicio { get => dtInicio; set => dtInicio = value; }
        public string DtTermino { get => dtTermino; set => dtTermino = value; }
    }
}

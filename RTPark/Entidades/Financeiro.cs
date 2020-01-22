using System;

namespace RTPark.Entidades
{
    public class Financeiro
    {
        private int idFinanceiro;
        private int idEstabelecimento;
        private int idFuncionario;
        private string descricao;
        private int idMovimento;
        private int idFatura;
        private string dhLancamento;
        private char tipoLancamento;
        private int idFormaPagamento;
        private char fatExcedente;
        private int numeroRecibo;
        private decimal subtotal;
        private decimal excedente;
        private decimal desconto;
        private decimal total;
        private decimal dinheiro;
        private decimal troco;
        private decimal multa;
        private decimal juros;
        private string dhCancelamento;
        private string motivoCancelamento;
        private decimal valorCancelado;

        public int IdFinanceiro { get => idFinanceiro; set => idFinanceiro = value; }
        public int IdEstabelecimento { get => idEstabelecimento; set => idEstabelecimento = value; }
        public int IdFuncionario { get => idFuncionario; set => idFuncionario = value; }
        public string Descricao { get => descricao; set => descricao = value; }
        public int IdMovimento { get => idMovimento; set => idMovimento = value; }
        public int IdFatura { get => idFatura; set => idFatura = value; }
        public string DhLancamento { get => dhLancamento; set => dhLancamento = value; }
        public char TipoLancamento { get => tipoLancamento; set => tipoLancamento = value; }
        public int IdFormaPagamento { get => idFormaPagamento; set => idFormaPagamento = value; }
        public char FatExcedente { get => fatExcedente; set => fatExcedente = value; }
        public int NumeroRecibo { get => numeroRecibo; set => numeroRecibo = value; }
        public decimal Subtotal { get => subtotal; set => subtotal = value; }
        public decimal Excedente { get => excedente; set => excedente = value; }
        public decimal Desconto { get => desconto; set => desconto = value; }
        public decimal Total { get => total; set => total = value; }
        public decimal Dinheiro { get => dinheiro; set => dinheiro = value; }
        public decimal Troco { get => troco; set => troco = value; }
        public decimal Multa { get => multa; set => multa = value; }
        public decimal Juros { get => juros; set => juros = value; }
        public string DhCancelamento { get => dhCancelamento; set => dhCancelamento = value; }
        public string MotivoCancelamento { get => motivoCancelamento; set => motivoCancelamento = value; }
        public decimal ValorCancelado { get => valorCancelado; set => valorCancelado = value; }
    }
}

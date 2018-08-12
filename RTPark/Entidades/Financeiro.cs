using System;

namespace RTPark.Entidades
{
    public class Financeiro
    {
        private int idfatura;
        private int idcontrato;
        private string referencia;
        private string lancamento;
        private string vencimento;
        private string pagamento;
        private string baixa;
        private decimal subtotal;
        private decimal juros;
        private decimal multa;
        private decimal desconto;
        private decimal total;
        private char tipo_desconto;
        private string texto;
        private string cancelamento;
        private decimal valor_cancelado;

        public int Idfatura { get => idfatura; set => idfatura = value; }
        public int Idcontrato { get => idcontrato; set => idcontrato = value; }
        public string Referencia { get => referencia; set => referencia = value; }
        public string Lancamento { get => lancamento; set => lancamento = value; }
        public string Vencimento { get => vencimento; set => vencimento = value; }
        public string Pagamento { get => pagamento; set => pagamento = value; }
        public string Baixa { get => baixa; set => baixa = value; }
        public decimal Subtotal { get => subtotal; set => subtotal = value; }
        public decimal Juros { get => juros; set => juros = value; }
        public decimal Multa { get => multa; set => multa = value; }
        public decimal Desconto { get => desconto; set => desconto = value; }
        public decimal Total { get => total; set => total = value; }
        public char Tipo_desconto { get => tipo_desconto; set => tipo_desconto = value; }
        public string Texto { get => texto; set => texto = value; }
        public string Cancelamento { get => cancelamento; set => cancelamento = value; }
        public decimal Valor_cancelado { get => valor_cancelado; set => valor_cancelado = value; }
    }
}

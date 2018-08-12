using System;

namespace RTPark.Entidades
{
    public class FormaPagamento
    {
        private int idforma;
        private String descricao;
        private decimal taxa;
        private bool ativo;
        private int idestabelecimento;

        public int Idforma { get => idforma; set => idforma = value; }
        public string Descricao { get => descricao; set => descricao = value; }
        public decimal Taxa { get => taxa; set => taxa = value; }
        public bool Ativo { get => ativo; set => ativo = value; }
        public int Idestabelecimento { get => idestabelecimento; set => idestabelecimento = value; }
    }
}

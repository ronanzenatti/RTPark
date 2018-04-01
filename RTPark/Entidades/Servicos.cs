using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RTPark.Entidades
{
    public class Servicos
    {
        private int idservico;
        private String descricao;
        private char tipoCobranca;
        private int quantidade;
        private Decimal valorCarro;
        private Decimal valorMoto;
        private Decimal valorOutros;
        private int ativo;

        public int Idservico { get => idservico; set => idservico = value; }
        public string Descricao { get => descricao; set => descricao = value; }
        public char TipoCobranca { get => tipoCobranca; set => tipoCobranca = value; }
        public int Quantidade { get => quantidade; set => quantidade = value; }
        public decimal ValorCarro { get => valorCarro; set => valorCarro = value; }
        public decimal ValorMoto { get => valorMoto; set => valorMoto = value; }
        public decimal ValorOutros { get => valorOutros; set => valorOutros = value; }
        public int Ativo { get => ativo; set => ativo = value; }
    }
}

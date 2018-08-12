using System;

namespace RTPark.Entidades
{
    public class Movimentos
    {
        private int idmovimento;
        private String dhEntrada;
        private String dhSaida;
        private String placa;
        private char tipoVeiculo;
        private String veiculo;
        private int vaga;
        private int idservico;
        private int idfuncionario;
        private int idcontrato;
        private long permanencia;
        private int excedente;
        private int periodos;
        private String docFed;

        public int Idmovimento { get => idmovimento; set => idmovimento = value; }
        public string DhEntrada { get => dhEntrada; set => dhEntrada = value; }
        public string DhSaida { get => dhSaida; set => dhSaida = value; }
        public string Placa { get => placa; set => placa = value; }
        public char TipoVeiculo { get => tipoVeiculo; set => tipoVeiculo = value; }
        public string Veiculo { get => veiculo; set => veiculo = value; }
        public int Vaga { get => vaga; set => vaga = value; }
        public int Idservico { get => idservico; set => idservico = value; }
        public int Idfuncionario { get => idfuncionario; set => idfuncionario = value; }
        public int Idcontrato { get => idcontrato; set => idcontrato = value; }
        public long Permanencia { get => permanencia; set => permanencia = value; }
        public int Excedente { get => excedente; set => excedente = value; }
        public int Periodos { get => periodos; set => periodos = value; }
        public string DocFed { get => docFed; set => docFed = value; }
    }
}

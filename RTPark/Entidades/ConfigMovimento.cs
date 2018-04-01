using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;

namespace RTPark.Entidades
{
    public class ConfigMovimento
    {
        private int idconfig;
        private int idestabelecimento;
        private int cobrancaPadrao;
        private char imprimeEntrada;
        private char imprimeSaida;
        private int imprimeEnd;
        private int imprimeTelefones;
        private int imprimeCnpj;

        public int Idconfig { get => idconfig; set => idconfig = value; }
        public int Idestabelecimento { get => idestabelecimento; set => idestabelecimento = value; }
        public int CobrancaPadrao { get => cobrancaPadrao; set => cobrancaPadrao = value; }
        public char ImprimeEntrada { get => imprimeEntrada; set => imprimeEntrada = value; }
        public char ImprimeSaida { get => imprimeSaida; set => imprimeSaida = value; }
        public int ImprimeEnd { get => imprimeEnd; set => imprimeEnd = value; }
        public int ImprimeTelefones { get => imprimeTelefones; set => imprimeTelefones = value; }
        public int ImprimeCnpj { get => imprimeCnpj; set => imprimeCnpj = value; }
    }
}
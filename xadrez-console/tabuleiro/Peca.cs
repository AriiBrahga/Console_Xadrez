using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace tabuleiro
{
    internal class Peca
    {
        public Posicao Posicao { get; set; }
        public Cor Cor { get; protected set; }
        public int QteMovimento { get; protected set; }
        public Tabuleiro Tab { get; protected set; }

        public Peca(Posicao posicao, Cor cor, int qteMovimento, Tabuleiro tab)
        {
            Posicao = posicao;
            Cor = cor;
            QteMovimento = qteMovimento;
            Tab = tab;
        }
    }
}

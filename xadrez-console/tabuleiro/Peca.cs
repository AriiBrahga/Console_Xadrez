
namespace tabuleiro
{
    internal class Peca
    {
        public Posicao Posicao { get; set; }
        public Cor Cor { get; protected set; }
        public int QteMovimento { get; protected set; }
        public Tabuleiro Tab { get; protected set; }

        public Peca(Cor cor, Tabuleiro tab)
        {
            Posicao = null;
            Cor = cor;
            QteMovimento = 0;
            Tab = tab;
        }

        public void IncrementarQteMovimentos()
        {
            QteMovimento++;
        }

    }
}

using System;
using xadrez;
using tabuleiro;

namespace xadrez_console
{
    class Program
    {
        static void Main(string[] args)
        {
            try
            {
                Tabuleiro tab = new Tabuleiro(8, 8);

                tab.ColocarPeca(new Torre(Cor.Preta, tab), new Posicao(0, 0));
                tab.ColocarPeca(new Torre(Cor.Preta, tab), new Posicao(1, 7));
                tab.ColocarPeca(new Rei(Cor.Preta, tab), new Posicao(0, 2));

                tab.ColocarPeca(new Rei(Cor.Branca, tab), new Posicao(2, 5));
                tab.ColocarPeca(new Torre(Cor.Branca, tab), new Posicao(5, 7));


                Tela.imprimirTabuleiro(tab);
            }
            catch (TabuleiroException ex)
            {
                Console.WriteLine(ex.Message);
            }


        }
    }
}
﻿using System;
using xadrez;
using tabuleiro;

namespace xadrez_console
{
    class Program
    {
        static void Main(string[] args)
        {
            /*try
            {
                Tabuleiro tab = new Tabuleiro(8, 8);

                tab.ColocarPeca(new Torre(Cor.Preta, tab), new Posicao(0, 0));
                tab.ColocarPeca(new Torre(Cor.Preta, tab), new Posicao(1, 9));
                tab.ColocarPeca(new Rei(Cor.Preta, tab), new Posicao(0, 2));


                Tela.imprimirTabuleiro(tab);
            }
            catch (TabuleiroException ex)
            {
                Console.WriteLine(ex.Message);
            }*/

            PosicaoXadrez pos = new PosicaoXadrez('a', 1);


            Console.WriteLine(pos);

            Console.WriteLine(pos.ToPosicao());

        }
    }
}
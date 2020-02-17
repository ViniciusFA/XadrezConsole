using System;
using tabuleiro;
using xadrez;

namespace Program{
    class Program
    {
        static void Main(string[] args)
        {
            Tabuleiro tab = new Tabuleiro(8, 8);
           
            tab.colorcarPeca(new Torre(tab,Cor.Preta), new Posicao(0, 0));
            tab.colorcarPeca(new Torre(tab, Cor.Preta), new Posicao(1, 3));
            tab.colorcarPeca(new Rei(tab, Cor.Preta), new Posicao(2, 4));            

            Tela.imprimirTabuleiro(tab);

            Console.ReadLine();
        }
    }
}
